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
    class Listar_Ofertas
    {
        cConexion conexion = new cConexion(); //CONEXION
        private int oferta_id;
        private int product_id;
        private string nombre_producto;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private decimal descuento;
        private int cantidad;
        private decimal precio;
        private decimal precio_oferta;
        private int estado;

      
        // GETS Y SETS 
        public int Oferta_id_
        {
            get { return oferta_id; }
            set { oferta_id = value; }
        }
        public int Product_id_
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public string Nombre_producto_
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }
        public DateTime Fecha_inicio_
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        public DateTime Fecha_fin_
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public decimal Descuento_
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int Cantidad_
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal Precio_
        {
            get { return precio; }
            set { precio = value; }
        }
        public decimal Precio_oferta_
        {
            get { return precio_oferta; }
            set { precio_oferta = value; }
        }
        public int Estado_
        {
            get { return estado; }
            set { estado = value; }
        }

        public List<Listar_Ofertas> listarEmpleado()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_OFERTAS_VER", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<Listar_Ofertas> lstEmple = new List<Listar_Ofertas>();
            Listar_Ofertas objemple;
            while (dr.Read())
            {
                objemple = new Listar_Ofertas();
                objemple.Oferta_id_ = dr.GetInt32(0);
                objemple.Product_id_ = dr.GetInt32(1);
                objemple.Nombre_producto_ = dr.GetString(2);
                objemple.Fecha_inicio_ = dr.GetDateTime(3);
                objemple.Fecha_fin_ = dr.GetDateTime(4);
                objemple.Descuento_ = decimal.Parse(dr.GetSqlSingle(5).ToString());
                objemple.Cantidad_ = dr.GetInt32(6);
                objemple.Precio_ = decimal.Parse(dr.GetDecimal(7).ToString("N2"));
                objemple.Precio_oferta_ = decimal.Parse(dr.GetSqlSingle(8).ToString());
                objemple.Estado_ = dr.GetInt32(9);
                lstEmple.Add(objemple);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEmple;
        }
    }
}
