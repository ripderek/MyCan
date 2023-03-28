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
    class Listar_ClientesDGV
    {
        cConexion conexion = new cConexion();
        
        private string Nombres;
        private string Apellidos;
        private string Identificacion;
        private string Celular;
        private string Direccion;
        private string Ocupacion;
        public string Nombres_C
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        public string Apellidos_C
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string Identificacion_C
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }
        public string Celular_C
        {
            get { return Celular; }
            set { Celular = value; }
        }
        public string Direccion_C
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string Ocupacion_C
        {
            get { return Ocupacion; }
            set { Ocupacion = value; }
        }

        public List<Listar_ClientesDGV> listarClientes()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_CLIENTES_DTGV", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<Listar_ClientesDGV> lstClien = new List<Listar_ClientesDGV>();
            Listar_ClientesDGV objclien;
            while (dr.Read())
            {
                objclien = new Listar_ClientesDGV();
                objclien.Nombres_C = dr.GetString(0);
                objclien.Apellidos_C = dr.GetString(1);
                objclien.Identificacion_C = dr.GetString(2);
                objclien.Celular_C = dr.GetString(3);
                objclien.Direccion_C = dr.GetString(4);
                objclien.Ocupacion_C = dr.GetString(5);
                lstClien.Add(objclien);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstClien;
        }
    }
}
