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
    class cs_Novedades_Para_el_dia
    {
        cConexion conexion = new cConexion();
        private int numero_citas;
        private int productos_stock;
        private int numero_ofertas;

        public int Numero_citas_
        {
            get { return numero_citas; }
            set { numero_citas = value; }
        }
        public int Productos_stock
        {
            get { return productos_stock; }
            set { productos_stock = value; }
        }
        public int Numero_ofertas
        {
            get { return numero_ofertas; }
            set { numero_ofertas = value; }
        }
        //CONSTRUCTOR 
        public cs_Novedades_Para_el_dia()
        {
            NUMERO_CITAS_PROGRAMADAS();
            PRODUCTOS_SIN_STOCK();
            PRODUCTOS_EN_OFERTAS();
        }

      
        private void NUMERO_CITAS_PROGRAMADAS()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NUMERO_DE_CITAS_PARA_EL_DIA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Numero_citas_ = rd.GetInt32(0);
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
        private void PRODUCTOS_SIN_STOCK()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PRODUCTOS_CON_STOCK_0", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Productos_stock = rd.GetInt32(0);
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
        private void PRODUCTOS_EN_OFERTAS()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_NUMERO_PRODUCTO_EN_OFERTAS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Numero_ofertas = rd.GetInt32(0);
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
