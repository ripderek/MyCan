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
    class ListarRazas
    {
        cConexion conexion = new cConexion();
        private int ID_espe;
        private int ID_raza;
        private string raza;

        public string Raza_Animal
        {
            get { return raza; }
            set { raza = value; }
        }

        public int ID_ES
        {
            get { return ID_espe; }
            set { ID_espe = value; }
        }
        public int ID_RA
        {
            get { return ID_raza; }
            set { ID_raza = value; }
        }

        public List<ListarRazas> listarRazas()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_RAZAS_DTGV", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@ID_especie",ID_ES );
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<ListarRazas> lstEspe = new List<ListarRazas>();
            ListarRazas objeraza;
            while (dr.Read())
            {
                objeraza = new ListarRazas();
                objeraza.ID_RA = dr.GetInt32(0);
                objeraza.ID_ES = dr.GetInt32(1);
                objeraza.Raza_Animal = dr.GetString(2);
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
