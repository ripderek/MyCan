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
    class csClientes:Persona
    {
        cConexion conexion = new cConexion();
        public MemoryStream ms;
        private int Estado;
        private string Ocupacion;
        private int ID_cliente;
        public int ID_CLIENTE_
        {
            get { return ID_cliente; }
            set { ID_cliente = value; }
        }
        public int Estado_E
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public string Ocupacion_C
        {
            get { return Ocupacion; }
            set { Ocupacion = value; }
        }
       
        //#1er Constructor para Ingresar Clientes
        public csClientes(string Nom, string Ape, string Tiden, string iden, string numc, string dir,
                           string Ocupa ,int Estadoa = 1)
                         : base(Nom, Ape, Tiden, iden, numc, dir)
        {
            Ocupacion_C = Ocupa; Estado_E = Estadoa;
            BuscarID_Persona();
            InsertarCliente();
        }

        //2do Constructor 2da Sobrecarga para Extraer los datos de los Clientes Segun la Cedula
        public csClientes(string CED_CED)
            : base(CED_CED)
        {
            Datos_Cliente(CED_CED);
        }

        // COnstructor para modificar un cliente

        public csClientes(string Nom, string Ape, string TipoIden, string iden, string numc, string dir, string Ocupa, int Estado , int tipo)
        {

        }





        //#3er CONSTRUCTOR PARA PODER INVOCAR CUALQUIER METODO PUBLICO 
        public csClientes()
        {
 
        }

        private void InsertarCliente()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_CLIENTE", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Persona", ID);
                cmd.Parameters.AddWithValue("@Estado", Estado_E);
                cmd.Parameters.AddWithValue("@Ocupacion", Ocupacion_C);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Datos_Cliente(string Buscar_Ced)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_DATOS_CLIENTES_CED", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Cedula", Buscar_Ced);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();

                //private int Estado;
               // private string Ocupacion;

                while (rd.Read())
                {

                    Ocupacion_C = rd.GetString(0);
                    Estado_E = rd.GetInt32(1);
                    ID_CLIENTE_ = rd.GetInt32(2);
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
         public DataSet ListarCLIENTESCMB()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("SP_CLIENTES_COMBOBOX", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "ID");
            return ds;
        }

         public void ID_CLIENTE_BUSCAR(string Buscar_Ced)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("SP_ID_CLIENTE_CEDULA", conexion.con);
                 cmd.CommandType = CommandType.StoredProcedure;

                 //Abrir conexion
                 conexion.abrirCerrarConexion();

                 //Asignar parámetros
                 cmd.Parameters.AddWithValue("@CED", Buscar_Ced);


                 //Ejecutar procedure
                 cmd.ExecuteNonQuery();

                 SqlDataReader rd = cmd.ExecuteReader();

                 //private int Estado;
                 // private string Ocupacion;

                 while (rd.Read())
                 {
                     ID_CLIENTE_ = rd.GetInt32(0);
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
