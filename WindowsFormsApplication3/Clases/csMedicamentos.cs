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
    class csMedicamentos
    {
        cConexion conexion = new cConexion();
        public int Verificar;
        private int medicamento_id;
        private string nombre_medicamento;
        private decimal precio_venta;
        private string descripcion;
        private int categoria;
        private int estado;

        
      
        public int Medicamento_id_
        {
            get { return medicamento_id; }
            set { medicamento_id = value; }
        }
        public string Nombre_medicamento_
        {
            get { return nombre_medicamento; }
            set { nombre_medicamento = value; }
        }
        public decimal Precio_venta_
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }
        public string Descripcion_
        {
            get { return descripcion; }
            set { descripcion = value; }
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
        //CONSTRUCTOR PARA CREAR EL MEDICAMENTO 
        public csMedicamentos(string nom, decimal preci, string desci, int cat)
        {
            Nombre_medicamento_ = nom; Precio_venta_ = preci; Descripcion_ = desci; Categoria_ = cat;
            CREAR_MEDICAMENTO();
        }
        //CONSTRUCTOR PARA MODIFICAR UN MEDICAMENTO
        public csMedicamentos(string nom, decimal preci, string desci, int cat, int esta, int medi)
        {
            Nombre_medicamento_ = nom; Precio_venta_ = preci; Descripcion_ = desci; Categoria_ = cat; Estado_ = esta; Medicamento_id_ = medi;
            MODIFICAR_MEDICAMENTO();
        }
        //CONSTRUCTOR PARA ELIMINAR UN MEDICAMENTO 
        public csMedicamentos(int medi)
        {
            Medicamento_id_ = medi;
            ELIMINAR_MEDICAMENTO();
        }
        private void CREAR_MEDICAMENTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_MEDICAMENTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NombreServicio", Nombre_medicamento_);
                cmd.Parameters.AddWithValue("@PrecioServicio", Precio_venta_);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion_); //
                cmd.Parameters.AddWithValue("@Categoria", Categoria_);//
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                Verificar = 1;
                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                Verificar = 0;
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MODIFICAR_MEDICAMENTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_MEDICAMENTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NombreServicio", Nombre_medicamento_);
                cmd.Parameters.AddWithValue("@PrecioServicio", Precio_venta_);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion_); //
                cmd.Parameters.AddWithValue("@Categoria", Categoria_);//
                cmd.Parameters.AddWithValue("@Estado", Estado_);//
                cmd.Parameters.AddWithValue("@Medicamento_id", Medicamento_id_);//

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                Verificar = 1;
                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                Verificar = 0;
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ELIMINAR_MEDICAMENTO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_MEDICAMENTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Medicamento_id", Medicamento_id_);//

                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                Verificar = 1;
                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                Verificar = 0;
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
