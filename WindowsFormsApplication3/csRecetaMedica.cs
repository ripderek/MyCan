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
    class csRecetaMedica
    {
        public int verficar = 0;
        cConexion conexion = new cConexion();
        //PROPIEDADES DE LA RECETA MEDICA 
        private int paciente_id;      
        private DateTime Fecha = DateTime.UtcNow.Date;
        private int doctor_id;
        private int n_receta;
        //PROPIEDADTES DEL DETALLE DE LA RECETA MEDICA
        private int medicamento_id;
        private string dosis;
        private string indicacion;    
        /////////GETS SETS/////
        public int Paciente_id_
        {
            get { return paciente_id; }
            set { paciente_id = value; }
        }
        public int Doctor_id_
        {
            get { return doctor_id; }
            set { doctor_id = value; }
        }
        public int Medicamento_id_
        {
            get { return medicamento_id; }
            set { medicamento_id = value; }
        }
        public string Dosis_
        {
            get { return dosis; }
            set { dosis = value; }
        }
        public string Indicacion_
        {
            get { return indicacion; }
            set { indicacion = value; }
        }
        public int N_receta_
        {
            get { return n_receta; }
            set { n_receta = value; }
        }
        //CONSTRUCTOR PARA CREAR LA RECETA
        public csRecetaMedica(int pacien, int doc)
        {
            Paciente_id_ = pacien; Doctor_id_ = doc;
            CREAR_RECETA();
        }
       
        
        //SOBRECARGA DEL CONSTRUCTOR PARA CREAR EL DETALLE DE LA RECETA MEDICA
        public csRecetaMedica(int medica, string dos, string inid)
        {
            Medicamento_id_ = medica; Dosis_ = dos; Indicacion_ = inid;
            DETALLE_RECETA_();
        }
        public csRecetaMedica()
        {
            ULTIMA_RECETA();
        }
        private void CREAR_RECETA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_CREAR_RECETA_MEDICA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Paciente_ID", Paciente_id_);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Doctor", Doctor_id_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                verficar = 1;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DETALLE_RECETA_()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_CREAR_DETALLE_RECETA_MEDICA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Medicamento", Medicamento_id_);
                cmd.Parameters.AddWithValue("@Dosis", Dosis_);
                cmd.Parameters.AddWithValue("@Indicacion", Indicacion_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                verficar = 1;

            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ULTIMA_RECETA()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ULTIMO_NUMERO_RECETA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    N_receta_ = rd.GetInt32(0);
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
    }
}
