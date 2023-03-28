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
    public partial class MC_CrearUsuario : Form
    {
        cConexion conexion = new cConexion();
        csEmpleado objEmpleado = new csEmpleado();
        int ac;
        public MC_CrearUsuario(int primera = 0)
        {
            ac = primera;
            InitializeComponent();
            conexion.LeerConfig();
            int pasar = conexion.Pasar;
            if (primera == 0 && pasar == 2) //LISTAR SOLO EL PROPIETARIO BLOQUEAR Y BLOQUEAR EL BOTON DE ROLES
            {
            

               cmbUsuario.DataSource = objEmpleado.ListarEmpleadosCMB().Tables[0];
                cmbUsuario.ValueMember = "Id";
                cmbUsuario.DisplayMember = "Iden";
                cmbUsuario.SelectedItem = 1;            
                cmbUsuario.Enabled = false;                
            }
            else if(primera==1) //CREACION DE USUARIO DESDE CONFIGURACION
            {
                cmbUsuario.DataSource = objEmpleado.ListarEmpleadosCMB().Tables[0];
                cmbUsuario.ValueMember = "Id";
                cmbUsuario.DisplayMember = "Iden";
                cmbUsuario.SelectedItem = null;
                uI_DragForm1.Enabled = false;
            }
            else 
            {
                this.Close();          
            }
        }

        private void uI_ShadowPanel6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ac == 1) //Crear Usuario desde la configuracion
                {
                    if (txtPassword.Text != txtPassword1.Text)
                    {
                        MessageBox.Show("Contraseña no conincide ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        csValidarCampos valida5 = new csValidarCampos();
                        valida5.TextBoxVacios(txtUserName, "UserName");
                        int comprobrar5 = valida5.comprobar;

                        csValidarCampos valida6 = new csValidarCampos();
                        valida6.TextBoxVacios(txtPassword, "Contraseña");
                        int comprobrar6 = valida6.comprobar;

                        csValidarCampos valida7 = new csValidarCampos();
                        valida7.TextBoxVacios(txtPassword1, "Contraseña 2");
                        int comprobrar7 = valida7.comprobar;

                        csValidarCampos valida8 = new csValidarCampos();
                        valida8.TextBoxVacios(txtRespuesta, "Respuesta");
                        int comprobrar8 = valida8.comprobar;

                        if (comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && comprobrar8 == 1 && cmbUsuario.SelectedItem != null && cmbPregunta.SelectedItem != null)
                        {

                            csUsuarios objUser = new csUsuarios(int.Parse(cmbUsuario.SelectedValue.ToString()), txtUserName.Text, txtPassword.Text, cmbPregunta.SelectedItem.ToString(), txtRespuesta.Text, true);
                            if (objUser.VEUser != 1)
                            {
                                notifi_agregar.TitleText = "Usuario Creado";
                                notifi_agregar.Text = "Bienvenido " + txtUserName.Text;
                                notifi_agregar.EnabledNoti = true;
                            }
                        }
                        else
                        {
                            MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                            ms2.ShowDialog();
                        }
                    }
                   

                }
                else   // Crear usuario desde el programa
                {
                    if (txtPassword.Text != txtPassword1.Text)
                    {
                        MessageBox.Show("Contraseña no conincide " ,"Error" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation );
                    }
                    else
                    {

                        csValidarCampos valida = new csValidarCampos();
                        valida.TextBoxVacios(txtUserName, "UserName");
                        int comprobrar = valida.comprobar;

                        csValidarCampos valida2 = new csValidarCampos();
                        valida2.TextBoxVacios(txtPassword, "Contraseña");
                        int comprobrar2 = valida2.comprobar;

                        csValidarCampos valida3 = new csValidarCampos();
                        valida3.TextBoxVacios(txtPassword1, "Contraseña 2");
                        int comprobrar3 = valida3.comprobar;

                        csValidarCampos valida4 = new csValidarCampos();
                        valida4.TextBoxVacios(txtRespuesta, "Respuesta");
                        int comprobrar4 = valida4.comprobar;

                        if (comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && cmbUsuario.SelectedItem != null && cmbPregunta.SelectedItem != null)
                        {
                            conexion.EscribirConfig("3");
                            csUsuarios objUser = new csUsuarios(int.Parse(cmbUsuario.SelectedValue.ToString()), txtUserName.Text, txtPassword.Text, cmbPregunta.SelectedItem.ToString(), txtRespuesta.Text);
                            notifi_agregar.TitleText = "Usuario Creado";
                            notifi_agregar.Text = "Bienvenido " + txtUserName.Text;
                            notifi_agregar.EnabledNoti = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                            ms2.ShowDialog();
                        }
                    }
                   
                }
            }
            catch(Exception ne)
            {
                MessageBox.Show(ne.Message);
            }


        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            btnVer_Contra.Visible= false;
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
                btnVer_Contra1.Visible = true; btnVer_Contra.BringToFront();
            }
        }

        private void btnNo_Ver_Contra1_Click(object sender, EventArgs e)
        {
            btnVer_Contra1.Visible = true; btnVer_Contra.BringToFront();
            txtPassword1.UseSystemPasswordChar = true;
        }

        private void btnVer_Contra1_Click(object sender, EventArgs e)
        {
            btnNo_Ver_Contra1.Visible = true; btnNo_Ver_Contra.BringToFront();
            btnVer_Contra1.Visible = false;
            txtPassword1.UseSystemPasswordChar = false;
        }
    }
}
