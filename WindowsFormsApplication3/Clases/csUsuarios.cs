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
    class csUsuarios:csEmpleado
    {
        cConexion conexion = new cConexion();
        private int Id_user;
        public int Id_user1
        {
            get { return Id_user; }
            set { Id_user = value; }
        }
        private int  Id_Empleado;
        private string usermane;
        private string contrasena;
        private string Pregunta;
        private string Respuesta;
        public int VUser;
        public int VEUser;
        //PERMISOS 
        private int P_lista;

        public int P_lista1
        {
            get { return P_lista; }
            set { P_lista = value; }
        }
        private int P_Agregar;

        public int P_Agregar1
        {
            get { return P_Agregar; }
            set { P_Agregar = value; }
        }
        private int P_Modificar;

        public int P_Modificar1
        {
            get { return P_Modificar; }
            set { P_Modificar = value; }
        }
        private int C_lista;

        public int C_lista1
        {
            get { return C_lista; }
            set { C_lista = value; }
        }
        private int C_Agregar;

        public int C_Agregar1
        {
            get { return C_Agregar; }
            set { C_Agregar = value; }
        }
        private int C_Modificar;

        public int C_Modificar1
        {
            get { return C_Modificar; }
            set { C_Modificar = value; }
        }
        private int Pp_lista;

        public int Pp_lista1
        {
            get { return Pp_lista; }
            set { Pp_lista = value; }
        }
        private int Pp_Agregar;

        public int Pp_Agregar1
        {
            get { return Pp_Agregar; }
            set { Pp_Agregar = value; }
        }
        private int Pp_Modificar;

        public int Pp_Modificar1
        {
            get { return Pp_Modificar; }
            set { Pp_Modificar = value; }
        }
        private int Pa_Lista;

        public int Pa_Lista1
        {
            get { return Pa_Lista; }
            set { Pa_Lista = value; }
        }
        private int Pa_Agregar;

        public int Pa_Agregar1
        {
            get { return Pa_Agregar; }
            set { Pa_Agregar = value; }
        }
        private int Pa_Modificar;

        public int Pa_Modificar1
        {
            get { return Pa_Modificar; }
            set { Pa_Modificar = value; }
        }
        private int Pr_Lista;

        public int Pr_Lista1
        {
            get { return Pr_Lista; }
            set { Pr_Lista = value; }
        }
        private int Pr_Agregar;

        public int Pr_Agregar1
        {
            get { return Pr_Agregar; }
            set { Pr_Agregar = value; }
        }
        private int Pr_Modificar;

        public int Pr_Modificar1
        {
            get { return Pr_Modificar; }
            set { Pr_Modificar = value; }
        }
        private int Er_LAM;

        public int Er_LAM1
        {
            get { return Er_LAM; }
            set { Er_LAM = value; }
        }
        private int Citas_agendar;

        public int Citas_agendar1
        {
            get { return Citas_agendar; }
            set { Citas_agendar = value; }
        }
        private int Citas_Modificar;

        public int Citas_Modificar1
        {
            get { return Citas_Modificar; }
            set { Citas_Modificar = value; }
        }
        private int His_listar;

        public int His_listar1
        {
            get { return His_listar; }
            set { His_listar = value; }
        }
        private int His_Registrar;

        public int His_Registrar1
        {
            get { return His_Registrar; }
            set { His_Registrar = value; }
        }
        private int His_Modificar;

        public int His_Modificar1
        {
            get { return His_Modificar; }
            set { His_Modificar = value; }
        }
        private int Factura_LAM;

        public int Factura_LAM1
        {
            get { return Factura_LAM; }
            set { Factura_LAM = value; }
        }
        private int Servi;

        public int Servi1
        {
            get { return Servi; }
            set { Servi = value; }
        }
        private int Hospi;

        public int Hospi1
        {
            get { return Hospi; }
            set { Hospi = value; }
        }
        private int Config;

        public int Config1
        {
            get { return Config; }
            set { Config = value; }
        }

        public int ID
        {
            get { return Id_Empleado; }
            set { Id_Empleado = value; }
        }
        public string Username_P
        {
            get { return usermane; }
            set { usermane = value; }
        }
        public string Contraseña_P
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public string RespuestaP
        {
            get { return Respuesta; }
            set { Respuesta = value; }
        }
        public string PreguntaP
        {
            get { return Pregunta; }
            set { Pregunta = value; }
        }

        //Resgistrar usurio Administrador 
        public csUsuarios(int ID_E, string User, string Contra, string Pre, string Repues)
        {
            ID = ID_E; Username_P = User; Contraseña_P = Contra; RespuestaP = Repues; PreguntaP = Pre;
            InsertarUsuario();
            Datos_EMPLEADO_USER(User);
            PermisosDefault(1);
            InsertarPermisos();
        }

        //SOBRECARGA PARA VERIFICAR LA EXISTENCIA DEL USUARIO
        public csUsuarios(int ID_E, string User, string Contra, string Pre, string Repues, bool ver)
        {
            ID = ID_E; Username_P = User; Contraseña_P = Contra; RespuestaP = Repues; PreguntaP = Pre;
            Verificar_Existencia_Usuario();
            if (VEUser == 1)
                MessageBox.Show("Este Empleado ya tiene un usuario");
            else
            {
                InsertarUsuario();
                Datos_EMPLEADO_USER(User);
                PermisosDefault();
                InsertarPermisos();
            }
        }
        //SOBRECARGAR PARA MODIFICAR LOS PERMISOS DEL USUARIO
        public csUsuarios(string userM,int P_listaM, int P_AgregarM,int P_ModificarM, int C_listaM,int C_AgregarM,int C_ModificarM,
                           int Pp_listaM, int Pp_AgregarM, int Pp_ModificarM,int Pa_ListaM,int Pa_AgregarM,int Pa_ModificarM,int Pr_ListaM,
                           int Pr_AgregarM, int Pr_ModificarM,int Er_LAMM,int Citas_agendarM,int Citas_ModificarM,int His_listarM, 
                           int His_RegistrarM,int His_ModificarM,int Factura_LAMM,int ServiM,int HospiM,int ConfigM)
        {
            P_lista1 = P_listaM; P_Agregar1 = P_AgregarM; P_Modificar1 = P_ModificarM; C_lista1 = C_listaM; C_Agregar1 = C_AgregarM; C_Modificar1 = C_ModificarM;
            Pp_lista1 = Pp_listaM; Pp_Agregar1 = Pp_AgregarM; Pp_Modificar1 = Pp_ModificarM; Pa_Lista1 = Pa_ListaM; Pa_Agregar1 = Pa_AgregarM; Pa_Modificar1 = Pa_ModificarM;
            Pr_Lista1 = Pr_ListaM; Pr_Agregar1 = Pr_AgregarM; Pr_Modificar1 = Pr_ModificarM; Er_LAM1 = Er_LAMM; Citas_agendar1 = Citas_agendarM; Citas_Modificar1 = Citas_ModificarM;
            His_listar1 = His_listarM; His_Registrar1 = His_RegistrarM; His_Modificar1 = His_ModificarM; Factura_LAM1 = Factura_LAMM; Servi1 = ServiM; Hospi1 = HospiM; Config1 = ConfigM;
            Datos_EMPLEADO_USER(userM);
            ModificarPermisos();
        }
        //SOBRECARGAR PARA VERIFICAR EL LOGIN 
        public csUsuarios(string USERN, string CONTN)
        {
            Username_P = USERN; Contraseña_P = CONTN;
            Verificar_User();
 
        }

        //sobrecargar datos del usuario
        public csUsuarios(string usernm, int ac =0)
        {
            if (ac == 0)
                Datos_EMPLEADO_USER(usernm);
            else if (ac==1)
            { Username_P = usernm; Pregunta_Seguridad_Username(); }
        }

        //sobrecarga para obtener los permisos del usuario segun su username ingresado
        public csUsuarios(string us,bool va)
        {
            PERMISOS_USER_OBT(us);
        }

        //SOBRECARGAR PARA EDITAR LOS DATOS DE UN USUARIO (CUANDO EL USUARIO QUIERE ACTUALIZAR SUS PARAMETROS DE ACCESO)
        public csUsuarios(int Id_s_, string con_, string user_, string contra1_, string pre_seg_, string respe_seg_, UIDC.UI_Notification noti)
        {
            Id_user1 = Id_s_; Contraseña_P = con_;
            int pas = Verificar_ID_Contraseña();
            if (pas == 1)
            {
                Username_P = user_; Contraseña_P = contra1_; PreguntaP = pre_seg_; RespuestaP = respe_seg_;
                Actulizar_Datos_User_M( noti);
            }
        }
        //SOBRECARGA PARA RECUPERAR LA CONTRASEÑA DESDE EL FORMULARIO DEL LOGIN 
        public csUsuarios(string User_name_, string Nueva_contra_, string respe_s_, string pre_ , UIDC.UI_Notification noti)
        {
            Username_P = User_name_; Contraseña_P = Nueva_contra_; RespuestaP = respe_s_; PreguntaP = pre_;
            int var = verificar_pregunta_respuesta();
            if (var == 1)
                Recuperar_Contraseña(noti);   
            else
                MessageBox.Show("LA PREGUNTA O RESPUESTA NO COINCIDE");

        }


        private void InsertarUsuario()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INGRESAR_USUARIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Emp", ID);
                cmd.Parameters.AddWithValue("@Usuario", Username_P);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña_P);
                cmd.Parameters.AddWithValue("@Preguntas", PreguntaP);
                cmd.Parameters.AddWithValue("@Respuestas", RespuestaP);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();

                //-----------------------------------------------------------------------

                //Crea el login del usuario SQL
                cmd = new SqlCommand("create login " + Username_P + " with password ='" + Contraseña_P + "'", conexion.con);
                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                //Crea el user del usuario SQL
                cmd = new SqlCommand("create user " + Username_P + " for login " + Username_P, conexion.con);
                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                //Agrega los permisos a las tablas
                cmd = new SqlCommand("grant all to " + Username_P, conexion.con);
                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                //----------------------------------------------------

                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Verificar_User()
        {
            SqlCommand cmd = new SqlCommand("SP_VERIFICAR_USER", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@User", Username_P);
            cmd.Parameters.AddWithValue("@Contrasena", Contraseña_P);

            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { VUser=1; }

            //Cerrar conexion
            conexion.abrirCerrarConexion();
        }


        private void Datos_EMPLEADO_USER(string usernamea)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_DTLOGIN_EMPLEADO_CED", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@User", usernamea);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();

                //private int Estado;
                // private string Ocupacion;

                while (rd.Read())
                {
                    ID = rd.GetInt32(0); 
                    Apellido_Persona = rd.GetString(1);
                    Identificacion_Persona = rd.GetString(2);
                    Id_user1 = rd.GetInt32(3);
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


        private void Verificar_Existencia_Usuario()
        {
            SqlCommand cmd = new SqlCommand("SP_VERIFICAR_EXISTENCIA_USUARIO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@ID_Empleado", ID);

            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { VEUser = 1; }

            //Cerrar conexion
            conexion.abrirCerrarConexion();
        }


        private void InsertarPermisos()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PERMISOS_USER", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Id_Usera", Id_user1);
                cmd.Parameters.AddWithValue("@P_listaa", P_lista1);
                cmd.Parameters.AddWithValue("@P_Agregara", P_Agregar1);
                cmd.Parameters.AddWithValue("@P_Modificara", P_Modificar1);
                cmd.Parameters.AddWithValue("@C_listaa", C_lista1);
                cmd.Parameters.AddWithValue("@C_Agregara", C_Agregar1);
                cmd.Parameters.AddWithValue("@C_Modificara", C_Modificar1);
                cmd.Parameters.AddWithValue("@Pp_listaa", Pp_lista1);
                cmd.Parameters.AddWithValue("@Pp_Agregara", Pp_Agregar1);
                cmd.Parameters.AddWithValue("@Pp_Modificara", Pp_Modificar1);
                cmd.Parameters.AddWithValue("@Pa_Listaa", Pp_lista1);
                cmd.Parameters.AddWithValue("@Pa_Agregara", Pa_Agregar1);
                cmd.Parameters.AddWithValue("@Pa_Modificara", Pa_Modificar1);
                cmd.Parameters.AddWithValue("@Pr_Listaa", Pr_Lista1);
                cmd.Parameters.AddWithValue("@Pr_Agregara", Pr_Agregar1);
                cmd.Parameters.AddWithValue("@Pr_Modificara", Pr_Modificar1);
                cmd.Parameters.AddWithValue("@Er_LAMa", Er_LAM1);
                cmd.Parameters.AddWithValue("@Citas_agendara", Citas_agendar1);
                cmd.Parameters.AddWithValue("@Citas_Modificara", Citas_Modificar1);
                cmd.Parameters.AddWithValue("@His_listara", His_listar1);
                cmd.Parameters.AddWithValue("@His_Registrara", His_Registrar1);
                cmd.Parameters.AddWithValue("@His_Modificara", His_Modificar1);
                cmd.Parameters.AddWithValue("@Factura_LAMa", Factura_LAM1);
                cmd.Parameters.AddWithValue("@Servia", Servi1);
                cmd.Parameters.AddWithValue("@Hospia", Hospi1);
                cmd.Parameters.AddWithValue("@Configa", Config1);
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


        private void ModificarPermisos()
        {

            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PERMISOS_USUARIOS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Id_Usera", Id_user1);
                cmd.Parameters.AddWithValue("@P_listaa", P_lista1);
                cmd.Parameters.AddWithValue("@P_Agregara", P_Agregar1);
                cmd.Parameters.AddWithValue("@P_Modificara", P_Modificar1);
                cmd.Parameters.AddWithValue("@C_listaa", C_lista1);
                cmd.Parameters.AddWithValue("@C_Agregara", C_Agregar1);
                cmd.Parameters.AddWithValue("@C_Modificara", C_Modificar1);
                cmd.Parameters.AddWithValue("@Pp_listaa", Pp_lista1);
                cmd.Parameters.AddWithValue("@Pp_Agregara", Pp_Agregar1);
                cmd.Parameters.AddWithValue("@Pp_Modificara", Pp_Modificar1);
                cmd.Parameters.AddWithValue("@Pa_Listaa", Pp_lista1);
                cmd.Parameters.AddWithValue("@Pa_Agregara", Pa_Agregar1);
                cmd.Parameters.AddWithValue("@Pa_Modificara", Pa_Modificar1);
                cmd.Parameters.AddWithValue("@Pr_Listaa", Pr_Lista1);
                cmd.Parameters.AddWithValue("@Pr_Agregara", Pr_Agregar1);
                cmd.Parameters.AddWithValue("@Pr_Modificara", Pr_Modificar1);
                cmd.Parameters.AddWithValue("@Er_LAMa", Er_LAM1);
                cmd.Parameters.AddWithValue("@Citas_agendara", Citas_agendar1);
                cmd.Parameters.AddWithValue("@Citas_Modificara", Citas_Modificar1);
                cmd.Parameters.AddWithValue("@His_listara", His_listar1);
                cmd.Parameters.AddWithValue("@His_Registrara", His_Registrar1);
                cmd.Parameters.AddWithValue("@His_Modificara", His_Modificar1);
                cmd.Parameters.AddWithValue("@Factura_LAMa", Factura_LAM1);
                cmd.Parameters.AddWithValue("@Servia", Servi1);
                cmd.Parameters.AddWithValue("@Hospia", Hospi1);
                cmd.Parameters.AddWithValue("@Configa", Config1);
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


        private void PermisosDefault(int val=0)
        {
            P_lista1=val;
            P_Agregar1=val;
            P_Modificar1=val;
            C_lista1=val;
            C_Agregar1=val;
            C_Modificar1=val;
            Pp_lista1=val;
            Pp_Agregar1=val;
            Pp_Modificar1=val;
            Pa_Lista1=val;
            Pa_Agregar1=val;
            Pa_Modificar1=val;
            Pr_Lista1=val;
            Pr_Agregar1=val;
            Pr_Modificar1=val;
            Er_LAM1=val;
            Citas_agendar1=val;
            Citas_Modificar1=val;
            His_listar1=val;
            His_Registrar1=val;
            His_Modificar1=val;
            Factura_LAM1=val;
            Servi1=val;
            Hospi1=val;
            Config1 = val;
 
        }

        private void PERMISOS_USER_OBT(string usernamea)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_OBTENER_PERMISOS_USUARIOS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Username", usernamea);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();

                //private int Estado;
                // private string Ocupacion;

                while (rd.Read())
                {
                    Id_user1 = rd.GetInt32(0);
                    P_lista1 = rd.GetInt32(1);
                    P_Agregar1 = rd.GetInt32(2);
                    P_Modificar1 = rd.GetInt32(3);
                    C_lista1 = rd.GetInt32(4);
                    C_Agregar1 = rd.GetInt32(5);
                    C_Modificar1 = rd.GetInt32(6);
                    Pp_lista1 = rd.GetInt32(7);
                    Pp_Agregar1 = rd.GetInt32(8);
                    Pp_Modificar1 = rd.GetInt32(9);
                    Pa_Lista1 = rd.GetInt32(10);
                    Pa_Agregar1 = rd.GetInt32(11);
                    Pa_Modificar1 = rd.GetInt32(12);
                    Pr_Lista1 = rd.GetInt32(13);
                    Pr_Agregar1 = rd.GetInt32(14);
                    Pr_Modificar1 = rd.GetInt32(15);
                    Er_LAM1 = rd.GetInt32(16);
                    Citas_agendar1 = rd.GetInt32(17);
                    Citas_Modificar1 = rd.GetInt32(18);
                    His_listar1 = rd.GetInt32(19);
                    His_Registrar1 = rd.GetInt32(20);
                    His_Modificar1 = rd.GetInt32(21);
                    Factura_LAM1 = rd.GetInt32(22);
                    Servi1 = rd.GetInt32(23);
                    Hospi1 = rd.GetInt32(24);
                    Config1 = rd.GetInt32(25);                 
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

        private int  Verificar_ID_Contraseña()
        {
            int ver=0;
            SqlCommand cmd = new SqlCommand("Sp_VERFICAR_CONTRAS_USER", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@Id_Us", Id_user1);
            cmd.Parameters.AddWithValue("@Contra", Contraseña_P);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { ver = 1; }

            //Cerrar conexion
            conexion.abrirCerrarConexion();
            return ver;
        }

        private void Actulizar_Datos_User_M(UIDC.UI_Notification noti) //M= EL USARIO MISMO ESTA ACTUALIZANDO LOS DATOS
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Actualizar_Datos_User_M", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Id_Us", Id_user1);
                cmd.Parameters.AddWithValue("@Username", Username_P);
                cmd.Parameters.AddWithValue("@Contra", Contraseña_P);
                cmd.Parameters.AddWithValue("@Pre_seg", PreguntaP);
                cmd.Parameters.AddWithValue("@Res_seg", RespuestaP);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                noti.EnabledNoti = true;
               
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Pregunta_Seguridad_Username()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PREGUNTA_SEGURIDAD_USER", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Userna", Username_P);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();

                //private int Estado;
                // private string Ocupacion;

                while (rd.Read())
                {
                    PreguntaP = rd.GetString(0);

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

        private void Recuperar_Contraseña(UIDC.UI_Notification noti)
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_RECUPERAR_CONTRASEÑA_LOGIN_USER", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Username", Username_P);
                cmd.Parameters.AddWithValue("@Nueva_Contra", Contraseña_P);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                //ENVIAR UN MENSAJEBOX PERSONALIZADO
                noti.EnabledNoti = true;
            }
            catch (Exception n)
            {
                MessageBox.Show("ERROR= " + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int verificar_pregunta_respuesta()
        {
            int ver = 0;
            SqlCommand cmd = new SqlCommand("SP_PREGUNTA_RESPUESTA_USUARIO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@Pre", PreguntaP);
            cmd.Parameters.AddWithValue("@Res", RespuestaP);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { ver = 1; }

            //Cerrar conexion
            conexion.abrirCerrarConexion();
            return ver;
        }
    }
}
