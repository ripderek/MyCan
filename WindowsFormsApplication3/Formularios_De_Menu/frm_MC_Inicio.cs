using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frm_MC_Inicio : Form
    {
        string usr;
        string ce;
        string ap;
        int id_x;
        int ID_US_;
        int ID_Empleado_user;
        public frm_MC_Inicio(string ced_user, string apellid_user, int id_user,string userr, int ID_USER_)
        {
            ID_US_ = ID_USER_;
            usr = userr;
            ce = ced_user; ap = apellid_user; id_x = id_user;

            InitializeComponent();
            txtApellidos_user.Text = apellid_user;
            csEmpleado objemple = new csEmpleado(ced_user);
            txtNombres_User.Text = objemple.Nombre_Persona;
            txtCedula_User.Text = objemple.Identificacion_Persona;
            pic_foto_user.Image = System.Drawing.Bitmap.FromStream(objemple.ms);
            ID_Empleado_user = objemple.ID_EMPLEADO1;
           
        }

        private void uI_ButtonMaterial1_Click(object sender, EventArgs e) /// PRODUCTOS
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.C_lista1 == 1)
             {
                Personalizacion per = new Personalizacion(new frm_Citas(ID_Empleado_user));
                 csListar_Citas_Inicio obji = new csListar_Citas_Inicio();
                 dtg_Citas.DataSource = obji.listarCitasD();
             }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
        }

        private void uI_ButtonMaterial3_Click(object sender, EventArgs e)
        {
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.Pp_lista1 == 1)
            { Personalizacion per = new Personalizacion(new frm_MC_Proveedores(usr)); }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
        }

        private void btn_ingreso_Mes_Click(object sender, EventArgs e)
        {

        }

        private void uI_ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void uI_ShadowPanel3_Click(object sender, EventArgs e)
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.C_lista1 == 1)
             { Personalizacion per = new Personalizacion(new frmClientes(usr)); }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
        }

        private void uI_ShadowPanel4_Click(object sender, EventArgs e)
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.Pa_Lista1 == 1)
             { Personalizacion per = new Personalizacion(new frm_MC_Paciente(usr)); }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
        }

        private void uI_ShadowPanel2_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores.BaseColor = Color.FromArgb(34, 147, 245);
            lblProveedores.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.BaseColor = Color.White;
            lblProveedores.ForeColor = Color.FromArgb(34, 147, 245);
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.BaseColor = Color.FromArgb(17, 125, 219);
            lblClientes.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BaseColor = Color.White;
            lblClientes.ForeColor = Color.FromArgb(17,125, 219);
        }

        private void btnPacientes_MouseEnter(object sender, EventArgs e)
        {
            btnPacientes.BaseColor = Color.FromArgb(11, 105, 195);
            lblPacientes.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btnPacientes_MouseLeave(object sender, EventArgs e)
        {
            btnPacientes.BaseColor = Color.White;
            lblPacientes.ForeColor = Color.FromArgb(11, 105, 195);
        }

        private void btn_ingreso_diario_MouseEnter(object sender, EventArgs e)
        {
            //btn_ingreso_diario.BackColor = Color.FromArgb(238, 245, 255);
           // btn_ingreso_diario.ForeColor = Color.FromArgb(34, 147, 245);
        }

        private void btn_ingreso_diario_MouseLeave(object sender, EventArgs e)
        {
        
          //  btn_ingreso_diario.BackColor = Color.FromArgb(34, 147, 245);
            //btn_ingreso_diario.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btn_ingreso_Mes_MouseLeave(object sender, EventArgs e)
        {
           // btn_ingreso_Mes.BackColor = Color.FromArgb(17, 125, 219);
            //btn_ingreso_Mes.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btn_ingreso_Mes_MouseEnter(object sender, EventArgs e)
        {
          //  btn_ingreso_Mes.BackColor = Color.FromArgb(238, 245, 255);
            // btn_ingreso_Mes.ForeColor = Color.FromArgb(17, 125, 219);
  
        }

        private void btn_ingreso_Año_MouseEnter(object sender, EventArgs e)
        {
            //  btn_ingreso_Año.BackColor = Color.FromArgb(238, 245, 255);
            // btn_ingreso_Año.ForeColor = Color.FromArgb(11, 105, 195);
        }

        private void btn_ingreso_Año_MouseLeave(object sender, EventArgs e)
        {
            // btn_ingreso_Año.BackColor = Color.FromArgb(11, 105, 195);
            // btn_ingreso_Año.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btnProductosMas_MouseEnter(object sender, EventArgs e)
        {
           // btnProductosMas.BackColor = Color.FromArgb(238, 245, 255);
           // btnProductosMas.ForeColor = Color.FromArgb(11, 105, 195);
        }

        private void btnProductosMas_MouseLeave(object sender, EventArgs e)
        {
           // btnProductosMas.BackColor = Color.FromArgb(11, 105, 195);
          //  btnProductosMas.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btnProximasCitas_MouseEnter(object sender, EventArgs e)
        {
            btnProximasCitas.BackColor = Color.FromArgb(238, 245, 255);
            btnProximasCitas.ForeColor = Color.FromArgb(11, 105, 195);
        }

        private void btnProximasCitas_MouseLeave(object sender, EventArgs e)
        {
            btnProximasCitas.BackColor = Color.FromArgb(11, 105, 195);
            btnProximasCitas.ForeColor = Color.FromArgb(238, 245, 255);
        }

        private void btnProveedores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_op_Especies_razas_Click(object sender, EventArgs e)
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.Er_LAM1 == 1)
             { Personalizacion per = new Personalizacion(new frm_Especies_Razas()); }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
             
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.Citas_agendar1 == 1)
             {
                 Personalizacion per = new Personalizacion(new frm_Agregar_Cita(ID_Empleado_user)); 
                 csListar_Citas_Inicio obji = new csListar_Citas_Inicio();
                 dtg_Citas.DataSource = obji.listarCitasD();
             }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
        }

        private void uI_ShadowPanel3_Click_1(object sender, EventArgs e)
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.His_listar1 == 1)
             {
                 Personalizacion pero = new Personalizacion(new frm_Historia_Clinica());
             }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
             
        }

        private void btn_Ajustes_Usuario_Click(object sender, EventArgs e)
        {
           // AbrirFormulario(new fmr_MisDatos_Usuario(ce, ap, id_x));
            Personalizacion per = new Personalizacion(new fmr_MisDatos_Usuario(ce, ap, ID_US_,false));
        }
        int contador;

        private void frm_MC_Inicio_Load(object sender, EventArgs e)
        {
            csListar_Citas_Inicio obji = new csListar_Citas_Inicio();
            dtg_Citas.DataSource = obji.listarCitasD();
            //AQUI CARGAR UN TIMER PARA QUE APARESCAN LAS NOVEDADES XD 
            contador = 2;
            this.timer1.Enabled = true;

        }

        private void timer_hora_Tick(object sender, EventArgs e)
        {
            csCitas obcjitasnoti = new csCitas();
            //string hora = DateTime.Now.ToString("HH:mm:MM").ToString();
           // string hora =  DateTime.Now.ToLongTimeString();    
            //string Time_Hora_destinada1 = txtHora.Text + ":" + TxtMinutos.Text + ":1.100000";
            string hora = DateTime.Now.ToString("HH:mm:ss.f").ToString();
           
            //11:29:00.0000000    11:29:00.0 000000
            string hor = hora + "000000";
            //label3.Text = hor;
            obcjitasnoti.Cita_Notificacion(hor,notifi_cita);
            obcjitasnoti.Cita_En_Curso(hor);
        }

        private void btnProductosMas_Click(object sender, EventArgs e)
        {
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.Pr_Lista1 == 1)
            {
                Personalizacion pero = new Personalizacion(new frm_MC_Produtos(ID_Empleado_user));
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
        }

        private void uI_ButtonMaterial1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_Categorias());
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevopro = new frmNuevoProducto();
            nuevopro.Show();
        }

        private void btnProductosNUEO_MouseLeave(object sender, EventArgs e)
        {
            btnProductosNUEO.BaseColor = Color.White;
            uI_LabelTransparent4.ForeColor = Color.FromArgb(11, 105, 195);
            pictureBox3.BackColor = Color.White;
        }

        private void btnProductosNUEO_MouseEnter(object sender, EventArgs e)
        {
           

            btnProductosNUEO.BaseColor = Color.FromArgb(11, 105, 195);
            uI_LabelTransparent4.ForeColor = Color.FromArgb(238, 245, 255);
            pictureBox3.BackColor = Color.FromArgb(11, 105, 195);
        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmVACUNAScs());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_Receta_Medica_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmCrearRecetaMedica());
        }

        private void btnJaulas_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmJAULAS());
        }
    }
}
