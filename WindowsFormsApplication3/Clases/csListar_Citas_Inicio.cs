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
    class csListar_Citas_Inicio
    {
        cConexion conexion = new cConexion();
        private DateTime fech = DateTime.UtcNow.Date;
        private string NombreCliente;
        private string Hora_destina;
        public string NombreCliente1
        {
            get { return NombreCliente; }
            set { NombreCliente = value; }
        }
        public string Hora_destina1
        {
            get { return Hora_destina; }
            set { Hora_destina = value; }
        }

        public List<csListar_Citas_Inicio> listarCitasD()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LITAS_CITAS_INICIO", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();

            cmd.Parameters.AddWithValue("@Fecha", fech);

            dr = cmd.ExecuteReader();

            List<csListar_Citas_Inicio> lstCitas = new List<csListar_Citas_Inicio>();
            csListar_Citas_Inicio objcitas;
            while (dr.Read())
            {
                objcitas = new csListar_Citas_Inicio();
                objcitas.NombreCliente1 = dr.GetString(0);
                objcitas.Hora_destina1 = dr.GetString(1).Substring(0, 5);                         
                lstCitas.Add(objcitas);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstCitas;
        }
    }
}
