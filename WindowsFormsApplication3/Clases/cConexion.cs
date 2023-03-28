using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class cConexion
    {
        public int Pasar;
         private  string server;
       private string baseDeDatos;
       private string usuario;
       private string clave;
       private string FechaFormateada;
        public SqlConnection con;
        private int mesp;
        public int a = 0;
        public int bloque0 = 0;

        public cConexion()
        {
            Server = ".";
            BaseDeDatos = "MyCanBD";
            Usuario = "sa";
            Clave = "1234";

            con = new SqlConnection();
            con.ConnectionString = "Server=" + "." + ";DataBase=" + BaseDeDatos
                + ";User id=" + Usuario + ";Password=" + Clave;
        }
        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        public string BaseDeDatos
        {
            get { return baseDeDatos; }
            set { baseDeDatos = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public bool abrirCerrarConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            return true;
        }

        public void AbrirConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }
            
        }
        public void CerrarConexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                con.Close();
            }
            else
            {
                con.Close();
            }
        }



        public void LeerConfig(string config = "1")
        {
            try
            {
                StreamReader archivo = new StreamReader(@"..\Config.txt");
                string linea;
                string[] vector;
                while ((linea = archivo.ReadLine()) != null)
                {
                    vector = linea.Split('-');
                    if (vector[0] == config)
                    { Pasar = 1; }
                    else if (vector[0] == "2")
                        Pasar = 2;
                    else if (vector[0] == "3")
                        Pasar = 3;
                    else
                    { Pasar = 0; }
                }
                archivo.Close();
            }
            catch (Exception n)
            {
                MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE" + n);
            }
        }


        public void EscribirConfig(string Config = "1")
        {
            try
            {
                StreamWriter archivop = new StreamWriter(@"..\Config.txt");
                archivop.WriteLine(Config);
                archivop.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE" + e);
            }

        }


    }
}
