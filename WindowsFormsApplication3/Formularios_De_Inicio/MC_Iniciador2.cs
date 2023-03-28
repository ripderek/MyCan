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
    public partial class MC_Iniciador2 : Form
    {
        cConexion conexion = new cConexion();

        public MC_Iniciador2()
        {
            InitializeComponent();
            conexion.LeerConfig();
            int pasar = conexion.Pasar;
            if (pasar == 2)
            {
                this.Visible = false;
                this.Close();
                MC_CrearUsuario useradmin = new MC_CrearUsuario(0);
                useradmin.ShowDialog();
            }



        }

        private void uI_ShadowPanel6_Click(object sender, EventArgs e)
        {
            //VALIDAR QUE SE SELECCIONE ALGO DEL COMBOBOX Y SEGUN LO ELIJIDO SEA EL TAMANAÑO ACEPTADO PARA LA IDENTIFICACION Y VALIDAR NUEVOS CAMPOS
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");
            int comprobar = valida.comprobar;


            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxPrecio(txtIdentificacion, "Identificacion");
            int comprobar2 = valida2.comprobarprecio;

            csValidarCampos valida3 = new csValidarCampos();
            valida3.TextBoxPrecio(txtCelular, "Celular");
            int comprobar3 = valida3.comprobarprecio;

            if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1)
            {
                conexion.EscribirConfig("2");


                //SE CREA EL OBEJTO EMPLEADO QUE HEREDA DE PERSONA Y ASU VEZ INGRESA DATOS EN PERSONA Y LUEGO EN EMPLEADO

                csEmpleado objEmpleado = new csEmpleado(txtNombre.Text, txtApellidos.Text, cmbIdentifiacion.SelectedItem.ToString(), txtIdentificacion.Text,
txtCelular.Text, txtDireccion.Text, cmbTipo.SelectedItem.ToString(), cmbArea.SelectedItem.ToString(),int.Parse(txtOficina.Text), ms.GetBuffer());

                this.Visible = false;
                this.Close();
                MC_CrearUsuario useradmin = new MC_CrearUsuario();
                useradmin.ShowDialog();

            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }



        }

        private void uI_ShadowPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MC_Iniciador2_Load(object sender, EventArgs e)
        {

        }

        private void uI_ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uI_ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uI_TextBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void uI_TextBox1_Click(object sender, EventArgs e)
        {

        }

        private void uI_ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uI_ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uI_TextBox3_Click(object sender, EventArgs e)
        {

        }

        private void uI_TextBox4_Click(object sender, EventArgs e)
        {

        }

        private void MC_Iniciador2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fo = new OpenFileDialog();
            DialogResult Rs = Fo.ShowDialog();
            if (Rs == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(Fo.FileName);

            }
        }
    }
}
