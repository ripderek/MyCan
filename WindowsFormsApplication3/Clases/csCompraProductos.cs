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
    class csCompraProductos
    {
        cConexion conexion = new cConexion(); //CONEXION
        //PROPIEDADES
        public int Verificar;
        private int id_servicio_pro;
        private int empleado_id;
        private DateTime fecha_compra = DateTime.UtcNow.Date;
        private string nombre_producto;
        private double precio_venta;
        private int stock;
        private string cantidad_por_unidad;
        private int categoria;
        private int cantidad_detalle;
        private double precio_compra;
        private int proveedor_id;
        private int estado;
        private decimal descuento;
        private int cod_iva_id;
        private string Numero_Fact;
        private int comprabante_recepcion_id;

       
       
       
       
        //GET Y SET
        public int ID_Servicio_Pro_
        {
            get { return id_servicio_pro; }
            set { id_servicio_pro = value; }
        }
        public int Estado_
        {
            get { return estado; }
            set { estado = value; }
        }
        
        public int Empleado_id_
        {
            get { return empleado_id; }
            set { empleado_id = value; }
        }
        public string Nombre_producto_
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }
        public double Precio_venta_
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }
        public int Stock_
        {
            get { return stock; }
            set { stock = value; }
        }
        public string Cantidad_por_unidad_
        {
            get { return cantidad_por_unidad; }
            set { cantidad_por_unidad = value; }
        }
        public int Categoria_
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int Cantidad_detalle_
        {
            get { return cantidad_detalle; }
            set { cantidad_detalle = value; }
        }
        public double Precio_compra_
        {
            get { return precio_compra; }
            set { precio_compra = value; }
        }
        public int Proveedor_id_
        {
            get { return proveedor_id; }
            set { proveedor_id = value; }
        }
        public decimal Descuento_
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public int Cod_iva_id_
        {
            get { return cod_iva_id; }
            set { cod_iva_id = value; }
        }
        public string Numero_Fact_
        {
            get { return Numero_Fact; }
            set { Numero_Fact = value; }
        }
        public int Comprabante_recepcion_id
        {
            get { return comprabante_recepcion_id; }
            set { comprabante_recepcion_id = value; }
        }
        //CONSTRUCTOR PARA CREAR LA ORDEN DE COMPRA DE PRODUCTO
        public csCompraProductos(int id_empleado, decimal desc, int cod_iva, int proveedor_id, string fac)
        {
            Empleado_id_ = id_empleado; Descuento_ = desc; Cod_iva_id_ = cod_iva; Proveedor_id_ = proveedor_id; Numero_Fact_ = fac;
            ORDEN_COMPRA_PRODUCTO();
        }


        //CONSTRUCTOR PARA REGISTRAR EL DETALLE DE COMPRA
        public csCompraProductos(int stock, double precio_compra, int produc_id)
        {
            Stock_ = stock; Precio_compra_ = precio_compra; ID_Servicio_Pro_ = produc_id;
            DETALLE_COMPRA_PRODUCTO();
        }

        //CONSTRUCTOR PARA CREAR UN SERVICIO
        public csCompraProductos(string nombre_s, double precio_venta_S, string descrip, int categoria)
        {
            Nombre_producto_ = nombre_s; Precio_venta_ = precio_venta_S; Cantidad_por_unidad_ = descrip; Categoria_ = categoria;
            REGISTRAR_SERVICIO_();
        }


        //CONSTRUCTOR PARA MODIFICAR UN SERVICIO
        public csCompraProductos(int idservicio, string nombre_s, double precio_venta_S, string descrip, int categoria, int estado_s)
        {
            ID_Servicio_Pro_ = idservicio; Nombre_producto_ = nombre_s ; Precio_venta_ = precio_venta_S; 
            Cantidad_por_unidad_ = descrip; Categoria_ = categoria; Estado_ = estado_s;
            MODIFICAR_SERVICIO_();
        }


        //SOBRECARGA PARA ELIMINAR UN SERVICIO
        public csCompraProductos(int id_se, bool e = true)
        {
            ID_Servicio_Pro_ = id_se;
            ELIMINAR_SERVICIO();
        }

        //SOBRECARGA PARA ESCOJER EL ULTIMO ID DE RECEPCION DE COMPRA 
        public csCompraProductos()
        {
            ULTIMO_ID_COMPROBANTE();
        }

        //FUNCION PARA CREAR UNA COMPRAPRODUCTO
        private void ORDEN_COMPRA_PRODUCTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_CREAR_ORDE_COMPRA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@EmpleadoID", Empleado_id_);
                cmd.Parameters.AddWithValue("@Fecha", fecha_compra);
                cmd.Parameters.AddWithValue("@Descuento", Descuento_);
                cmd.Parameters.AddWithValue("@Codigo_iva_id", Cod_iva_id_);
                cmd.Parameters.AddWithValue("@proveedor_id", Proveedor_id_);
                cmd.Parameters.AddWithValue("@Numero_Fact", Numero_Fact_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //FUNCION PARA CREAR EL DETALLE DE COMPRA DE PRODUCTO Y GUARDAR EL PRODUCTO
        private void DETALLE_COMPRA_PRODUCTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_COMPRA_PRODUCTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Stock", Stock_); //
                cmd.Parameters.AddWithValue("@PrecioCompra", Precio_compra_); //
                cmd.Parameters.AddWithValue("@Producto_ID", ID_Servicio_Pro_); //
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
        //FUNCION PARA REGISTRAR UN SERVICIO
        private void REGISTRAR_SERVICIO_()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_SERVICIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NombreServicio", Nombre_producto_);
                cmd.Parameters.AddWithValue("@PrecioServicio", Precio_venta_);
                cmd.Parameters.AddWithValue("@Descripcion", Cantidad_por_unidad_); //
                cmd.Parameters.AddWithValue("@Categoria", Categoria_);//
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

        //FUNCION PARA MODIFICAR UN SERVICIO

        private void MODIFICAR_SERVICIO_()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_SERVICIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.AbrirConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@IDServicio", ID_Servicio_Pro_);
                cmd.Parameters.AddWithValue("@NombreS", Nombre_producto_);
                cmd.Parameters.AddWithValue("@PrecioVentaS", Precio_venta_); 
                cmd.Parameters.AddWithValue("@DescripcionS", Cantidad_por_unidad_);
                cmd.Parameters.AddWithValue("@CategoriaID", Categoria_);
                cmd.Parameters.AddWithValue("@Estado", Estado_);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                Verificar = 1;
                //Cerrar conexion
                conexion.CerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ELIMINAR_SERVICIO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_SERVICIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Servicio_id", ID_Servicio_Pro_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verificar = 1;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ULTIMO_ID_COMPROBANTE()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_UTIMA_ID_DE_RECEPCION", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Comprabante_recepcion_id = rd.GetInt32(0);

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
