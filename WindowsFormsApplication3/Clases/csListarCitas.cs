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
    class csListarCitas
    {
        cConexion conexion = new cConexion();
        public DateTime fech;
        private DateTime Fecha_Destinada;
        private string Hora_Llegada;
        private string Estado_Cita;
        private string Hora_destina;
        private int Tiempo_Duracion_Min;
        private string NombreCliente;
        private string ApellidoCliente;
        private string Nombre_Empleado_Atender;
        private string Apellidos_EmpleadO_Atender;
        private string Nombre_Empleados_Agenda;
        private string Apellidos_Empleados_Agenda;
        private int Cita_ID;
        private int Detalle_Cita_ID;

        //GETS Y SETS
        public DateTime Fecha_Destinada1
        {
            get { return Fecha_Destinada; }
            set { Fecha_Destinada = value; }
        }
        public string Hora_Llegada1
        {
            get { return Hora_Llegada; }
            set { Hora_Llegada = value; }
        }
        public string Estado_Cita1
        {
            get { return Estado_Cita; }
            set { Estado_Cita = value; }
        }
        public string Hora_destina1
        {
            get { return Hora_destina; }
            set { Hora_destina = value; }
        }
        public int Tiempo_Duracion_Min1
        {
            get { return Tiempo_Duracion_Min; }
            set { Tiempo_Duracion_Min = value; }
        }
        public string NombreCliente1
        {
            get { return NombreCliente; }
            set { NombreCliente = value; }
        }
        public string ApellidoCliente1
        {
            get { return ApellidoCliente; }
            set { ApellidoCliente = value; }
        }
        public string Nombre_Empleado_Atender1
        {
            get { return Nombre_Empleado_Atender; }
            set { Nombre_Empleado_Atender = value; }
        }
        public string Apellidos_EmpleadO_Atender1
        {
            get { return Apellidos_EmpleadO_Atender; }
            set { Apellidos_EmpleadO_Atender = value; }
        }
        public string Nombre_Empleados_Agenda1
        {
            get { return Nombre_Empleados_Agenda; }
            set { Nombre_Empleados_Agenda = value; }
        }
        public string Apellidos_Empleados_Agenda1
        {
            get { return Apellidos_Empleados_Agenda; }
            set { Apellidos_Empleados_Agenda = value; }
        }
        public int Cita_ID1
        {
            get { return Cita_ID; }
            set { Cita_ID = value; }
        }
        public int Detalle_Cita_ID1
        {
            get { return Detalle_Cita_ID; }
            set { Detalle_Cita_ID = value; }
        }


        public List<csListarCitas> listarCitasD()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_CITAS_FECHA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();

            cmd.Parameters.AddWithValue("@Fecha",fech);

            dr = cmd.ExecuteReader();

            List<csListarCitas> lstCitas = new List<csListarCitas>();
            csListarCitas objcitas;
            while (dr.Read())
            {
                objcitas = new csListarCitas();
                objcitas.Fecha_Destinada1 = dr.GetDateTime(0);
                objcitas.Hora_Llegada1 = dr.GetString(1);
                objcitas.Estado_Cita1 = dr.GetString(2);
                objcitas.Hora_destina1 = dr.GetString(3).Substring(0,5);
                objcitas.Tiempo_Duracion_Min1 = dr.GetInt32(4);
                objcitas.NombreCliente1 = dr.GetString(5);
                objcitas.ApellidoCliente1 = dr.GetString(6);
                objcitas.Nombre_Empleado_Atender1 = dr.GetString(7);
                objcitas.Apellidos_EmpleadO_Atender1 = dr.GetString(8);
                objcitas.Nombre_Empleados_Agenda1 = dr.GetString(9);
                objcitas.Apellidos_Empleados_Agenda1 = dr.GetString(10);
                objcitas.Cita_ID1 = dr.GetInt32(11);
                objcitas.Detalle_Cita_ID1 = dr.GetInt32(12);

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
