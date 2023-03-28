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
    class Listar_ProveedoresDGV
    {
        cConexion conexion = new cConexion();
        private string Nombre;
        private string Apellido;
        private string Identificacion;
        private string Celular;
        private int Sucursal;
        private string Direccion;
        private string Compania;


        public string Nombre_Compania
        {
            get { return Compania; }
            set { Compania = value; }

        }

        public string Nombre_Persona
        {
            get { return Nombre; }
            set { Nombre = value; }

        }
        public string Apellido_Persona
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public string Identi
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }
        public string Direccion_
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string Celular_Persona
        {
            get { return Celular; }
            set { Celular = value; }
        }
      
        public int N_Sucursal
        {
            get { return Sucursal; }
            set { Sucursal = value; }
        }

        public List<Listar_ProveedoresDGV> listarProveedores()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_PROVEEDORES_DTGV", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<Listar_ProveedoresDGV> lstProve = new List<Listar_ProveedoresDGV>();
            Listar_ProveedoresDGV objprove;
            while (dr.Read())
            {
                objprove = new Listar_ProveedoresDGV();
                objprove.Nombre_Compania = dr.GetString(0);
                objprove.Nombre_Persona = dr.GetString(1);
                objprove.Apellido_Persona = dr.GetString(2);
                objprove.Identi = dr.GetString(3);
                objprove.Celular_Persona = dr.GetString(4);
                objprove.N_Sucursal = dr.GetInt32(5);
                objprove.Direccion_ = dr.GetString(6);             
                lstProve.Add(objprove);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstProve;
        }
    }
}
