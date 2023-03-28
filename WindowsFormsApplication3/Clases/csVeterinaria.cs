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
    class csVeterinaria
    {
        cConexion conexion = new cConexion();
        private string Nombre;
        private string Direccion;
        private string ruc;
        private string celular;
        private string Numero_Sucursal;
        private int Id_Veterinaria;

        public int ID
        {
            get { return Id_Veterinaria; }
            set { Id_Veterinaria = value; }

        }
        public string NombreV
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string DireccionV
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string RucV
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public string CelularV
        {
            get { return celular; }
            set { celular = value; }
        }
        public string NumeroSucursalV
        {
            get { return Numero_Sucursal; }
            set { Numero_Sucursal = value; }
        }

        public csVeterinaria(string Nombre_V, string Direccion_V, string Ruc_V, string Celular_V, string NumeroS_V)
        {
            NombreV = Nombre_V; DireccionV = Direccion_V; RucV = Ruc_V; CelularV = Celular_V; NumeroSucursalV = NumeroS_V;
            InsertarEmpresa();
        }

        public csVeterinaria()
        {
            BuscarID();
        }

        public csVeterinaria(int tipo)
        {
            listarVeterinaria();
        }

        public csVeterinaria(string Nombre_V, string Direccion_V, string Ruc_V, string Celular_V, string NumeroS_V, int opc)
        {
            NombreV = Nombre_V; DireccionV = Direccion_V; RucV = Ruc_V; CelularV = Celular_V; NumeroSucursalV = NumeroS_V;

            ModificarVeterinaria();
        }


        private void InsertarEmpresa()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_VETERINARIA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Nom_Veterinaria", NombreV);
                cmd.Parameters.AddWithValue("@DireccionV", DireccionV);
                cmd.Parameters.AddWithValue("@RucV", RucV);
                cmd.Parameters.AddWithValue("@CelularV", CelularV);
                cmd.Parameters.AddWithValue("@NumeroSucursal_V", NumeroSucursalV);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                 //ENVIAR UN MENSAJEBOX PERSONALIZADO
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= "+n.Message , "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BuscarID()
        {
            try
            {
            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_ID_VETERINARIA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ID = dr.GetInt32(0);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
            }
            catch (Exception n)
            {

                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void listarVeterinaria()
        {
            try
            {

                //Para almacenar el resultado de la lectura de los datos
                SqlDataReader dr;

                SqlCommand cmd = new SqlCommand("SP_MOSTRAR_DATOS_VETE", conexion.con);
                //Tipo de sentencia a ejecutar
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexionç

                //conexion.abrirCerrarConexion();
                conexion.AbrirConexion();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    NombreV = dr.GetString(0);
                    DireccionV = dr.GetString(1);
                    RucV = dr.GetString(2);
                    CelularV = dr.GetString(3);
                    NumeroSucursalV = dr.GetString(4);
                }
                // Cierra Conexion
                conexion.CerrarConexion();
                //conexion.abrirCerrarConexion();
                dr.Close();
            }
            catch (Exception n)
            {

                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void ModificarVeterinaria()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_DATOS_VETE", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NombreVe", NombreV);
                cmd.Parameters.AddWithValue("@DireccionVe", DireccionV);
                cmd.Parameters.AddWithValue("@RucVe", RucV);
                cmd.Parameters.AddWithValue("@CelularVe", CelularV);
                cmd.Parameters.AddWithValue("@NumSucursal", NumeroSucursalV);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
