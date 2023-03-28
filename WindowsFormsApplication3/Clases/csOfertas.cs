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
    class csOfertas
    {
        cConexion conexion = new cConexion();
        private int product_id;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private decimal descuento;
        private int estado;
        private int cantidad;
        public int  Verficador_notifiacion;
        private int Oferta_ID;

        public int Oferta_ID_
        {
            get { return Oferta_ID; }
            set { Oferta_ID = value; }
        }
        public int Product_id_
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public DateTime Fecha_inicio_
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        public DateTime Fecha_fin_
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public decimal Descuento_
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int Estado_
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Cantidad_
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        //CONSTRUCTOR PARA CREAR LA OFERTA 
        public csOfertas(int produ, DateTime fechaI, DateTime FechaF, decimal discount, int cant)
        {
            Product_id_ = produ; Fecha_inicio_ = fechaI; Fecha_fin_ = FechaF; Descuento_ = discount; Cantidad_ = cant;
            VERIFICAR_REPETIR_OFERTA();
            if (Verficador_notifiacion != 1)
                CREAR_OFERTA();
            else
            { MessageBox.Show("ESTA OFERTA SE ENCUENTRA REGISTRADA"); Verficador_notifiacion = 0; }
            
        }
        //SOBRCARGA PARA EDITAR EL ESTADO DE UNA OFERTA 
        public csOfertas(int ofer_id, int esta)
        {
            Oferta_ID_ = ofer_id;
            if (esta == 1)
                Estado_ = 0;
            else
                Estado_ = 1;
            CAMBIAR_ESTADO_OFERTA();
        }
        //SOBRECARGAR PARA EDITAR UNA OFERTA
        public csOfertas(int ofer, DateTime fec_i, DateTime fec_f, decimal desc, int canti,bool x)
        {
            Oferta_ID_ = ofer; Fecha_inicio_ = fec_i; Fecha_fin_ = fec_f; Descuento_ = desc; Cantidad_ = canti;
            EDITAR_OFERTA();
        }

        private void CREAR_OFERTA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_CREAR_OFERTAS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Producto_ID", Product_id_);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", Fecha_inicio_);
                cmd.Parameters.AddWithValue("@Fecha_Fin", Fecha_fin_);
                cmd.Parameters.AddWithValue("@Descuento", Descuento_);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("PRODUCTO YA REGISTRADO", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            } 
        }
        private void CAMBIAR_ESTADO_OFERTA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_CAMBIAR_ESTADO_OFERTA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Oferta", Oferta_ID_);
                cmd.Parameters.AddWithValue("@Estadon", Estado_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("PRODUCTO YA REGISTRADO", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            } 
        }
        private void EDITAR_OFERTA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_EDITAR_OFERTA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Oferta", Oferta_ID_);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", Fecha_inicio_);
                cmd.Parameters.AddWithValue("@Fecha_Fin", Fecha_fin_);
                cmd.Parameters.AddWithValue("@Descuento", Descuento_);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("PRODUCTO YA REGISTRADO", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            } 
        }
        private void VERIFICAR_REPETIR_OFERTA()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_VERIFICAR_REPETICION_OFERTA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@product", Product_id_);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", Fecha_inicio_);
                cmd.Parameters.AddWithValue("@Fecha_Fin", Fecha_fin_);
                cmd.Parameters.AddWithValue("@Descuento", Descuento_);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Verficador_notifiacion = 1;
                }
                else Verficador_notifiacion = 0;
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
