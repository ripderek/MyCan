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
    class csListar_IVA_DATAGRID
    {
        cConexion conexion = new cConexion(); //CONEXION
        private int iva_id;
        private string codigo;
        private string descripcion;
        private decimal iva_porcentaje;

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
        public string Descripcion_
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public decimal Iva_porcentaje_
        {
            get { return iva_porcentaje; }
            set { iva_porcentaje = value; }
        }
        public List<csListar_IVA_DATAGRID> listarIVA()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("LISTAR_IVA_DATAGRID_IVA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<csListar_IVA_DATAGRID> lstEmple = new List<csListar_IVA_DATAGRID>();
            csListar_IVA_DATAGRID objemple;
            while (dr.Read())
            {
                objemple = new csListar_IVA_DATAGRID();
                objemple.Iva_id_ = dr.GetInt32(0);
                objemple.Codigo_ = dr.GetString(1);
                objemple.Descripcion_ = dr.GetString(2);
                objemple.Iva_porcentaje_ = decimal.Parse(dr.GetSqlSingle(3).ToString());
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
