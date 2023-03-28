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
    class csCitas
    {
        cConexion conexion = new cConexion();
        //PROPIEDADES DE LAS CITAS
        private string Hora_destina; 
        private int ID_Cita;
        private int ID_Cliente;
        private int ID_Empleado_agenda;
        private int ID_Empleado_medico;
        private DateTime fecha_creacion= DateTime.UtcNow.Date;
        private string Descripcion;
        private int Tiempo_Duracion_Min;  

        //PROPIEDADES DEL DETALLE DE LA CITA 
        private int ID_Detalle_Cita;
        private DateTime Fecha_Destinada;
        private string Hora_Llegada;
        private string Estado_Cita;
        private DateTime Fecha_Pospuesta;

        //GETS Y SETS
        public int ID_Cita1_
        {
            get { return ID_Cita; }
            set { ID_Cita = value; }
        }
        public int ID_Cliente1_
        {
            get { return ID_Cliente; }
            set { ID_Cliente = value; }
        }
        public int ID_Empleado_agenda1_
        {
            get { return ID_Empleado_agenda; }
            set { ID_Empleado_agenda = value; }
        }
        public int ID_Empleado_medico1_
        {
            get { return ID_Empleado_medico; }
            set { ID_Empleado_medico = value; }
        }
      
        public string Descripcion1_
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public int Tiempo_Duracion_Min1_
        {
            get { return Tiempo_Duracion_Min; }
            set { Tiempo_Duracion_Min = value; }
        }
        public int ID_Detalle_Cita1_
        {
            get { return ID_Detalle_Cita; }
            set { ID_Detalle_Cita = value; }
        }
        public DateTime Fecha_Destinada1_
        {
            get { return Fecha_Destinada; }
            set { Fecha_Destinada = value; }
        }
        public string Hora_Llegada1_
        {
            get { return Hora_Llegada; }
            set { Hora_Llegada = value; }
        }
        public string Estado_Cita1_
        {
            get { return Estado_Cita; }
            set { Estado_Cita = value; }
        }
        public DateTime Fecha_Pospuesta1_
        {
            get { return Fecha_Pospuesta; }
            set { Fecha_Pospuesta = value; }
        }

        public string Hora_destina1
        {
            get { return Hora_destina; }
            set { Hora_destina = value; }
        }

        public DateTime Fecha_creacion1_
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }
        //CONTRUCTOR PARA REGISTAR UNA CITA
        public csCitas(int id_cliente_, int id_empleado_agen_, int id_empleado_med_,  string descrip, int duracion,
                        DateTime fecha_destinada_,string hora_llegada_, string Estado, string hora_d)
        {
            ID_Cliente1_ = id_cliente_; ID_Empleado_agenda1_ = id_empleado_agen_; ID_Empleado_medico1_ = id_empleado_med_;  Descripcion1_ = descrip; Tiempo_Duracion_Min1_ = duracion;
            Agendar_cita();
            Ultima_cita_agendada();
            Fecha_Destinada1_ = fecha_destinada_; Hora_Llegada1_ = hora_llegada_; Estado_Cita1_ = Estado; Hora_destina1 = hora_d;
            Agendar_detalle_cita();
        }
        public csCitas(int id_d_c_ ,  string ho_leg) //CITA TERMINADA 
        {
            ID_Detalle_Cita1_ = id_d_c_;  Hora_Llegada1_ = ho_leg;
            Cita_Terminada();         
        }
        public csCitas(int id_d_c_, DateTime fecha_pos_, string hora_d_) //cita pospuesta
        {
            ID_Detalle_Cita1_ = id_d_c_; Fecha_Pospuesta1_ = fecha_pos_; Hora_destina1 = hora_d_;
            Cita_Pospuesta();
        }
        public csCitas(int id_d_c_) //NO SE PRESENTÓ 
        {
            ID_Detalle_Cita1_ = id_d_c_;
            Cita_No_Se_Presentó();
        }
        public csCitas() //SOBRECARGA VACIA PARA EL ENVENTO NOTIFICACION
        {
 
        }
        private void Agendar_cita()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_AGENDAR_CITA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Cliente", ID_Cliente1_);
                cmd.Parameters.AddWithValue("@ID_Empleado_Agen", ID_Empleado_agenda1_);
                cmd.Parameters.AddWithValue("@ID_Empleado_Med", ID_Empleado_medico1_);
                cmd.Parameters.AddWithValue("@Fecha_creacion", Fecha_creacion1_);
                cmd.Parameters.AddWithValue("@descripcion", Descripcion1_);
                cmd.Parameters.AddWithValue("@Tiempo_Duracion", Tiempo_Duracion_Min1_);
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
        private void Ultima_cita_agendada()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ULTIMA_CITA_AGENDADA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ID_Cita1_ = rd.GetInt32(0);
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
        private void Agendar_detalle_cita()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_AGENDAR_DETALLE_CITA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_CITA", ID_Cita1_);
                cmd.Parameters.AddWithValue("@Fecha_destinada", Fecha_Destinada1_);
                cmd.Parameters.AddWithValue("@Hora_llegada", Hora_Llegada1_);
                cmd.Parameters.AddWithValue("@Estado", Estado_Cita1_);
                cmd.Parameters.AddWithValue("@Hora_Destinada_ ", Hora_destina1);
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
        private void Cita_Terminada()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_CITA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Detalle_CIta_", ID_Detalle_Cita1_);
                cmd.Parameters.AddWithValue("@Hora_Llegada", Hora_Llegada1_);
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
        private void Cita_Pospuesta()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_POSPONER_CITA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Detalle_CIta_", ID_Detalle_Cita1_);
                cmd.Parameters.AddWithValue("@Fecha_Pospuesta", Fecha_Pospuesta1_);
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
        private void Cita_No_Se_Presentó()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_NO_SE_PRESENTO_CITA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Detalle_CIta_", ID_Detalle_Cita1_);
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

        public void Cita_Notificacion(string hora, UIDC.UI_Notification noti)
        {
            try
            {
              
                SqlCommand cmd = new SqlCommand("SP_NOTIFICACION_CITAS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Fecha", Fecha_creacion1_);
                cmd.Parameters.AddWithValue("@Hora", hora);
                DateTime fec = Fecha_creacion1_;
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                     noti.EnabledNoti = true;                   
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
        public void Cita_En_Curso(string ho)
        {           
                try
                {

                    //SqlCommand->Ejecutar una sentencia SQL
                    SqlCommand cmd = new SqlCommand("SP_NOTIFICACION_CITAS_AC", conexion.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Abrir conexion
                    conexion.abrirCerrarConexion();
                    //Asignar parámetros
                    cmd.Parameters.AddWithValue("@Fecha", Fecha_creacion1_);
                    cmd.Parameters.AddWithValue("@Hora", ho);
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

    }
}
