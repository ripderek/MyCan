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
    class csIVA
    {
        cConexion conexion = new cConexion();
        private int iva_id;
        private string codigo;
        private string descripcion;
        private decimal iva_porcentaje;
        public int Verficiar_noti;
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
        //CONSTRUTOR PARA CREAR EL IVA 
        public csIVA(string cod, string descrip, decimal porcentaj)
        {
            Codigo_ = cod; Descripcion_ = descrip; Iva_porcentaje_ = porcentaj;
            CREAR_IVA();
        }
        //SOBRECARGA PARA EDITAR EL IVA 
        public csIVA(int id_i, string cod, string descrip, decimal porcentaj)
        {
            Iva_id_ = id_i; Codigo_ = cod; Descripcion_ = descrip; Iva_porcentaje_ = porcentaj;
            EDITAR_IVA();
        }
        public csIVA(int id_i)
        {
            Iva_id_ = id_i;
            ELIMINAR_IVA();
        }

        private void CREAR_IVA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INGRESAR_NUEVO_IVA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@CodigoIva", Codigo_);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion_);
                cmd.Parameters.AddWithValue("@Porcentaje", Iva_porcentaje_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficiar_noti = 1;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficiar_noti = 0;
            }
        }
        private void EDITAR_IVA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("MODIFICAR_IVA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Iva_id", Iva_id_);
                cmd.Parameters.AddWithValue("@CodigoIva", Codigo_);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion_);
                cmd.Parameters.AddWithValue("@Porcentaje", Iva_porcentaje_);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficiar_noti = 1;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficiar_noti = 0;
            }
        }
        private void ELIMINAR_IVA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_IVA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Iva_id", Iva_id_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficiar_noti = 1;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficiar_noti = 0;
            }
        }
    }
}
