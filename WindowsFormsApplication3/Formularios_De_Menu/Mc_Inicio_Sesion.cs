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
    public partial class Mc_Inicio_Sesion : Form
    {
        int fila;
        int posicion;
        string ur;
        public Mc_Inicio_Sesion()
        {
          
            InitializeComponent();
            cConexion conexion = new cConexion();
            conexion.LeerConfig();
            int verficar = conexion.Pasar;
            if (verficar == 0)
            {
                MC_Iniciador incio = new MC_Iniciador();
                incio.ShowDialog();
            }
            else if (verficar==1)
            {
                MC_Iniciador2 inicio2 = new MC_Iniciador2();
                inicio2.ShowDialog();
            }
            else if (verficar == 2)
            {
                MC_CrearUsuario UsuarioAdmin = new MC_CrearUsuario();
                UsuarioAdmin.ShowDialog();
            }
        }



        private void uI_PictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void uI_ShadowPanel6_Click(object sender, EventArgs e)
        {
            csUsuarios objUser = new csUsuarios(txtUsuario.Text,txtContraseña.Text);
            if (objUser.VUser == 1)
            {
                csUsuarios objuser2 = new csUsuarios(txtUsuario.Text);
                notificacion.TitleText="Bienvenido a MyCan";
                notificacion.Text = objuser2.Apellido_Persona;
                notificacion.EnabledNoti = true;    
                MenuPrincipal menu = new MenuPrincipal(objuser2.Identificacion_Persona,objuser2.Apellido_Persona,objuser2.ID,txtUsuario.Text,objuser2.Id_user1);
                menu.Show();
                this.Close();
            }
            else
            {
                MessaggeBox_Usuario_Incorrecto usericon = new MessaggeBox_Usuario_Incorrecto();
                usericon.ShowDialog();
                //panel_Titulo.UIBottomLeft = Color.FromArgb();
                panel_Titulo.UIBottomRight = Color.FromName("Coral");
                panel_Titulo.UIBottomLeft = Color.FromArgb(255, 131, 123);
                uI_ShadowPanel6.BaseColor = Color.FromArgb(255, 131, 123);
                mican_error_pic.Visible = true; mican_error_pic.BringToFront();
                animacion.Visible = false; 
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }


        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("sd");
                   
        }


        private void Mc_Inicio_Sesion_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                BtnVer_Contra.Visible = false;
                btnNo_Ver_Contra.Visible = false;
            }
           
            else
            {
                BtnVer_Contra.Visible = true; BtnVer_Contra.BringToFront();
            }
        }

        private void BtnVer_Contra_Click(object sender, EventArgs e)
        {
            btnNo_Ver_Contra.Visible = true; btnNo_Ver_Contra.BringToFront();
            BtnVer_Contra.Visible = false;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnNo_Ver_Contra_Click(object sender, EventArgs e)
        {
            BtnVer_Contra.Visible = true; BtnVer_Contra.BringToFront();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frm_Editar_Usuario editarUSER = new frm_Editar_Usuario(2);
            editarUSER.Show();
        }

        private void panel_proveedores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    panel_usuarios.Visible = false;
                }
                else if (txtUsuario.Text == ur)
                {
                    panel_usuarios.Visible = false;
                }
                else
                {
                    panel_usuarios.Visible = true;
                    csUsernmanes userssss = new csUsernmanes();
                    userssss.Palabra_Clave = txtUsuario.Text;
                    dtgvUusarios.DataSource = userssss.listarpro();
                    if (dtgvUusarios.RowCount != 0)
                        ur = (dtgvUusarios[0, posicion].Value.ToString());
                    else
                        panel_usuarios.Visible = false;
                }
            }
            catch(Exception ne )
            {}
        }

        private void dtgvUusarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //SE INTRODUCE EL USUARIO QUE SE DA CLICK EN EL DATAGRIDVIEW


            posicion = dtgvUusarios.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            txtUsuario.Text = (dtgvUusarios[0, posicion].Value.ToString());
           
            panel_usuarios.Visible = false;
        }

        int cont=10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont =cont- 1;
            if (cont == 0)
                animacion.Enabled = false;
        }

        private void uI_ShadowPanel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uI_ShadowPanel4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // frm_Ver_Comprobante_Recepcion cc = new frm_Ver_Comprobante_Recepcion();
           // cc.Show();
           // frm_FACTURA_ELECTRONICAXD xd = new frm_FACTURA_ELECTRONICAXD();
           // xd.Show();
          //  frm_Ver_Historia_01 historia = new frm_Ver_Historia_01(1);
            //historia.Show();
          //  frm_Historia_Clinica_Nueva ue = new frm_Historia_Clinica_Nueva();
           // ue.Show();
         //   frm_Ver_Registrar_Historial_Clinico fd = new frm_Ver_Registrar_Historial_Clinico();
          //  fd.Show();
           // frm_VER_HISTORIA his = new frm_VER_HISTORIA();
           // his.Show();
            
        }
    }
}
