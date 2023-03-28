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
    class csLISTAR_PRODUCTOS_PARA_COMBOS
    {
        cConexion conexion = new cConexion();
        public string PalabraClave;
        private int Producto_ID;
        private string Producto_name;
        private int Stock_produc;
        private string Precio;

     
        public int Producto_ID__
        {
            get { return Producto_ID; }
            set { Producto_ID = value; }
        }
        public string Producto_name__
        {
            get { return Producto_name; }
            set { Producto_name = value; }
        }
        public int Stock_produc__
        {
            get { return Stock_produc; }
            set { Stock_produc = value; }
        }
        public string Precio__
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public List<csLISTAR_PRODUCTOS_PARA_COMBOS> listarpro()
        {

            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRODUCTOS_PARA_COMBOS", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@PlabraClave", PalabraClave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csLISTAR_PRODUCTOS_PARA_COMBOS> lstEspe = new List<csLISTAR_PRODUCTOS_PARA_COMBOS>();
            csLISTAR_PRODUCTOS_PARA_COMBOS objeraza;
            while (dr.Read())
            {
                objeraza = new csLISTAR_PRODUCTOS_PARA_COMBOS();
                //(objeraza.ProveedorID_ = dr.GetInt32(0);
                objeraza.Producto_ID__ = dr.GetInt32(0);
                objeraza.Producto_name__ = dr.GetString(1);
                objeraza.Stock_produc__ = dr.GetInt32(2);
                objeraza.Precio__ = dr.GetDecimal(3).ToString("N2");
                lstEspe.Add(objeraza);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEspe;
        }


        public List<csLISTAR_PRODUCTOS_PARA_COMBOS> listarproparaoferta()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRODUCTOS_PARA_OFERTAS", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@PlabraClave", PalabraClave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csLISTAR_PRODUCTOS_PARA_COMBOS> lstEspe = new List<csLISTAR_PRODUCTOS_PARA_COMBOS>();
            csLISTAR_PRODUCTOS_PARA_COMBOS objeraza;
            while (dr.Read())
            {
                objeraza = new csLISTAR_PRODUCTOS_PARA_COMBOS();
                //(objeraza.ProveedorID_ = dr.GetInt32(0);
                objeraza.Producto_ID__ = dr.GetInt32(0);
                objeraza.Producto_name__ = dr.GetString(1);
                objeraza.Stock_produc__ = dr.GetInt32(2);
                objeraza.Precio__ = dr.GetDecimal(3).ToString("N2");
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
