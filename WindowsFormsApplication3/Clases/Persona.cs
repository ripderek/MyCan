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
    class Persona
    {
        cConexion conexion = new cConexion();


        private string nombres;
        private string apellidos;
        private string tipo_identificacion;
        private string identificacion;
        private string numero_celular;
        private string direccion;
        private int ID_P;
        public int ID
        {
            get { return ID_P; }
            set { ID_P= value; }
        }
        public string Nombre_Persona
        {
            get { return nombres; }
            set { nombres = value; }

        }
        public string Apellido_Persona
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string T_Identi_Persona
        {
            get { return tipo_identificacion; }
            set { tipo_identificacion = value; }
        }
        public string Identificacion_Persona
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        public string Celular_Persona
        {
            get { return numero_celular; }
            set { numero_celular = value; }
        }
        public string Direccion_Persona
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Persona(string Nom, string Ape, string Tiden, string iden, string numc, string dir)
        {
            Nombre_Persona = Nom; Apellido_Persona = Ape; T_Identi_Persona = Tiden; Identificacion_Persona = iden; Celular_Persona = numc; Direccion_Persona = dir;
            InsertarPersona();
        }

        //SOBRECARGA #1
        //ESTA SOBRECARGAR ME AYUDARÁ A OBTENER LA INFORMACION DE UNA PERSONA SEGUN EL NUMERO DE CEDULA QUE SE INGRESE
        public Persona(string ced_ced)
        {
            Datos_Persona(ced_ced);
        }

        //SOBRECARGAR #2
        //ESTA SOBRECARGA SIRVE PARA MODIFICAR PERSONA SEGUN EL ID
        public Persona(int IDS,string Nom, string Ape, string Tiden, string iden, string numc, string dir)
        {
            ID = IDS; Nombre_Persona = Nom; Apellido_Persona = Ape; T_Identi_Persona = Tiden; Identificacion_Persona = iden; Celular_Persona = numc; Direccion_Persona = dir;
            Modificar_Persona();
        }

        //SOBRECARGAR #3 
        //SOBRECARGA PARA SACAR LOS DATOS DE PERSONA MEDIANTE EL ID

        //SOBRECARGA #4
        //NO RECUERDO PARA QUE SIRVE PERO NO LA BORREN XD 
        public Persona()
        {
 
        }


        private void InsertarPersona()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PERSONA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Nom", Nombre_Persona);
                cmd.Parameters.AddWithValue("@Apellido", Apellido_Persona);
                cmd.Parameters.AddWithValue("@Tipo_Identificacion", T_Identi_Persona);
                cmd.Parameters.AddWithValue("@Identificacion",Identificacion_Persona);
                cmd.Parameters.AddWithValue("@Celular", Celular_Persona);
                cmd.Parameters.AddWithValue("@Direccion", Direccion_Persona);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void BuscarID_Persona()
        {

            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_ID_PERSONA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ID = dr.GetInt32(0);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
        }

        private void Datos_Persona(string Buscar_Ced)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_PERSONA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Cedula", Buscar_Ced);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ID = rd.GetInt32(0);
                    Nombre_Persona = rd.GetString(1);
                    Apellido_Persona = rd.GetString(2);
                    T_Identi_Persona = rd.GetString(3);
                    Identificacion_Persona = rd.GetString(4);
                    Celular_Persona = rd.GetString(5);
                    Direccion_Persona = rd.GetString(6);
                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
 
        }

        private void Modificar_Persona()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PERSONA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_P", ID);
                cmd.Parameters.AddWithValue("@Nom", Nombre_Persona);
                cmd.Parameters.AddWithValue("@Apellido", Apellido_Persona);
                cmd.Parameters.AddWithValue("@Tipo_Identificacion", T_Identi_Persona);
                cmd.Parameters.AddWithValue("@Identificacion", Identificacion_Persona);
                cmd.Parameters.AddWithValue("@Celular", Celular_Persona);
                cmd.Parameters.AddWithValue("@Direccion", Direccion_Persona);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
        }
    }

}
