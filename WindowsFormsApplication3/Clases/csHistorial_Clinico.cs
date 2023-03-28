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
    class csHistorial_Clinico
    {
        cConexion conexion = new cConexion();
        public int Verfi = 0;
        private int Paciente_ID;
        private DateTime Fecha_Creacion = DateTime.UtcNow.Date;
        private string Desparacitacion;
        private string Problemas_Previos;
        private string Alergias_Encontradas;
        private string Habitad;
        private string Alimentacion;
        private string Procedencia;
        private string Cirugias;
        private string EstadO_Reproductivo;
        private string Fecha_Ultimo_Parto;
        private string Temperatura;
        private string Peso;
        private string Motivo_Consulta;
        private string Diagnostico;
        private string Tratamiento;
        private DateTime Fecha_Consulta;
        private int detalle_historial_id;

        public int Detalle_historial_id_
        {
            get { return detalle_historial_id; }
            set { detalle_historial_id = value; }
        }
        //PROPIEDADES DE LA TABLA MEDICAMENTOS DEL DETALLE CLINICO
        private int medicamento_id;
        private int cantidad_medicamento;     
        //GETS Y SETS
        public int Paciente_ID_
        {
            get { return Paciente_ID; }
            set { Paciente_ID = value; }
        }
       
      
        public string Desparacitacion_
        {
            get { return Desparacitacion; }
            set { Desparacitacion = value; }
        }
        public string Problemas_Previos_
        {
            get { return Problemas_Previos; }
            set { Problemas_Previos = value; }
        }
        public string Alergias_Encontradas_
        {
            get { return Alergias_Encontradas; }
            set { Alergias_Encontradas = value; }
        }
        public string Habitad_Animal_
        {
            get { return Habitad; }
            set { Habitad = value; }
        }
        public string Alimentacion_
        {
            get { return Alimentacion; }
            set { Alimentacion = value; }
        }
        public string Procedencia_
        {
            get { return Procedencia; }
            set { Procedencia = value; }
        }
        public string Cirugias_
        {
            get { return Cirugias; }
            set { Cirugias = value; }
        }
        public string EstadO_Reproductivo_
        {
            get { return EstadO_Reproductivo; }
            set { EstadO_Reproductivo = value; }
        }
        public string Fecha_Ultimo_Parto_
        {
            get { return Fecha_Ultimo_Parto; }
            set { Fecha_Ultimo_Parto = value; }
        }
        public string Temperatura_
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }
        public string Peso_Animal
        {
            get { return Peso; }
            set { Peso = value; }
        }
        public string Motivo_Consulta_
        {
            get { return Motivo_Consulta; }
            set { Motivo_Consulta = value; }
        }

        public string Diagnostico_
        {
            get { return Diagnostico; }
            set { Diagnostico = value; }
        }
        public string Tratamiento_
        {
            get { return Tratamiento; }
            set { Tratamiento = value; }
        }
        public DateTime Fecha_Consulta_
        {
            get { return Fecha_Consulta; }
            set { Fecha_Consulta = value; }
        }
        public int Medicamento_id_
        {
            get { return medicamento_id; }
            set { medicamento_id = value; }
        }
        public int Cantidad_medicamento_
        {
            get { return cantidad_medicamento; }
            set { cantidad_medicamento = value; }
        }
        //SOBRECARGA PARA REGISTAR UN HISTORIAL MEDICO
        public csHistorial_Clinico(int iD_pac_, string despara_,string problem_pre_,
                string alergias_, string Habitad_, string alimentacion_, string procedencia_, string ciru_,
                string estado_repro_, string fech_parto_, string temperatura, string Peso_A,
                string motivo_, string diag_, string trat_, DateTime consulta_fec_)
        {
            Paciente_ID_ = iD_pac_; 
            Desparacitacion_ = despara_; 
            Problemas_Previos_ = problem_pre_;
            Alergias_Encontradas_ = alergias_; 
            Habitad_Animal_ = Habitad_; 
            Alimentacion_ = alimentacion_; 
            Procedencia_ = procedencia_; 
            Cirugias_ = ciru_;
            EstadO_Reproductivo_ = estado_repro_; 
            Fecha_Ultimo_Parto_ = fech_parto_; 
            Temperatura_ = temperatura; 
            Peso_Animal = Peso_A;
            Motivo_Consulta_ = motivo_;
            Diagnostico_ = diag_;
            Tratamiento_ = trat_; 
            Fecha_Consulta_ = consulta_fec_;

            REGISTRAR_HISTORIAL_CLINICO();
        }

        //SOBRECARGA PARA INGRESAR LOS MEDICAMENTOS QUE SE USARON 
        public csHistorial_Clinico(int medica, int canti)
        {
            Medicamento_id_ = medica; Cantidad_medicamento_ = canti;
            REGISTRAR_MEDICAMENTOS_USADOS();
        }
        //SOBRECARGA BACIA PARA OBTENER EL ULTIMO DETALLE_ID
        public csHistorial_Clinico()
        {
            ULTIMO_DETALLE_ID();
        }
        //procedimiento para registrar un historial clinico
        private void REGISTRAR_HISTORIAL_CLINICO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_HISTORIA_CLINICA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Paciente", Paciente_ID_);
                cmd.Parameters.AddWithValue("@Fecha_Creacion", Fecha_Creacion);
                cmd.Parameters.AddWithValue("@Desparacitacion", Desparacitacion_);
                cmd.Parameters.AddWithValue("@Problemas_Previos", Problemas_Previos_);
                cmd.Parameters.AddWithValue("@Alergias_Encontradas", Alergias_Encontradas_);
                cmd.Parameters.AddWithValue("@Habitad", Habitad_Animal_);
                cmd.Parameters.AddWithValue("@Alimentacion", Alimentacion_);
                cmd.Parameters.AddWithValue("@Procedencia", Procedencia_);
                cmd.Parameters.AddWithValue("@Cirugias", Cirugias_);
                cmd.Parameters.AddWithValue("@Estado_Reproductivo", EstadO_Reproductivo_);
                cmd.Parameters.AddWithValue("@Fecha_ultimo_parto", Fecha_Ultimo_Parto_);
                cmd.Parameters.AddWithValue("@Temperatura", Temperatura_);
                cmd.Parameters.AddWithValue("@Peso", Peso_Animal);
                cmd.Parameters.AddWithValue("@Motivo_Consulta", Motivo_Consulta_);
                cmd.Parameters.AddWithValue("@Diagnostico", Diagnostico_);
                cmd.Parameters.AddWithValue("@Tratamiento", Tratamiento_);
                cmd.Parameters.AddWithValue("@Fecha_Consulta", Fecha_Consulta_);
                Verfi = 1;
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                MessageBox.Show("TRUE");
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void REGISTRAR_MEDICAMENTOS_USADOS()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MEDICAMENTOS_DETALLE_CLINICO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Medicamento_id", Medicamento_id_);
                cmd.Parameters.AddWithValue("@Cantidad_Usada", Cantidad_medicamento_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                MessageBox.Show("TRUE");
                Verfi = 1;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ULTIMO_DETALLE_ID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ULTIMO_DETALLE_CLINICO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Detalle_historial_id_ = rd.GetInt32(0);
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
