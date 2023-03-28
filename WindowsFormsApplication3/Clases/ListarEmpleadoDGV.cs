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
    class ListarEmpleadoDGV
    {
        cConexion conexion = new cConexion();
        private string Nombre;
        private string Apellido;
        private string T_Identi;
        private string Identificacion;
        private string Celular;
        private string area;
        private string Tipo;
        private int oficina;
        private int id;

       
        public string Nombre_Persona
        {
            get { return Nombre; }
            set { Nombre = value; }

        }
        public string Apellido_Persona
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public string T_Identi_Persona
        {
            get { return T_Identi; }
            set { T_Identi = value; }
        }
        public string Identificacion_Persona
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }
        public string Celular_Persona
        {
            get { return Celular; }
            set { Celular = value; }
        }
        public string Area_A
        {
            get { return area; }
            set { area = value; }
        }
        public string tipo_A
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public int oficina_A
        {
            get { return oficina; }
            set { oficina = value; }
        }
        public int Id_
        {
            get { return id; }
            set { id = value; }
        }



       public List<ListarEmpleadoDGV> listarEmpleado()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_EMPLEADOS_DTG", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<ListarEmpleadoDGV> lstEmple = new List<ListarEmpleadoDGV>();
            ListarEmpleadoDGV objemple;
            while (dr.Read())
            {
                objemple = new ListarEmpleadoDGV();
                objemple.Nombre_Persona = dr.GetString(0);
                objemple.Apellido_Persona = dr.GetString(1);
                objemple.T_Identi_Persona = dr.GetString(2);
                objemple.Identificacion_Persona = dr.GetString(3);
                objemple.Celular_Persona = dr.GetString(4);
                objemple.Area_A=dr.GetString(5);
                objemple.tipo_A=dr.GetString(6);
                objemple.oficina_A=dr.GetInt32(7);
                objemple.Id_ = dr.GetInt32(8);
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
