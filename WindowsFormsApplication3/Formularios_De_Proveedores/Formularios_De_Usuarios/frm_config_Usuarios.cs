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
    public partial class frm_config_Usuarios : Form
    {
        string ce;
        string ap;
        int id_x;

        int tipoFor = 0;

        public frm_config_Usuarios(string ced_user, string apellid_user, int id_user)
        {
            ce = ced_user; ap = apellid_user; id_x = id_user;
            InitializeComponent();
            AbrirFormulario(new fmr_MisDatos_Usuario(ced_user,apellid_user,id_user));
            tipoFor = 0;
        }

        public frm_config_Usuarios(int tipo)
        {
            InitializeComponent();
            tipoFor = tipo;
            AbrirFormulario(new frmDatos_Veterinaria());
            panel_op2.Visible = false;
            panel_op2.Enabled = false;
            panel_op4.Visible = false;
            panel_op4.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
     
        private void frm_config_Usuarios_Load(object sender, EventArgs e)
        {
            paneltransparente(panel_menu);
            paneltransparente(panel_op1);
            panel_op1.BringToFront();
            paneltransparente(panel_op2);
            panel_op2.BringToFront();
            paneltransparente(panel_op3);
            panel_op3.BringToFront();
            paneltransparente(panel_op4);
            panel_op4.BringToFront();
            paneltransparente(panel_opInicio);
            panel_opInicio.BringToFront();
        }

        private void paneltransparente(Panel nepanel,int c =100)
        {
            var posi = this.PointToScreen(nepanel.Location);
            posi = pic_fondo_menu.PointToClient(posi);
            nepanel.Parent = pic_fondo_menu;
            nepanel.Location = posi;
            nepanel.BackColor = Color.FromArgb(c, 0, 0, 0);
        }

        private void panel_op1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_op1_MouseEnter(object sender, EventArgs e)
        {
            paneltransparente(panel_op1,30);
        }
        private void panel_op1_MouseLeave(object sender, EventArgs e)
        {
            paneltransparente(panel_op1);
        }

        private void panel_op2_MouseEnter(object sender, EventArgs e)
        {
            paneltransparente(panel_op2, 30);
        }

        private void panel_op2_MouseLeave(object sender, EventArgs e)
        {
            paneltransparente(panel_op2);
        }

        private void panel_op3_MouseEnter(object sender, EventArgs e)
        {
            paneltransparente(panel_op3, 30);
        }

        private void panel_op3_MouseLeave(object sender, EventArgs e)
        {
            paneltransparente(panel_op3);
        }

        private void panel_op4_MouseEnter(object sender, EventArgs e)
        {
            paneltransparente(panel_op4, 30);
        }

        private void panel_op4_MouseLeave(object sender, EventArgs e)
        {
            paneltransparente(panel_op4);
        }

        private void panel_op2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MC_CrearUsuario(1));
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
            panel_vista.Controls.Add(nuevoFormulario);
            panel_vista.Tag = nuevoFormulario;
            // nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }

        private void panel_op4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_MC_Permisos_Usuarios());
        }

        private void panel1_Click(object sender, EventArgs e)
        {

            if (tipoFor == 1)
            {
                AbrirFormulario(new frmDatos_Veterinaria());
            }
            else
            {
                AbrirFormulario(new fmr_MisDatos_Usuario(ce, ap, id_x));
            }
        }

        private void panel_opInicio_MouseEnter(object sender, EventArgs e)
        {
            paneltransparente(panel_opInicio, 30);
        }

        private void panel_opInicio_MouseLeave(object sender, EventArgs e)
        {
            paneltransparente(panel_opInicio);
        }

        private void panel_op3_Click(object sender, EventArgs e)
        {
            if (tipoFor == 1)
            {
                AbrirFormulario(new frmModificar_Veterinaria());
            }
            else
            {
                AbrirFormulario(new frm_Editar_Usuario(0));
            }
        }
    }
}
