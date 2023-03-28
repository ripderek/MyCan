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
    class csListarDetalleCombo
    {
        cConexion conexion = new cConexion();

        //PROPIEDADES DE LA CLASE 
        private int iDcombo;
        private int cantidadproducto;
        private string nombrecombo;
        private string nombreproducto;
        private int cantidaduniro;

        //GETS Y SETS 

        public int IDcombo
        {
            get { return iDcombo; }
            set { iDcombo = value; }
        }

        public string Nombrecombo
        {
            get { return nombrecombo; }
            set { nombrecombo = value; }
        }

        public string Nombreproducto
        {
            get { return nombreproducto; }
            set { nombreproducto = value; }
        }

        public int Cantidaduniro
        {
            get { return cantidaduniro; }
            set { cantidaduniro = value; }
        }
     
        public int Cantidadproducto
        {
            get { return cantidadproducto; }
            set { cantidadproducto = value; }
        }


        public DataSet CombosCombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da_Combos = new SqlDataAdapter();
            da_Combos.SelectCommand = new SqlCommand("SP_COMBOS_COMBOBOX", conexion.con);
            da_Combos.SelectCommand.CommandType = CommandType.Text;
            da_Combos.Fill(ds, "Producto_ID");
            return ds;
        }


        public List<csListarDetalleCombo> listarDetalleCombo()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_LISTAR_DETALLES_COMBO", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion()

            conexion.AbrirConexion();

            cmd.Parameters.AddWithValue("@IDCombo", IDcombo);

            cmd.ExecuteNonQuery();

            dr = cmd.ExecuteReader();

            List<csListarDetalleCombo> lstDetacombo = new List<csListarDetalleCombo>();
            csListarDetalleCombo objDCombo;
            while (dr.Read())
            {
                objDCombo = new csListarDetalleCombo();
                objDCombo.IDcombo = dr.GetInt32(0);
                objDCombo.Nombrecombo = dr.GetString(1);
                objDCombo.Nombreproducto = dr.GetString(2);
                objDCombo.Cantidaduniro = dr.GetInt32(3);
                objDCombo.Cantidadproducto = dr.GetInt32(4);
                lstDetacombo.Add(objDCombo);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstDetacombo;
        }
    }
}
