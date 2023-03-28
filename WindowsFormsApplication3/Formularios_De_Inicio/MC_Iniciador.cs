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
    public partial class MC_Iniciador : Form
    {
        cConexion conexion = new cConexion();
      
        public MC_Iniciador()
        {
            InitializeComponent();
            conexion.LeerConfig();
            int pasar = conexion.Pasar;
            if (pasar >= 1)
            {
                this.Visible = false;
                this.Close();
                MC_Iniciador2 pas2 = new MC_Iniciador2();
                //pas2.Show();
                pas2.ShowDialog();
              

            }
        }

        private void uI_TextBox1_Click(object sender, EventArgs e)
        {

        }

        private void uI_ShadowPanel6_Click(object sender, EventArgs e)
        {
            //VALIDAR QUE RUC TENGA 13 CARACTERES Y VALIDAR EL NUMERO DE SUCURSAL

            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre,"Nombre");
            int comprobar = valida.comprobar;

            csValidarCampos valida1 = new csValidarCampos();
            valida1.TextBoxVacios(txtDireccion,"Direccion");
            int comprobar1 = valida1.comprobar;

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxPrecio(txtRuc,"Ruc");
            int comprobar2 = valida2.comprobarprecio;

            csValidarCampos valida3 = new csValidarCampos();
            valida3.TextBoxPrecio(txtCelular,"Celular");
            int comprobar3 = valida3.comprobarprecio;

            csValidarCampos valida4 = new csValidarCampos();
            valida4.TextBoxVacios(txtNumeroSucursal,"Sucursal");
            int comprobar4 = valida4.comprobar;

            if (comprobar == 1 && comprobar1 == 1 && comprobar2 == 1 && comprobar3 == 1 && comprobar4 == 1)
            {
            
               conexion.EscribirConfig("1");

                //SE GUARDA LOS DATOS EN LA BASE DE DATOS
               csVeterinaria Veterinaria = new csVeterinaria(txtNombre.Text,txtDireccion.Text,txtRuc.Text,txtCelular.Text,txtNumeroSucursal.Text);
               this.Visible = false;
               this.Close();
                MC_Iniciador2 pas2 = new MC_Iniciador2();
                pas2.ShowDialog();
                
                
            }
            else
            {
                MessageBox_Campos_Vacios vacio = new MessageBox_Campos_Vacios();
                vacio.ShowDialog();
            }      
        }

        private void uI_PictureBox2_Click(object sender, EventArgs e)
        {
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void uI_ShadowPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MC_Iniciador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
