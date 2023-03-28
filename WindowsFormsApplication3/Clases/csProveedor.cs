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
    class csProveedor:Persona
    {
        cConexion conexion = new cConexion();
        private int NumeroS;
        private int Estado;
        private string CompaniaNombre;
        public string NombreCom
        {
            get { return CompaniaNombre; }
            set {CompaniaNombre= value; }
        }
        public int Sucursal
        {
            get { return NumeroS; }
            set { NumeroS = value; }
        }
        public int Estado_P
        {
            get { return Estado;  }
            set { Estado = value; }
        }

        //Primer Constructor para ingesar el proveedor
        public csProveedor(string Nom, string Ape, string Tiden, string iden, string numc, string dir,
                          int Sucu, string comp)
            : base(Nom, Ape, Tiden, iden, numc, dir)
        {
            Sucursal = Sucu;
            NombreCom=comp;
            BuscarID_Persona();
            RegistrarProveedor();
        }

        //Segundo Constructor para obtener los datos del Proveedor
        public csProveedor(string ced_ced):base(ced_ced)
        {
            Datos_Proveedor();
        }

        //Segundo Constructor para modificar los datos del proveedor 
        public csProveedor(int IDS, string Nom, string Ape, string Tiden, string iden, string numc, string dir,
                           int sucu, int estad, string comp)
                           :base(IDS,Nom, Ape, Tiden, iden, numc,  dir)
        {
            Sucursal = sucu; Estado_P = estad; NombreCom = comp;
            Modificar_Proveedor();
        }

        private void RegistrarProveedor()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PROVEEDOR", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Persona", ID);
                cmd.Parameters.AddWithValue("@Sucursal", Sucursal);
                cmd.Parameters.AddWithValue("@Estado", 1);
                cmd.Parameters.AddWithValue("@NombreCom", NombreCom);
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

        private void Datos_Proveedor()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_ID_CEDULA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Ced", Identificacion_Persona);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Sucursal = rd.GetInt32(0);
                    Estado_P = rd.GetInt32(1);
                    NombreCom = rd.GetString(2);

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

        private void Modificar_Proveedor()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Modificar_PROVEEDOR", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Id_Per", ID);
                cmd.Parameters.AddWithValue("@Sucursal", Sucursal);
                cmd.Parameters.AddWithValue("@Estado", Estado_P);
                cmd.Parameters.AddWithValue("@NombreCom", NombreCom);
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
    }
}
