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
    class LISTAR_SERVICIOS
    {
        cConexion conexion = new cConexion(); //CONEXION
        //C.Categoria_ID 
        private int servicio_id;
        private string nombre_servicio;
        private string Precio_Venta;
        private string categoria;
        //private string descripcion_categoria;
        private int categoria_id;
        private int estado;
        private string descripcion_servicio;


        public int Servicio_id
        {
            get { return servicio_id; }
            set { servicio_id = value; }
        }
        public string Servicio_
        {
            get { return nombre_servicio; }
            set { nombre_servicio = value; }
        }
        public string Precio_Venta_
        {
            get { return Precio_Venta; }
            set { Precio_Venta = value; }
        }
        public string Descripcion_Servicio_
        {
            get { return descripcion_servicio; }
            set { descripcion_servicio = value; }
        }
        public string Categoria_
        {
            get { return categoria; }
            set { categoria = value; }
        }
        //public string Descripcion_Categoria_
        //{
        //    get { return descripcion_categoria; }
        //    set { descripcion_categoria = value; }
        //}
        public int Categoria_id_
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }
        public int Estado_
        {
            get { return estado; }
            set { estado = value; }
        }
        public List<LISTAR_SERVICIOS> listarEmpleado()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_SERVICIO", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<LISTAR_SERVICIOS> lstEmple = new List<LISTAR_SERVICIOS>();
            LISTAR_SERVICIOS objemple;
            while (dr.Read())
            {
                objemple = new LISTAR_SERVICIOS();
                objemple.Servicio_id= dr.GetInt32(0);
                objemple.Servicio_ = dr.GetString(1);
                objemple.Precio_Venta_ = dr.GetDecimal(2).ToString("N2");
                objemple.Descripcion_Servicio_ = dr.GetString(3);
                objemple.Categoria_ = dr.GetString(4);
                objemple.Categoria_id_ = dr.GetInt32(5);
                objemple.Estado_ = dr.GetInt32(6);
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
