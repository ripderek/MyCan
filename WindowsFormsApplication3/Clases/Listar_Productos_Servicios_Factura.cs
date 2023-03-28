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
    class Listar_Productos_Servicios_Factura
    {
        cConexion conexion = new cConexion();
        private int producto_id;
        private string producto_nombre;
        private string precio_venta;
        public string palabra_clave;
        
        public int Producto_id_
        {
            get { return producto_id; }
            set { producto_id = value; }
        }
        public string Producto_
        {
            get { return producto_nombre; }
            set { producto_nombre = value; }
        }
        public string Precio_
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }

        public List<Listar_Productos_Servicios_Factura> listarpro()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRODUCTOS_SERVICIOS_FACTURA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@Palabra_Clave", palabra_clave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<Listar_Productos_Servicios_Factura> lstEspe = new List<Listar_Productos_Servicios_Factura>();
            Listar_Productos_Servicios_Factura objeraza;
            while (dr.Read())
            {
                objeraza = new Listar_Productos_Servicios_Factura();
                //(objeraza.ProveedorID_ = dr.GetInt32(0);
                objeraza.Producto_id_ = dr.GetInt32(0);
                objeraza.Producto_ = dr.GetString(1);
                objeraza.Precio_ = dr.GetDecimal(2).ToString("N2");
                lstEspe.Add(objeraza);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEspe;
        }

    }
}
