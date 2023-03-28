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
    class csEmpleado:Persona
    {
        cConexion conexion = new cConexion();
        csVeterinaria objVet = new csVeterinaria();
        public MemoryStream ms;
        private int Estado;
        private byte[] foto;
        private string Tipo;
        private string Area;
        private int N_Oficina;
        private string User;
        private int ID_EMPLEADO;

        public int ID_EMPLEADO1
        {
            get { return ID_EMPLEADO; }
            set { ID_EMPLEADO = value; }
        }

        public string User1
        {
            get { return User; }
            set { User = value; }
        }

        public int Estado_E
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public string Tipo_E
        {
            get { return Tipo; }
            set { Tipo = value; }

        }
        public string Area_E
        {
            get { return Area; }
            set { Area = value; }
        }
        public int Oficina_E
        {
            get { return N_Oficina; }
            set { N_Oficina = value; }
        }

        public csEmpleado(string Nom, string Ape, string Tiden, string iden, string numc, string dir,  
                          string Tipo_Em ,string Ar_E, int Ofic,byte[]pic, int Estado=1)
                          : base(Nom,Ape,Tiden,iden,numc,dir)
        {
            Estado_E = Estado; Tipo_E = Tipo_Em; Area_E = Ar_E; Oficina_E = Ofic; foto = pic;
            BuscarID_Persona();
            InsertarEmpleado();
    
        }

        //#1ERA SOBRECARGA
        public csEmpleado(string CED_CED): base (CED_CED)
        {
            Datos_Empleado(CED_CED);
            VerImagen();
        }

        //2DA SOBRECARGA MODIFICAR EMPLEADO Y PERSONA
        public csEmpleado(int ID_P_1,string Nom, string Ape, string Tiden, string iden, string numc, string dir,
                          string Tipo_Em, string Ar_E, int Ofic, byte[] pic, int Estado = 1)
            : base(ID_P_1,Nom, Ape, Tiden, iden, numc, dir)
        {
            Estado_E = Estado; Tipo_E = Tipo_Em; Area_E = Ar_E; Oficina_E = Ofic; foto = pic;
            Modificar_Empleado();
        }


        //#3ER SOBRECARGAR
        public csEmpleado()
        {
 
        }
        //#4ta Sobrecarga
        public csEmpleado(string cedd, bool s)
        {
            Username_CED(cedd);
        }


        private void InsertarEmpleado()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_EMPLEADO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Persona", ID);
                cmd.Parameters.AddWithValue("@ID_V", objVet.ID);
                cmd.Parameters.AddWithValue("@Estado_E", Estado_E);
                cmd.Parameters.AddWithValue("@Tipo_E", Tipo_E);
                cmd.Parameters.AddWithValue("@Area_E", Area_E);
                cmd.Parameters.AddWithValue("@Oficina_E", Oficina_E);
                cmd.Parameters.AddWithValue("@foto", foto);
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

        public DataSet ListarEmpleadosCMB()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("SP_EMPLEADO_CMB", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "Id");
            return ds;
        }

        public List<csEmpleado> listarEmpleado()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_LISTAR_EMPLEADOS_DTG", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<csEmpleado> lstEmple = new List<csEmpleado>();
            csEmpleado objemple;
            while (dr.Read())
            {
                objemple = new csEmpleado();
                objemple.Nombre_Persona = dr.GetString(0);
                objemple.Apellido_Persona = dr.GetString(1);
                objemple.T_Identi_Persona = dr.GetString(2);
                objemple.Identificacion_Persona = dr.GetString(3);
                objemple.Celular_Persona = dr.GetString(4);
                lstEmple.Add(objemple);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEmple;
        }

        private void Datos_Empleado(string Buscar_Ced)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_EMPLEADO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Cedula", Buscar_Ced);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Tipo_E = rd.GetString(0);
                    Area_E = rd.GetString(1);
                    Oficina_E = rd.GetInt32(2);
                    Estado_E = rd.GetInt32(3);
                    ID_EMPLEADO1 = rd.GetInt32(4);
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

        private void VerImagen()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_BUSCAR_EMPLEADO_FOTO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Cedula", Identificacion_Persona);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("Foto");
                dp.Fill(ds, "Foto");
                byte[] Datos = new byte[0];
                DataRow DR = ds.Tables["Foto"].Rows[0];
                Datos = (byte[])DR["Foto"];
                ms = new MemoryStream(Datos);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "!!Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //hola.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void Modificar_Empleado()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_EMPLEADO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Persona", ID);
                cmd.Parameters.AddWithValue("@Estado_E", Estado_E);
                cmd.Parameters.AddWithValue("@Tipo_E", Tipo_E);
                cmd.Parameters.AddWithValue("@Area_E", Area_E);
                cmd.Parameters.AddWithValue("@Oficina_E", Oficina_E);
                cmd.Parameters.AddWithValue("@foto", foto);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Username_CED(string Buscar_Ced)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_USERNAME_CEDULA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@CED", Buscar_Ced);
               

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    User1 = rd.GetString(0);
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

        public void Datos_Empedo_CED(string identificacion_)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_DATOS_EMPLEADO_CEDULA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Identificacion", identificacion_);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ID_EMPLEADO1 = rd.GetInt32(0);
                    ID = rd.GetInt32(1);
                    Nombre_Persona = rd.GetString(2);
                    
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
