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
    class ListarIva_recepcion
    {
        cConexion conexion = new cConexion();
        private int iva_id;
        private string codigo;
        private string porcentaje;
        public string palabra_clave;

        public int Iva_id_
        {
            get { return iva_id; }
            set { iva_id = value; }
        }
        public string Codigo_
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Porcentaje_
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }
        public List<ListarIva_recepcion> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_IVA_PALABRA_CLAVE", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@Numero_IVA", palabra_clave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<ListarIva_recepcion> lstEspe = new List<ListarIva_recepcion>();
            ListarIva_recepcion objeraza;
            while (dr.Read())
            {
                objeraza = new ListarIva_recepcion();
                objeraza.Iva_id_ = dr.GetInt32(0);
                objeraza.Codigo_ = dr.GetString(1);
               // objeraza.Porcentaje_ = dr.GetDouble(2).ToString("N2");//.Replace('.', ',');
                objeraza.Porcentaje_ = dr.GetSqlSingle(2).ToString();

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
