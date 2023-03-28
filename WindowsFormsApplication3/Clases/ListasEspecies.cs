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
    class ListasEspecies
    {
        cConexion conexion = new cConexion();
        private int ID;
        private string especie;

        public int ID_ES
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Nombre_Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public List<ListasEspecies> listarEspecie()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_ESPECIES_DTGV", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<ListasEspecies> lstEspe = new List<ListasEspecies>();
            ListasEspecies objespe;
            while (dr.Read())
            {
                objespe = new ListasEspecies();
                objespe.ID_ES = dr.GetInt32(0);
                objespe.Nombre_Especie = dr.GetString(1);
                lstEspe.Add(objespe);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEspe;
        }

    }
}
