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
    class LISTAR_RECETAS_FRM_OPCION
    {
        cConexion conexion = new cConexion();
        private int receta_id;
        private string numero_receta;
     
        public int Receta_id_
        {
            get { return receta_id; }
            set { receta_id = value; }
        }
        public string Numero_receta_
        {
            get { return numero_receta; }
            set { numero_receta = value; }
        }
        public List<LISTAR_RECETAS_FRM_OPCION> listarRECETAS()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_RECETAS_ID", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<LISTAR_RECETAS_FRM_OPCION> lstEmple = new List<LISTAR_RECETAS_FRM_OPCION>();
            LISTAR_RECETAS_FRM_OPCION objemple;
            while (dr.Read())
            {
                objemple = new LISTAR_RECETAS_FRM_OPCION();
                objemple.Receta_id_ = dr.GetInt32(0);
                objemple.Numero_receta_ = dr.GetString(1);
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
