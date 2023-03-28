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
    class Listar_Medicamentos_DATA
    {
        cConexion conexion = new cConexion();

        private int medicamento_id;
        private string nombre_medicamento;
        private decimal precio_venta;
        private int stock;     
        private string descripcion;
        private string nombre_categoria;      
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
        public int Stock_
        {
            get { return stock; }
            set { stock = value; }
        } 
        public string Descripcion_
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Nombre_categoria_
        {
            get { return nombre_categoria; }
            set { nombre_categoria = value; }
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
       
        public List<Listar_Medicamentos_DATA> listarIVA()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_MEDICAMENTOS_DATA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<Listar_Medicamentos_DATA> lstEmple = new List<Listar_Medicamentos_DATA>();
            Listar_Medicamentos_DATA objemple;
            while (dr.Read())
            {
                objemple = new Listar_Medicamentos_DATA();
                objemple.Medicamento_id_ = dr.GetInt32(0);
                objemple.Nombre_medicamento_ = dr.GetString(1);
                objemple.Precio_venta_ =decimal.Parse( dr.GetDecimal(2).ToString("N2"));
                objemple.Stock_ = dr.GetInt32(3);
                objemple.Descripcion_ = dr.GetString(4);
                objemple.Nombre_categoria_ = dr.GetString(5);
                objemple.Categoria_ = dr.GetInt32(6);
                objemple.Estado_ = dr.GetInt32(7);
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
