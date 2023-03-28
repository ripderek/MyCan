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
    public partial class frm_MC_Crear_Modificar_Cliente : Form
    {
        int ac;
    
        public frm_MC_Crear_Modificar_Cliente(int mc=0, string ced="")
        {          
            InitializeComponent();
            ac = mc;
            if (ac == 0) // CREAR 
            {
                txtCelular.MaxLength = 10;
                txtIdentifacion.Enabled = false;
                lblModificar.Visible = false;
                lblCrear.Visible = true;
                lblCrear.BringToFront();
                btnEliminar.Visible = false; btnEliminar.Enabled = false;
                lblEstado.Visible = false; cmb_Estado.Visible = false; cmb_Estado.Enabled = false;
            }
            else //MODIFICAR
            {
                lblCrear.Visible = false; lblModificar.Visible = true; lblModificar.BringToFront();
                btnEliminar.Visible = true; btnEliminar.Enabled = true;
                lblEstado.Visible = true; cmb_Estado.Visible = true; cmb_Estado.Enabled = true;
                csClientes objCliente = new csClientes(ced);
                txtNombre.Text = objCliente.Nombre_Persona;
                txtApellidos.Text = objCliente.Apellido_Persona;
                cmbIdentificacion.SelectedItem = objCliente.T_Identi_Persona;
                txtIdentifacion.Text = objCliente.Identificacion_Persona;
                txtCelular.Text = objCliente.Celular_Persona;
                txtDireccion.Text = objCliente.Direccion_Persona;
                cmbOcupacion.SelectedItem = objCliente.Ocupacion_C;
                if (objCliente.Estado_E == 1)
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
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csClientes objcliente;

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

            csValidarCampos valida4 = new csValidarCampos();
            valida4.tamaño(txtCelular, 10);
            int comprobrar4 = valida4.comprobartamaño;

            csValidarCampos valida5 = new csValidarCampos();
            valida5.TextBoxVacios(txtDireccion, "Dirección");
            int comprobrar5 = valida5.comprobar;

            csValidarCampos valida6 = new csValidarCampos();
            valida6.TextBoxPrecio(txtIdentifacion, "Identificacion");
            int comprobrar6 = valida6.comprobarprecio;

            csValidarCampos valida7 = new csValidarCampos();
            valida7.TextBoxPrecio(txtCelular, "Telefono");
            int comprobrar7 = valida7.comprobarprecio;

            if (ac == 0) //Crear
            {

                if (comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && cmbIdentificacion.SelectedItem != null && cmbOcupacion.SelectedItem != null)
                {
                   
                    new csClientes(txtNombre.Text, txtApellidos.Text, cmbIdentificacion.SelectedItem.ToString(), txtIdentifacion.Text, txtCelular.Text, txtDireccion.Text, cmbOcupacion.SelectedItem.ToString());
                    notifi_agregar.Text = txtNombre.Text;
                    notifi_agregar.EnabledNoti = true;

                    this.Close();
                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }

            }
            else   // Modificar
            {

                if (comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && cmbIdentificacion.SelectedItem != null && cmbOcupacion.SelectedItem != null && cmb_Estado.SelectedItem != null)
                {
                    int Estado;
                    if (cmb_Estado.SelectedItem == "Activo")
                        Estado = 1;
                    else
                        Estado = 0;

                    new csClientes(txtNombre.Text, txtApellidos.Text, cmbIdentificacion.SelectedItem.ToString(), txtIdentifacion.Text, txtCelular.Text, txtDireccion.Text, cmbOcupacion.SelectedItem.ToString(), Estado , 1);

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
