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
    public partial class frm_MC_Modificar_CrearProveedor : Form
    {
        int ac;
        int Id_P;
        public frm_MC_Modificar_CrearProveedor(int accion,string ced="")
        {
            ac = accion;
            InitializeComponent();
            if (accion == 1)   // Modificar
            {

                txtCelular.MaxLength = 10;
                lblCrear.Visible = false;
                lblModificar.Visible = true;
                lblModificar.BringToFront();
                lblEstado.Visible = true;
                cmb_Estado.Visible = true;
                csProveedor objPro = new csProveedor(ced);
                Id_P = objPro.ID;
                txtNombre.Text = objPro.Nombre_Persona;
                txtApellidos.Text = objPro.Apellido_Persona;
                cmbIdentificacion.SelectedItem=objPro.T_Identi_Persona;
                txtIdentifacion.Text = objPro.Identificacion_Persona;
                txtCelular.Text = objPro.Celular_Persona;
                txtSucursal.Text = objPro.Sucursal.ToString();
                txtDireccion.Text = objPro.Direccion_Persona;
                txtCompañia.Text = objPro.NombreCom;
                if (objPro.Estado_P == 1)
                    cmb_Estado.SelectedItem = "Activo";
                else
                    cmb_Estado.SelectedItem = "Inactivo";

                if (cmbIdentificacion.SelectedItem == "Cedula")
                {
                    txtIdentifacion.MaxLength = 10;
                }
                else if (cmbIdentificacion.SelectedItem == "Pasaporte")
                {
                    txtIdentifacion.MaxLength = 10;
                }
                else if (cmbIdentificacion.SelectedItem == "Ruc")
                {
                    txtIdentifacion.MaxLength = 13;
                }
            }
            else  // Crear
            {
                txtIdentifacion.Enabled = false;
                txtCelular.MaxLength = 10;
                btnEliminar.Visible = false; btnEliminar.Enabled = false;
                lblCrear.Visible = true;
                lblCrear.BringToFront();
            }
        }

        private void lblModificar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //si accion= 1 entonces modificar de lo contrario crear
            csProveedor proveedor ;

            int cantidad = 0;

                if (cmbIdentificacion.SelectedItem == "Cedula")
                {
                    cantidad = 10;
                }
                else if (cmbIdentificacion.SelectedItem == "Pasaporte")
                {
                    cantidad = 10;
                }
                else if (cmbIdentificacion.SelectedItem == "Ruc")
                {
                    cantidad = 13;
                }

            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");
            int comprobrar = valida.comprobar;

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxVacios(txtApellidos, "Apellidos");
            int comprobrar2 = valida2.comprobar;

            csValidarCampos valida3 = new csValidarCampos();
            valida3.tamaño(txtIdentifacion, cantidad);
            int comprobrar3 = valida3.comprobartamaño;

            csValidarCampos valida7 = new csValidarCampos();
            valida7.TextBoxPrecio(txtIdentifacion, "Identificacion");
            int comprobrar7 = valida7.comprobarprecio;

            csValidarCampos valida4 = new csValidarCampos();
            valida4.tamaño(txtCelular, 10);
            int comprobrar4 = valida4.comprobartamaño;

            csValidarCampos valida8 = new csValidarCampos();
            valida8.TextBoxPrecio(txtCelular, "Telefono");
            int comprobrar8 = valida8.comprobarprecio;

            csValidarCampos valida5 = new csValidarCampos();
            valida5.TextBoxVacios(txtDireccion, "Dirección");
            int comprobrar5 = valida5.comprobar;

            csValidarCampos valida6 = new csValidarCampos();
            valida6.TextBoxPrecio(txtSucursal, "Sucursal");
            int comprobrar6 = valida6.comprobarprecio;

            csValidarCampos valida9 = new csValidarCampos();
            valida9.TextBoxVacios(txtCompañia, "Compañia");


            if (ac == 1)     // Modificar
            {
                if (valida9.comprobar == 1 &&comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && comprobrar8 == 1 && cmbIdentificacion.SelectedItem != null && cmb_Estado.SelectedItem != null)
                {
                    int es = 0;
                    if (cmb_Estado.SelectedItem == "Activo")
                        es = 1;
                    new csProveedor(Id_P, txtNombre.Text, txtApellidos.Text, cmbIdentificacion.SelectedItem.ToString(), txtIdentifacion.Text, txtCelular.Text, txtDireccion.Text, int.Parse(txtSucursal.Text), es,txtCompañia.Text);

                    this.Close();
                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }
            }
            else           // Crear
            {

                if (valida9.comprobar == 1 && comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && comprobrar8 == 1 && cmbIdentificacion.SelectedItem != null)
                {
                    new csProveedor(txtNombre.Text, txtApellidos.Text, cmbIdentificacion.SelectedItem.ToString(), txtIdentifacion.Text, txtCelular.Text, txtDireccion.Text, int.Parse(txtSucursal.Text),txtCompañia.Text);

                    this.Close();
                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }

            }
        }


        //Evento del combox de identificacion cuando selecciona algo
        // Aqui pongo el maximo de numeros permitidos segun el tipo
        private void cmbIdentificacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIdentifacion.Text = null;
            txtIdentifacion.Enabled = true;
            if (cmbIdentificacion.SelectedItem == "Cedula")
            {
                txtIdentifacion.MaxLength = 10;
            }
            else if (cmbIdentificacion.SelectedItem == "Pasaporte")
            {
                txtIdentifacion.MaxLength = 10;
            }
            else if (cmbIdentificacion.SelectedItem == "Ruc")
            {
                txtIdentifacion.MaxLength = 13;
            }
        }
    }
}
