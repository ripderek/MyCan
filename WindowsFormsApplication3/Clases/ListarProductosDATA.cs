using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    class ListarProductosDATA
    {
        cConexion conexion = new cConexion();
        //PROPIEDADES DE LA CLASE 
        private int producto_id;     
        private string nombre_producto;       
        private string precio_venta;       
        private int stock;     
        private string cantidad_por_unidad;       
        private string nombre_categoria;       
        private int categoria_id;
        private int estado;

        
        //GETS Y SETS 
        public int Producto_id_
        {
            get { return producto_id; }
            set { producto_id = value; }
        }
        public string Nombre_producto_
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }
        public string Precio_venta_
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }
        public int Stock_
        {
            get { return stock; }
            set { stock = value; }
        }
        public string Cantidad_por_unidad_
        {
            get { return cantidad_por_unidad; }
            set { cantidad_por_unidad = value; }
        }
        public string Nombre_categoria_
        {
            get { return nombre_categoria; }
            set { nombre_categoria = value; }
        }
        public int Categoria_id_
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public List<ListarProductosDATA> listarProductos()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRODUCTOS_DATA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<ListarProductosDATA> lstClien = new List<ListarProductosDATA>();
            ListarProductosDATA objclien;
            while (dr.Read())
            {
                objclien = new ListarProductosDATA();
                objclien.Producto_id_ = dr.GetInt32(0);
                objclien.Nombre_producto_ = dr.GetString(1);
                objclien.Precio_venta_ = dr.GetDecimal(2).ToString("N2");
                objclien.Stock_ = dr.GetInt32(3);
                objclien.Cantidad_por_unidad_ = dr.GetString(4);
                objclien.Nombre_categoria_ = dr.GetString(5);
                objclien.Categoria_id_ = dr.GetInt32(6);
                objclien.Estado = dr.GetInt32(7);
                lstClien.Add(objclien);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstClien;
        }

    }
}
