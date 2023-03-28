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
    class csNUMERO_FACTURAS
    {
        cConexion conexion = new cConexion();
        private int factura_ID;

       
        private string numero_factura;
        public int ID
        {
            get { return factura_ID; }
            set { factura_ID = value; }
        }
        public string Numero_Factura_
        {
            get { return numero_factura; }
            set { numero_factura = value; }
        }
      


        public List<csNUMERO_FACTURAS> listarIVA()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_NUMERO_FACTURAS_RE", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<csNUMERO_FACTURAS> lstEmple = new List<csNUMERO_FACTURAS>();
            csNUMERO_FACTURAS objemple;
            while (dr.Read())
            {
                objemple = new csNUMERO_FACTURAS();
                objemple.ID = dr.GetInt32(0);
                objemple.Numero_Factura_ = dr.GetString(1);

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
