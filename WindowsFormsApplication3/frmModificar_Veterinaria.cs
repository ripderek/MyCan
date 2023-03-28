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
    public partial class frmModificar_Veterinaria : Form
    {
        public frmModificar_Veterinaria()
        {
            InitializeComponent();
        }

        private void frmModificar_Veterinaria_Load(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxVacios(txtDireccion, "Direccion");

            csValidarCampos valida3 = new csValidarCampos();
            valida3.TextBoxVacios(txtRuc, "RUC");

            csValidarCampos valida4 = new csValidarCampos();
            valida4.tamaño(txtRuc, 13);

            csValidarCampos valida5 = new csValidarCampos();
            valida5.TextBoxPrecio(txtRuc, "RUC");

            csValidarCampos valida6 = new csValidarCampos();
            valida6.TextBoxVacios(txtCelular, "Celular");

            csValidarCampos valida7 = new csValidarCampos();
            valida7.tamaño(txtCelular, 10);

            csValidarCampos valida8 = new csValidarCampos();
            valida8.TextBoxPrecio(txtCelular, "Celular");

            csValidarCampos valida9 = new csValidarCampos();
            valida9.TextBoxVacios(txtNumeroSucursal, "Numero Sucursal");

            if (valida.comprobar == 1 && valida2.comprobar == 1 && valida3.comprobar == 1 && valida4.comprobartamaño == 1 && valida5.comprobarprecio == 1 && valida6.comprobar == 1 && valida7.comprobartamaño == 1 && valida8.comprobarprecio == 1 && valida9.comprobar == 1)
            {
                csVeterinaria objVeteModi = new csVeterinaria(txtNombre.Text, txtDireccion.Text, txtRuc.Text, txtCelular.Text, txtNumeroSucursal.Text, 1);
                Imprimir();
            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }
        }


        public void Imprimir()
        {
            csVeterinaria objVete = new csVeterinaria(1);
            txtNombre.Text = objVete.NombreV;
            txtDireccion.Text = objVete.DireccionV;
            txtRuc.Text = objVete.RucV;
            txtCelular.Text = objVete.CelularV;
            txtNumeroSucursal.Text = objVete.NumeroSucursalV;
        }

    }
}
