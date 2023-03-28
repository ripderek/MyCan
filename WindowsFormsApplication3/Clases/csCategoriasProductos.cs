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
    class csCategoriasProductos
    {
        cConexion conexion = new cConexion();
        public int verificar;
        private int CategoriaID;
        private string NombreCategoria;
        private string DescripcionCategoria;     
 
        public int CategoriaID1
        {
            get { return CategoriaID; }
            set { CategoriaID = value; }
        }
        public string NombreCategoria1
        {
            get { return NombreCategoria; }
            set { NombreCategoria = value; }
        }
        public string DescripcionCategoria1
        {
            get { return DescripcionCategoria; }
            set { DescripcionCategoria = value; }
        }


        //CONTRUSTOR VACIO

        public csCategoriasProductos()
        {
 
        }

        //CONTRUSTOR PARA REGISTRAR CATEGORIA

        public csCategoriasProductos(string nombre_c, string descripcion_c)
        {
            NombreCategoria1 = nombre_c;
            DescripcionCategoria1 = descripcion_c;
            REGISTRAR_CATEGORIA();
        }

        //CONTRUSTOR PARA MODIFICAR CATEGORIA

        public csCategoriasProductos(int idcategori_c ,string nombre_c, string descripcion_c)
        {
            CategoriaID1 = idcategori_c;
            NombreCategoria1 = nombre_c;
            DescripcionCategoria1 = descripcion_c;
            MODIFICAR_CATEGORIA();
        }
        //CONSTRUCTOR PARA ELIMINAR UNA CATEGORIA
        public csCategoriasProductos( int id_c)
        {
            CategoriaID1 = id_c;
            ELIMINAR_CATEGORIA();
        }
        //lISTAR EN COMBOBOX

        public DataSet CategoriaCombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("SP_Categorias_Combobox", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "Categoria_ID");
            return ds;
        }

        // Listar categorias 

        public List<csCategoriasProductos> ListarCategoria()
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_LISTAR_CATEGORIAS", conexion.con);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<csCategoriasProductos> lstCategoria = new List<csCategoriasProductos>();
            csCategoriasProductos objCategori;
            while (dr.Read())
            {
                objCategori = new csCategoriasProductos();
                objCategori.CategoriaID1 = dr.GetInt32(0);
                objCategori.NombreCategoria1 = dr.GetString(1);
                objCategori.DescripcionCategoria1 = dr.GetString(2);
                lstCategoria.Add(objCategori);
            }
            conexion.CerrarConexion();
            dr.Close();
            return lstCategoria;

        }

        //FUNCION REGISTRAR CATEGORIA

        private void REGISTRAR_CATEGORIA()
        {
            try
            {

            SqlCommand cmd = new SqlCommand("SP_REGISTRAR_CATEGORIA", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.AbrirConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@NombreC", NombreCategoria1);
            cmd.Parameters.AddWithValue("@DescripcionC", DescripcionCategoria1);

            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            //Cerrar conexion
            conexion.CerrarConexion();
            verificar = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("NO SE PUEDE REGISTRAR UNA CATEGORIA CON EL MISMO NOMBRE", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        private void MODIFICAR_CATEGORIA()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_CATEGORIA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.AbrirConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@IDCategoria", CategoriaID1);
                cmd.Parameters.AddWithValue("@NombreC", NombreCategoria1);
                cmd.Parameters.AddWithValue("@DescripcionC", DescripcionCategoria1);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.CerrarConexion();
                verificar = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("NO SE PUEDE REGISTRAR UNA CATEGORIA CON EL MISMO NOMBRE", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ELIMINAR_CATEGORIA()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CATEGORIA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.AbrirConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Categoria_ID", CategoriaID1);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                conexion.CerrarConexion();
                verificar = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUEDE ELMINAR LA CATEGORIA", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
