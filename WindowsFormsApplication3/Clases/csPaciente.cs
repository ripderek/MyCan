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
    class csPaciente:csClientes
    {
        cConexion conexion = new cConexion();
        public MemoryStream ms;
        private int id_cliente;
        private int id_especie;
        private int id_raza;
        private string nombre_pac;
        private string sex;
        private string col;
        private DateTime fecha_nac;
        private byte[] foto;
        private string nombre_especie;
        private string tipo_raza;

        public string TIPO_ESPECIE_
        {
            get { return nombre_especie; }
            set { nombre_especie = value; }
        }
        public string TIPO_RAZA_
        {
            get { return tipo_raza; }
            set { tipo_raza = value; }
        }
        public int ID_Cliente_
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public int ID_Especie_
        {
            get { return id_especie; }
            set {id_especie=value;}
        }
        public int ID_Raza_
        {
            get { return id_raza; }
            set { id_raza = value; }
        }
        public string Nombre_Paciente_
        {
            get { return nombre_pac; }
            set { nombre_pac = value; }
        }
        public string Sexo_Paciente_
        {
            get { return sex; }
            set {sex=value;}
        }
        public string Color_Paciente_
        {
            get { return col; }
            set { col = value; }
        }
        public DateTime Fecha_Nacimiento_Paciente
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }

        //Primer constructor 
        public csPaciente(int ID_CLIEN, int ID_ESPE, int ID_RA, string NOM, string SE, string COLO4, DateTime NAC, byte[] pic)
        {
            ID_Cliente_ = ID_CLIEN; ID_Especie_ = ID_ESPE; ID_Raza_ = ID_RA; Nombre_Paciente_ = NOM; Sexo_Paciente_ = SE; Color_Paciente_ = COLO4;
            Fecha_Nacimiento_Paciente = NAC; foto = pic;
            InsertarPaciente();
        }
        //Segundo Constructor para modificar los datos del paciente 
        public csPaciente(int id_PACX, int ID_CLIEN, int ID_ESPE, int ID_RA, string NOM, string SE, string COLO4, DateTime NAC, byte[] pic)
        {
            ID_Cliente_ = ID_CLIEN; ID_Especie_ = ID_ESPE; ID_Raza_ = ID_RA; Nombre_Paciente_ = NOM; Sexo_Paciente_ = SE; Color_Paciente_ = COLO4;
            Fecha_Nacimiento_Paciente = NAC; foto = pic;
            Modificar_Paciente(id_PACX);
        }

        //Tercer Constructor para ver los datos del paciente segun id 
        public csPaciente(int id_pa)
        {

            Datos_Paciente(id_pa);
            VerImagen(id_pa);
        }

        private void InsertarPaciente()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INGRESAR_PACIENTE", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_c", ID_Cliente_);
                cmd.Parameters.AddWithValue("@id_es", ID_Especie_);
                cmd.Parameters.AddWithValue("@id_raz", ID_Raza_);
                cmd.Parameters.AddWithValue("@nomnre", Nombre_Paciente_);
                cmd.Parameters.AddWithValue("@sexo", Sexo_Paciente_);
                cmd.Parameters.AddWithValue("@color", Color_Paciente_);
                cmd.Parameters.AddWithValue("@fecha_nac", Fecha_Nacimiento_Paciente);
                cmd.Parameters.AddWithValue("@foto", foto);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Datos_Paciente(int id_pac)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_DATOS_PACIENTES", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_pac", id_pac);
               //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Identificacion_Persona = rd.GetString(0);
                    Nombre_Persona = rd.GetString(1);
                    Nombre_Paciente_ = rd.GetString(2);
                    TIPO_ESPECIE_ = rd.GetString(3);
                    TIPO_RAZA_ = rd.GetString(4);
                    Sexo_Paciente_ = rd.GetString(5);
                    Color_Paciente_ = rd.GetString(6);
                    Fecha_Nacimiento_Paciente = rd.GetDateTime(7);                
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
        private void Modificar_Paciente(int id_pac)
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PACIENTE", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_pac",id_pac);
                cmd.Parameters.AddWithValue("@id_c", ID_Cliente_);
                cmd.Parameters.AddWithValue("@id_es", ID_Especie_);
                cmd.Parameters.AddWithValue("@id_raz", ID_Raza_);
                cmd.Parameters.AddWithValue("@nomnre", Nombre_Paciente_);
                cmd.Parameters.AddWithValue("@sexo", Sexo_Paciente_);
                cmd.Parameters.AddWithValue("@color", Color_Paciente_);
                cmd.Parameters.AddWithValue("@fecha_nac", Fecha_Nacimiento_Paciente);
                cmd.Parameters.AddWithValue("@foto", foto);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();


            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }
        private void VerImagen(int id_p)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_PACIENTE_FOTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_PAC", id_p);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("Foto");
                dp.Fill(ds, "Foto");
                byte[] Datos = new byte[0];
                DataRow DR = ds.Tables["Foto"].Rows[0];
                Datos = (byte[])DR["Foto"];
                ms = new MemoryStream(Datos);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "!!Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //hola.Image = System.Drawing.Bitmap.FromStream(ms);
        }


    }
}
