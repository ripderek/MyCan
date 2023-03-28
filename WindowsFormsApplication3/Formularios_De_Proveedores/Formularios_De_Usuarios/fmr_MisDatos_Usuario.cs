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
    public partial class fmr_MisDatos_Usuario : Form
    {
        int id_usuario;
        public fmr_MisDatos_Usuario(string ced_user, string apellid_user, int id_user, bool ac = true)
        {
            InitializeComponent();
            id_usuario = id_user;
            csEmpleado objemple = new csEmpleado(ced_user);
            txtNombres_User.Text = objemple.Nombre_Persona;
            txtCedula_User.Text = objemple.Identificacion_Persona;
            lblTipo_Trabajador.Text = objemple.Tipo_E;
            txtApellidos_user.Text = objemple.Apellido_Persona;
            pic_foto_user.Image = System.Drawing.Bitmap.FromStream(objemple.ms);
            if (ac == false) //SI SE INGRESA A ESTE FORMULARIO DESDE EL MENU DE INICIO
            {
                panel_degradado.Visible = true;
                panel_Titulo.Visible = true;
            }
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerar_MouseEnter(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Red;
            btnCerar.ForeColor = Color.Black;
        }
        private void btnCerar_MouseLeave(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Transparent;
            btnCerar.ForeColor = Color.White;
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_MC_Modificar_Crear_Personal(2, txtCedula_User.Text));
        }

        private void btn_Mis_Datos_MouseEnter(object sender, EventArgs e)
        {

            btn_Mis_Datos.BaseColor = Color.FromArgb(244, 248, 251);
            lblMis_Datos.BackColor = Color.FromArgb(244, 248, 251);
            lbldescripcionMisDatos.BackColor = Color.FromArgb(244, 248, 251);
            pic_btn_MisDatos.BackColor = Color.FromArgb(244, 248, 251);
        }

        private void btn_Mis_Datos_MouseLeave(object sender, EventArgs e)
        {
            btn_Mis_Datos.BaseColor = Color.FromArgb(227, 237, 249);
            lblMis_Datos.BackColor = Color.FromArgb(227, 237, 249);
            lbldescripcionMisDatos.BackColor = Color.FromArgb(227, 237, 249);
            pic_btn_MisDatos.BackColor = Color.FromArgb(227, 237, 249);

        }

        private void btn_Datos_Acceso_MouseEnter(object sender, EventArgs e)
        {
            btn_Datos_Acceso.BaseColor = Color.FromArgb(244, 248, 251);
            lblAcceso.BackColor = Color.FromArgb(244, 248, 251);
            lblDescripcionAcceso.BackColor = Color.FromArgb(244, 248, 251);
            pic_btn_Datos_Acceso.BackColor = Color.FromArgb(244, 248, 251);
        }

        private void btn_Datos_Acceso_MouseLeave(object sender, EventArgs e)
        {
            btn_Datos_Acceso.BaseColor = Color.FromArgb(227, 237, 249);
            lblAcceso.BackColor = Color.FromArgb(227, 237, 249);
            lblDescripcionAcceso.BackColor = Color.FromArgb(227, 237, 249);
            pic_btn_Datos_Acceso.BackColor = Color.FromArgb(227, 237, 249);
        }

        private void btn_Datos_Acceso_Click(object sender, EventArgs e)
        {
            Personalizacion objper = new Personalizacion(new frm_Editar_Usuario(1,id_usuario));
        }
    }
}
