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
    public partial class frmServicios_Agregar_Modificar : Form
    {
        int accion;
        int servicio_id;
        public frmServicios_Agregar_Modificar(int ac=0, int servi_id=0, string nom="",string precio="", string descri="", int cat=0, int esta=0)
        {
            accion = ac;
            servicio_id = servi_id;
            InitializeComponent();

            csCategoriasProductos objcat = new csCategoriasProductos();
            cmbCategoria.DataSource = objcat.CategoriaCombobox().Tables[0];
            cmbCategoria.ValueMember = "Categoria_ID";
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.SelectedItem = null;
            if (accion == 1)//MODIFICA
            {
                txtNombre.Text = nom;
                char[] delimitador = { ',' };
                string[] precio_venta_separado = precio.Split(delimitador);
                for (int j = 0; j < precio_venta_separado.Length; j++)
                {
                    txtPrecioV1.Text = precio_venta_separado[j];
                    j++;
                    txtPrecioV2.Text = precio_venta_separado[j];
                }
                txtDescipcion.Text = descri;
                cmbCategoria.SelectedValue = cat;
                cmb_Estado.Visible = true; cmb_Estado.Enabled = true;
                if (esta == 1) cmb_Estado.SelectedItem = "Activo";
                else cmb_Estado.SelectedItem = "Inactivo";
                lblEstado.Visible = true;
            }
            else//CREAR
            {
 
            }
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //////
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

            if (valida.comprobar == 1 && valida2.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 && cmbCategoria.SelectedItem != null)
            {
                if (txtPrecioV1.Text == "00" || txtPrecioV1.Text == "0")
                {
                    MessageBox.Show("EL PRECIO NO PUEDE SER 0", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (accion == 1)     // Modificar servicio
                    {
                        string precio_string = txtPrecioV1.Text + "," + txtPrecioV2.Text;
                        double Previo_Venta = Convert.ToDouble(precio_string);
                        int Estado;
                        if (cmb_Estado.SelectedItem.ToString() == "Activo")
                        {
                            Estado = 1;
                        }
                        else
                        {
                            Estado = 0;
                        }
                        csCompraProductos ModifiServicio = new csCompraProductos(servicio_id, txtNombre.Text, Previo_Venta, txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()), Estado);
                        if (ModifiServicio.Verificar == 1) { notifica.TitleText = "SE MODIFICO EL SERVICIO"; notifica.Text="Servicio Editado"; notifica.EnabledNoti = true; this.Close(); } else { notifica_error.TitleText = "ERROR AL EDITAR"; notifica_error.EnabledNoti = true; }

                    }
                    else          // Registrar servicio
                    {
                        string precio_string = txtPrecioV1.Text + "," + txtPrecioV2.Text;
                        double Previo_Venta = Convert.ToDouble(precio_string);
                        csCompraProductos Registrar_Servicio = new csCompraProductos(txtNombre.Text, Previo_Venta, txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()));
                        txtNombre.Text = ""; txtDescipcion.Text = ""; txtPrecioV1.Text = "00"; txtPrecioV2.Text = "00"; cmbCategoria.SelectedItem = null;
                        if (Registrar_Servicio.Verificar == 1) notifica.EnabledNoti = true; else notifica_error.EnabledNoti=true;
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
