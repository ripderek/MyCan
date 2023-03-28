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
    public partial class frmCrear_Modiciar_Medicamento : Form
    {
        int ac;
        int medica;
        public frmCrear_Modiciar_Medicamento(int medicamento_id=0,string nombre="", string precio_venta="", string descipcion="", int categoria=0, int estado=0 ,int accion=0)
        {
            InitializeComponent();
            ac = accion;
            medica = medicamento_id;
            csCategoriasProductos cat = new csCategoriasProductos();
            cmbCategoria.DataSource = cat.CategoriaCombobox().Tables[0];
            cmbCategoria.ValueMember = "Categoria_ID";
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.SelectedItem = null;
            if (accion == 0)
            {
                //CREAR
            }
            else //MODIFICAR 
            { 
                txtNombre.Text=nombre;
                char[] delimitador = { ',' };
                string[] precio_venta_separado = precio_venta.Split(delimitador);
                for (int j = 0; j < precio_venta_separado.Length; j++)
                {
                    txtPrecioV1.Text = precio_venta_separado[j];
                    j++;
                    txtPrecioV2.Text = precio_venta_separado[j];
                }
                txtDescipcion.Text = descipcion;
                cmbCategoria.SelectedValue = categoria;
                if(estado==1)
                    cmb_Estado.SelectedItem = "Activo";
                else
                    cmb_Estado.SelectedItem = "Inactivo";
                cmb_Estado.Visible = true;
                lblEstado.Visible = true;

            }
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegistrar_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxVacios(txtDescipcion, "Descripcion");

            csValidarCampos valida4 = new csValidarCampos();
            valida4.TextBoxVacios(txtPrecioV1, "PrecioV1");

            csValidarCampos valida5 = new csValidarCampos();
            valida5.TextBoxVacios(txtPrecioV2, "PrecioV2");

            csValidarCampos valida6 = new csValidarCampos();
            valida6.TextBoxPrecio(txtPrecioV1, "PrecioV1");

            csValidarCampos valida7 = new csValidarCampos();
            valida7.TextBoxPrecio(txtPrecioV2, "PrecioV2");


            //GUARDAR EL MEDICAMENTO 
            if (ac == 0) //CREAR
            {
                if (valida.comprobar == 1 && valida2.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 && cmbCategoria.SelectedItem != null)
                {

                    if (txtPrecioV1.Text == "00" && txtPrecioV2.Text == "00" || txtPrecioV1.Text == "0" || txtPrecioV2.Text == "0")
                    {
                        MessageBox.Show("EL PRECIO NO PUEDE SER 0", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        decimal precio = decimal.Parse(txtPrecioV1.Text + "," + txtPrecioV2.Text);
                        csMedicamentos crearM = new csMedicamentos(txtNombre.Text, decimal.Parse(txtPrecioV1.Text + "," + txtPrecioV2.Text), txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()));
                        if (crearM.Verificar == 1)
                        {
                            notifica.EnabledNoti = true;
                            txtNombre.Text = ""; txtDescipcion.Text = ""; txtPrecioV1.Text = "00"; txtPrecioV2.Text = "00";
                        }
                    }
                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }

            }
            else //MODIFICAR 
            {
                if (valida.comprobar == 1 && valida2.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 && cmbCategoria.SelectedItem != null && cmb_Estado.SelectedItem != null)
                {
                    if (txtPrecioV1.Text == "00" && txtPrecioV2.Text == "00" || txtPrecioV1.Text == "0" || txtPrecioV2.Text == "0")
                    {
                        MessageBox.Show("EL PRECIO NO PUEDE SER 0", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        int estado = 0;
                        if (cmb_Estado.SelectedItem == "Activo")
                            estado = 1;

                        csMedicamentos crearM = new csMedicamentos(txtNombre.Text, decimal.Parse(txtPrecioV1.Text + "," + txtPrecioV2.Text), txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()), estado, medica);
                        if (crearM.Verificar == 1)
                        {
                            notifica.EnabledNoti = true;
                            txtNombre.Text = ""; txtDescipcion.Text = ""; txtPrecioV1.Text = "00"; txtPrecioV2.Text = "00";
                        }
                    }
                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }


            }
        }
    }
}
