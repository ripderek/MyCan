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
    public partial class frm_Configuracion : Form
    {
        string ce;
        string ap;
        int id_x;
        public frm_Configuracion(string ced_user, string apellid_user, int id_user)
        {
            ce = ced_user; ap = apellid_user; id_x = id_user;
            InitializeComponent();
            txtApellidos_user.Text = apellid_user;
            csEmpleado objemple = new csEmpleado(ced_user);
            txtNombres_User.Text = objemple.Nombre_Persona;
            pic_foto_user.Image = System.Drawing.Bitmap.FromStream(objemple.ms);
        }


        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_config_Usuarios(ce,ap,id_x));      
        }

        private void btnDatosVeterinaria_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_config_Usuarios(1));
        }


        private Form formularioActivo = null;
        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            panel_nuevo_config.Controls.Add(nuevoFormulario);
            panel_nuevo_config.Tag = nuevoFormulario;
            
            // nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }

        private void btn_Usuarios_MouseEnter(object sender, EventArgs e)
        {
            btn_Usuarios.BaseColor = Color.FromArgb(244, 248, 251);
            lbldescripcionusarios.BackColor = Color.FromArgb(244, 248, 251);
            lblUsuariosop.BackColor = Color.FromArgb(244, 248, 251);
            pic_btn_usuario1.BackColor = Color.FromArgb(244, 248, 251);
        }

        private void btn_Usuarios_MouseLeave(object sender, EventArgs e)
        {
            btn_Usuarios.BaseColor = Color.FromArgb(227, 237, 249);
            lbldescripcionusarios.BackColor = Color.FromArgb(227, 237, 249);
            lblUsuariosop.BackColor = Color.FromArgb(227, 237, 249);
            pic_btn_usuario1.BackColor = Color.FromArgb(227, 237, 249);
        }


    }
}
