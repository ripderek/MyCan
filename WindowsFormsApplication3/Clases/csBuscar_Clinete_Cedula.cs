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
    class csBuscar_Clinete_Cedula
    {
        cConexion conexion = new cConexion();
        private int cliente_id;
        private string numero_identificacion;
        private string cliente_apellido;
        public string palabra_clave;
        public int Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        public string Numero_identificacion
        {
            get { return numero_identificacion; }
            set { numero_identificacion = value; }
        }
        public string Cliente_apellido
        {
            get { return cliente_apellido; }
            set { cliente_apellido = value; }
        }
        public List<csBuscar_Clinete_Cedula> listarpro()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CLIENTE_PALABRA_CLAVE", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@Palabra_clave", palabra_clave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csBuscar_Clinete_Cedula> lstEspe = new List<csBuscar_Clinete_Cedula>();
            csBuscar_Clinete_Cedula objeraza;
            while (dr.Read())
            {
                objeraza = new csBuscar_Clinete_Cedula();
                //(objeraza.ProveedorID_ = dr.GetInt32(0);
                objeraza.Cliente_id = dr.GetInt32(0);
                objeraza.Numero_identificacion = dr.GetString(1);
                objeraza.Cliente_apellido = dr.GetString(2);
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
