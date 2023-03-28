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
    class Listar_Medicamentos_Historial_Clinico
    {
        cConexion conexion = new cConexion();
        public string Palabra_Clave;
        private int medicamento_id;
        private string nombre_medicamento;
        private string categoria;

        public int Medicamento_id
        {
            get { return medicamento_id; }
            set { medicamento_id = value; }
        }
        public string Nombre_medicamento
        {
            get { return nombre_medicamento; }
            set { nombre_medicamento = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public List<Listar_Medicamentos_Historial_Clinico> listarpro()
        {

            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_MEDICAMENTOS_PARA_F_C", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@Palabra_clave", Palabra_Clave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<Listar_Medicamentos_Historial_Clinico> lstEspe = new List<Listar_Medicamentos_Historial_Clinico>();
            Listar_Medicamentos_Historial_Clinico objeraza;
            while (dr.Read())
            {
                objeraza = new Listar_Medicamentos_Historial_Clinico();
                //(objeraza.ProveedorID_ = dr.GetInt32(0);
                objeraza.Medicamento_id = dr.GetInt32(0);
                objeraza.Nombre_medicamento = dr.GetString(1);
                objeraza.Categoria = dr.GetString(2);
                lstEspe.Add(objeraza);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEspe;
        }
    }
}
