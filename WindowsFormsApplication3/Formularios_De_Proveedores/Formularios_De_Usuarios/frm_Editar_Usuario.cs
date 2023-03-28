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
    public partial class frm_Editar_Usuario : Form
    {
        int ACCION;
        int ID_USUARIO;
        public frm_Editar_Usuario(int ac, int id_user=0)
        {
            InitializeComponent();
            ACCION = ac; ID_USUARIO = id_user;
            lblID_USER.Text = id_user.ToString();
            if (ac == 1)//EL PRIMER CASO CUANDO SE INGRESA 1 ES PORQUE SE ENVIA EL ID DEL USUARIO Y LO ESTA EDITANDO ÉL MISMO
            {
                //SE DEBE LLENAR DE MANERA AUTOMATICA EL NOMBRE DEL USUARIO Y LA PREGUNTA DE SEGURIDAD
              
            }
            else if (ac == 2) //EL SEGUNDO CASO SE DA CUANDO EL USUARIO DESEA RECUPERAR SU ACCESO PORQUE SE OLVIDÓ DE LA CONTRASEÑA 
            {
                lblID_USER.Text = ACCION.ToString();
                lblTitulo.Text = "Recuperacion de contraseña";
                lblContraseña1.Text = "Contraseña";
                lblContraseña2.Text = "Repita Contraseña";
                cmbPregunta.Visible = false; txtPreguntaS.Visible = true; panel_PreguntaSe.Visible = true; txtPreguntaS.BringToFront(); txtPreguntaS.Enabled = true;
            }
            else //TERCER CASO SI ES 0 ENTONCES UN USARIO ADMINISTRADOR ESTA RECUPERANDO TANTO EL USARIO Y CAMBIANDO LA CONTRASEÑA DE CUALQUIER EMPLEADO
            {
                txtCedulaUser.Visible = true; panel_CedUser.Visible = true; txtCedulaUser.Visible = true; txtCedulaUser.BringToFront();
                txtUserName.ReadOnly = true;
                cmbPregunta.Visible = false; txtPreguntaS.Visible = true; panel_PreguntaSe.Visible = true; txtPreguntaS.BringToFront();
                lblContraseña1.Text = "Nueva Contraseña";
                lblContraseña2.Text = "Repita Contraseña";
                btnCerar.Visible = false;
                lblUsuario.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uI_PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("hola");
            MessageBox_Campos_Vacios vacio = new MessageBox_Campos_Vacios();

            csValidarCampos val = new csValidarCampos();
            val.TextBoxVacios(txtUserName, "");


            csValidarCampos val1 = new csValidarCampos();
            val1.TextBoxVacios(txtPassword, "");


            csValidarCampos val2 = new csValidarCampos();
            val2.TextBoxVacios(txtPassword1, "");

            csValidarCampos val3 = new csValidarCampos();
            val3.TextBoxVacios(textBox1, "");

            if (ACCION == 1)//EL PRIMER CASO CUANDO SE INGRESA 1 ES PORQUE SE ENVIA EL ID DEL USUARIO Y LO ESTA EDITANDO ÉL MISMO
            {
                MessageBox.Show("hola 1");
                if (val.comprobar == 1 && val1.comprobar == 1 &&val2.comprobar==1&&val3.comprobar==1&& cmbPregunta.SelectedItem != null)
                {

                    notificacion.TitleText = "Datos Modificados";
                    notificacion.Text = txtUserName.Text;
                    //int Id_s_, string con_, string user_, string contra1_, string pre_seg_, string respe_seg_
                    csUsuarios objUser = new csUsuarios(ID_USUARIO, txtPassword.Text, txtUserName.Text, txtPassword1.Text, cmbPregunta.SelectedItem.ToString(), textBox1.Text, notificacion);
                }
                else
                    vacio.ShowDialog();
                
            }
            if (ACCION == 2) //RECUPERAR CONTRASEÑA DESDE EL LOGIN 
            {
                MessageBox.Show("hola 2");
                if (val.comprobar == 1 && val1.comprobar == 1 && val2.comprobar == 1 && val3.comprobar == 1&&txtPassword1.Text==txtPassword.Text )
                {

                    //        public csUsuarios(string User_name_, string Nueva_contra_, string respe_s_, string pre_ )
                    notificacion.TitleText = "Contraseña Recuperada";
                    notificacion.Text = txtUserName.Text;
                    csUsuarios objUser = new csUsuarios(txtUserName.Text, txtPassword.Text, textBox1.Text, txtPreguntaS.Text, notificacion);
                }
                else
                    vacio.ShowDialog();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {

            }
            else
            {
                if (ACCION == 2)
                { csUsuarios objuser = new csUsuarios(txtUserName.Text, 1); txtPreguntaS.Text = objuser.PreguntaP; }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnVer_Contra.Visible = false;
                btnNo_Ver_Contra.Visible = false;
            }
            else
            {
                btnVer_Contra.Visible = true; btnVer_Contra.BringToFront();
            }
        }

        private void btnVer_Contra_Click(object sender, EventArgs e)
        {
            btnNo_Ver_Contra.Visible = true; btnNo_Ver_Contra.BringToFront();
            btnVer_Contra.Visible = false;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnNo_Ver_Contra_Click(object sender, EventArgs e)
        {
            btnVer_Contra.Visible = true; btnVer_Contra.BringToFront();
            txtPassword.UseSystemPasswordChar = true;

        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword1.Text))
            {
                btnVer_Contra1.Visible = false;
                btnNo_Ver_Contra1.Visible = false;
            }
            else
            {
                btnVer_Contra1.Visible = true; btnVer_Contra1.BringToFront();
            }
        }

        private void btnNo_Ver_Contra1_Click(object sender, EventArgs e)
        {
            btnVer_Contra1.Visible = true; btnVer_Contra1.BringToFront();
            txtPassword1.UseSystemPasswordChar = true;
        }

        private void btnVer_Contra1_Click(object sender, EventArgs e)
        {
            btnNo_Ver_Contra1.Visible = true; btnNo_Ver_Contra1.BringToFront();
            btnVer_Contra1.Visible = false;
            txtPassword1.UseSystemPasswordChar = false;
        }
    }
}
