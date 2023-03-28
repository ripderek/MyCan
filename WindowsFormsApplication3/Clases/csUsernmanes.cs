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
    class csUsernmanes
    {
        cConexion conexion = new cConexion();
        private string Username;

        public string Username1
        {
            get { return Username; }
            set { Username = value; }
        }
        
        
        public string Palabra_Clave;

        public List<csUsernmanes> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_USARIO_TXT", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@Palabra", Palabra_Clave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csUsernmanes> lstEspe = new List<csUsernmanes>();
            csUsernmanes objeraza;
            while (dr.Read())
            {
                objeraza = new csUsernmanes();
                objeraza.Username1 = dr.GetString(0);
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
