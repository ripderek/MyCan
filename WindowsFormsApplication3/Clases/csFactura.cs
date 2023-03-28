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
    class csFactura
    {
        cConexion conexion = new cConexion(); //CONEXION
        public int ID_Ultima_Factura;
        public int Verificar;
        //PROPIEDADES DE LA FACTURA 
        private int empleado_id;
        private int cliente_id;
        private DateTime Fecha_Fact = DateTime.UtcNow.Date;
        private decimal descuento;
        private int Codigo_Iva;


        private int IDProduc;


        public int IDProduc_
        {
            get { return IDProduc; }
            set { IDProduc = value; }
        }
       
        //PROPIERDADTES DEL DETALLE DE LA FACTURA 
        private int producto_servicio_id;
        private int cantidad=70;
        private decimal descuento_pro;
        //GETS Y SETS 
        public int Empleado_id_
        {
            get { return empleado_id; }
            set { empleado_id = value; }
        }
        public int Cliente_id_
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }
        public decimal Descuento_
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int Producto_servicio_id
        {
            get { return producto_servicio_id; }
            set { producto_servicio_id = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal Descuento_pro
        {
            get { return descuento_pro; }
            set { descuento_pro = value; }
        }
        public int Codigo_IVA_
        {
            get { return Codigo_Iva; }
            set { Codigo_Iva = value; }
        }
        //CONSTRUCTOR PARA CREAR LA FACTURA 
        public csFactura(int id_empleado, int id_cliente, decimal discount_gen, int Iva_ID)  //ENVIAR EL IVA 
        {
            Empleado_id_ = id_empleado; Cliente_id_ = id_cliente; Descuento_ = discount_gen; Codigo_IVA_ = Iva_ID;
            REGISTAR_FACTURA();
        }
        //CONSTRUTOR PARA CREAR EL DETALLE DE LA FACTURA
        public csFactura(int idsp, int cant,decimal oferta ,  bool x = true) 
        {
            Producto_servicio_id = idsp; Cantidad = cant; Descuento_pro = oferta;
            REGISTRAR_DETALLE_FACTURA();
        }
        //SOBRECARGA PARA OBTENER EL ULTIMO ID DE FACTURA 
        public csFactura()
        {
            ULTIMO_ID_FACTURA();
        }

        private void REGISTAR_FACTURA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_FACTURA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Empleado_ID", Empleado_id_);
                cmd.Parameters.AddWithValue("@Cliente_ID", Cliente_id_);
                cmd.Parameters.AddWithValue("@Fecha_Factura",Fecha_Fact); //
                cmd.Parameters.AddWithValue("@Discount", Descuento_);//
                cmd.Parameters.AddWithValue("@Codigo_iva_id", Codigo_IVA_);//
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Verificar = 1;
                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
        }
        private void REGISTRAR_DETALLE_FACTURA()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_DETALLE_FACTURA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Producto_Servicio_ID", Producto_servicio_id);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@Oferta", Descuento_pro);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                Verificar = 1;
                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ULTIMO_ID_FACTURA()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ULTIMA_ID_FACTURA_IMPRIMIR", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ID_Ultima_Factura = rd.GetInt32(0);

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

        public void SACARELSTOCKPRO()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SACAR_STOCK_PRODUCTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();

                cmd.Parameters.AddWithValue("@ID_PRODUC", IDProduc_);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Cantidad = rd.GetInt32(0);
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
