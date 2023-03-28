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
    class csEspecie_Raza_Animal
    {
        cConexion conexion = new cConexion();
        private int ID;
        private string especie;
        private string raza;

        public string Raza_Animal
       {
           get { return raza; }
           set { raza = value; }
       }

        public int ID_ES
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Nombre_Especie
        {
            get { return especie; }
            set { especie = value; }
        }



        public void InsertarEspecie()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INGRESAR_ESPECIE", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Especie", Nombre_Especie);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void InsertarRaza()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INGRESAR_RAZA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Especie", ID_ES);
                cmd.Parameters.AddWithValue("@Raza", Raza_Animal);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public DataSet ListarEspeciesAnimalesCMB()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("SP_COMBOBOX_ESPECIES", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "id_Especie");
            return ds;
        }
        public DataSet ListarRAZASAnimalesCMB()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            //select Id,Nombre_Raza from Raza_Animal where Id_Especie_Animal=@id_E
            da_Taxitas.SelectCommand = new SqlCommand("select Id,Nombre_Raza from Raza_Animal where Id_Especie_Animal="+ID_ES, conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "Id");
            return ds;
        }


    }
}
