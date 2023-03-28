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
    class Listar_Recepciones
    {
        cConexion conexion = new cConexion();
        private string nombre;
        private string apellido;
        private string numero_identificacion;
        private string nombre_compañia;
        private string numero_factura;      

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Numero_Identificacion
        {
            get { return numero_identificacion; }
            set { numero_identificacion = value; }
        }
        public string Nombre_Compañia
        {
            get { return nombre_compañia; }
            set { nombre_compañia = value; }
        }
        public string Factura
        {
            get { return numero_factura; }
            set { numero_factura = value; }
        }
        public List<Listar_Recepciones> listarIVA()
        {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_FACTURAS_DE_RECEPCION", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç
            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            dr = cmd.ExecuteReader();

            List<Listar_Recepciones> lstEmple = new List<Listar_Recepciones>();
            Listar_Recepciones objemple;
            while (dr.Read())
            {
                objemple = new Listar_Recepciones();
                objemple.Nombre = dr.GetString(0);
                objemple.Apellido = dr.GetString(1);
                objemple.Numero_Identificacion = dr.GetString(2);
                objemple.Nombre_Compañia = dr.GetString(3);
                objemple.Factura = dr.GetString(4);
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
