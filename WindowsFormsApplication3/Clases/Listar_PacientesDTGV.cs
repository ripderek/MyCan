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
    class Listar_PacientesDTGV
    {
        cConexion conexion = new cConexion();
        private int id_p;
        private string nombre_paciente;
        private string especie;
        private string raza;
        private string sexo;
        private string color;
        private string apellidos;
        private string identificacion;

        public int ID_PACIENTE_
        {
            get { return id_p; }
            set { id_p = value; }
        }
        public string NOMBRE_PACIENTE_
        {
            get { return nombre_paciente; }
            set { nombre_paciente = value; }
        }
        public string ESPECIE_ANIMAL_
        {
            get { return especie; }
            set { especie = value; }
        }
        public string RAZA_ANIMAL_
        {
            get { return raza; }
            set { raza = value; }
        }
        public string SEXO_PACIENTE_
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string COLOR_PACIENTE_
        {
            get { return color; }
            set { color = value; }
        }
        public string APELLIDOS_CLIENTE
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string IDENTIFICACION_CLIENTE_
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public List<Listar_PacientesDTGV> listarPAC()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PACIENTES_DTGV", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<Listar_PacientesDTGV> lstPAC = new List<Listar_PacientesDTGV>();
            Listar_PacientesDTGV objpac;
            while (dr.Read())
            {
                objpac = new Listar_PacientesDTGV();
                objpac.ID_PACIENTE_ = dr.GetInt32(0);
                objpac.NOMBRE_PACIENTE_ = dr.GetString(1);
                objpac.ESPECIE_ANIMAL_ = dr.GetString(2);
                objpac.RAZA_ANIMAL_ = dr.GetString(3);
                objpac.SEXO_PACIENTE_ = dr.GetString(4);
                objpac.COLOR_PACIENTE_ = dr.GetString(5);
                objpac.APELLIDOS_CLIENTE = dr.GetString(6);
                objpac.IDENTIFICACION_CLIENTE_ = dr.GetString(7);
                lstPAC.Add(objpac);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstPAC;
        }
    }
}
