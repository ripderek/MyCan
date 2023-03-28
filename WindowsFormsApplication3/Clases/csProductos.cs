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
    class csProductos
    {
        cConexion conexion = new cConexion();
        //UN VERIFICADOR PARA LA NOTIFICACION
        public int Verficador_notifiacion;

        public int Verificardor_Combo = 0;   //nuevo

        //PROPIEDADES DE LA CLASE 
        private string nombre_producto;
        private decimal precio_venta;
        private string cantidad_por_unidad;
        private int categoria;
        private int estado;
        private int productp_id;
        private int stock;
        private int cantidadresta;
        private decimal oferta_Descuento = 0;
        private int cantidadunitariapro;

        public int Cantidad_Unitaria_Pro
        {
            get { return cantidadunitariapro; }
            set { cantidadunitariapro = value; }
        }

        public decimal Oferta_Descuento_
        {
            get { return oferta_Descuento; }
            set { oferta_Descuento = value; }
        }
        public int Cantidad_resta_
        {
            get { return cantidadresta; }
            set { cantidadresta = value; }
        }

        public int Stock_
        {
            get { return stock; }
            set { stock = value; }
        }
       
        //GET Y SET 
        public string Nombre_producto_
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }
        public decimal Precio_venta_
        {
            get { return precio_venta; }
            set { precio_venta = value; }
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
        public int Estado_
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Productp_id_
        {
            get { return productp_id; }
            set { productp_id = value; }
        }
        //CONSTRUCTOR PARA REGISTRAR LOS DATOS 
        public csProductos(string pro_nomb, decimal precio, string canxun, int cat)
        {
            Nombre_producto_ = pro_nomb; Precio_venta_ = precio; Cantidad_por_unidad_ = canxun; Categoria_ = cat; REGISTRAR_PRODUCTO();
        }
        //SOBRECARGA PARA EDITAR EL PRODUCTO 
        public csProductos(int pro_id, string nombre, decimal precio, string cantidad_produc, int cate, int esta)
        {
            Productp_id_ = pro_id; Nombre_producto_ = nombre; Precio_venta_ = precio; Cantidad_por_unidad_ = cantidad_produc; Categoria_ = cate; Estado_ = esta;
            EDITAR_PRODUCTO();
        }
        //SOBRECARGA PARA ELIMINAR
        public csProductos(int prod_id)
        {
            Productp_id_ = prod_id;
            ELIMINAR_PRODUCTO();
           
        }
        //SOBRECARGA PARA REGISTRAR UN COMBO
        public csProductos(string Nombre , decimal precio , string descripcion , int cate , int stock )
        {
            Nombre_producto_ = Nombre; Precio_venta_ = precio; Cantidad_por_unidad_ = descripcion; Categoria_ = cate; Stock_ = stock;
            REGISTRAR_COMBO();

        }

        //SOBRECARGA PARA RESTAR EL PRODUCTO DEL COMBO //BOOL PARA SABER SI VA A RESTAR EL SOTCK=FALSE ||TRUE SI VERIFICA UNA OFERTA DEL PRODUCTO
        public csProductos(int IDProducto , int CantidaRes, bool acc=false)
        {
            Productp_id_ = IDProducto; Cantidad_resta_ = CantidaRes;
            if (acc == false)
                RESTAR_STOCK_PRODUCTO_COMBO();
            else
                VERIFICAR_PROMOCION();
        }

        //SOBRECARGA PARA REGISTRAR EL DETALLE DEL COMBO

        public csProductos(int IDPro, int CantidadPro, int CantidaUnitariaPro)
        {
            Productp_id_ = IDPro; Cantidad_resta_ = CantidadPro; Cantidad_Unitaria_Pro = CantidaUnitariaPro;

            REGISTGRAR_DETALLE_COMBO();
        }

        private void REGISTRAR_PRODUCTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PRODUCTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NombreProducto", Nombre_producto_);
                cmd.Parameters.AddWithValue("@Precio_Venta", Precio_venta_);
                cmd.Parameters.AddWithValue("@CantidadPorUnidad", Cantidad_por_unidad_);
                cmd.Parameters.AddWithValue("@Categoria_ID", Categoria_);
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
        private void EDITAR_PRODUCTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PRODUCTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Producto_id", Productp_id_);
                cmd.Parameters.AddWithValue("@NombreProducto", Nombre_producto_);
                cmd.Parameters.AddWithValue("@Precio_Venta", Precio_venta_);
                cmd.Parameters.AddWithValue("@CantidadPorUnidad", Cantidad_por_unidad_);
                cmd.Parameters.AddWithValue("@Categoria_ID", Categoria_);
                cmd.Parameters.AddWithValue("@Estado", Estado_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            } 
        }
        private void ELIMINAR_PRODUCTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PRODUCTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Product_ID", Productp_id_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            } 
        }

        private void REGISTRAR_COMBO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_COMBO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NombreCombo", Nombre_producto_);
                cmd.Parameters.AddWithValue("@PrecioVenta", Precio_venta_);
                cmd.Parameters.AddWithValue("@Descripcion", Cantidad_por_unidad_);
                cmd.Parameters.AddWithValue("@Categoria", Categoria_);
                cmd.Parameters.AddWithValue("@Stock", Stock_);
                cmd.Parameters.AddWithValue("@Tipo", "Combo");
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("COMBO YA REGISTRADO", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 

                Verificardor_Combo = 1;     //nuevo ////////////////////
            }
        }

        private void RESTAR_STOCK_PRODUCTO_COMBO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_RESTAR_STOCK_COMBO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@IDproducto", Productp_id_);
                cmd.Parameters.AddWithValue("@Cantidadresta", Cantidad_resta_);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("COMBO YA REGISTRADO", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            }
        }

        public bool Veri_Oferta = false;

        private void VERIFICAR_PROMOCION()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_VERFIFICAR_OFERTA_PRODUCTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                cmd.Parameters.AddWithValue("@Product_id", Productp_id_);
                cmd.Parameters.AddWithValue("@Cantidad_Oferta", Cantidad_resta_);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    // ID_Cita1_ = rd.GetInt32(0); objeraza.Porcentaje_ = dr.GetSqlSingle(2)
                    Oferta_Descuento_ =decimal.Parse(rd.GetSqlSingle(0).ToString());
                    Veri_Oferta = true;
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


        private void REGISTGRAR_DETALLE_COMBO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("REGISTRAR_DETALLE_COMBO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Producto", Productp_id_);
                cmd.Parameters.AddWithValue("@CantidadProducto", Cantidad_resta_);
                cmd.Parameters.AddWithValue("@CantidadUnitariaProducto", Cantidad_Unitaria_Pro);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                Verficador_notifiacion = 1;// SI SE EFECTUÓ EL REGISTRO SIN PROBLEMAS

            }
            catch (Exception n)
            {
                MessageBox.Show("Error" + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Verficador_notifiacion = 0;//SI HUBO UN ERROR EN EL REGISTRO 
            }
        }

    }
}
