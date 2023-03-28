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
    public partial class frmNuevoProducto : Form
    {
        int ac;
        int producto_id;

        public frmNuevoProducto(int accion = 0, int pro_id = 0, string nomb = "", string precio = "", string cantidad = "", int categ=0, int esta=0)
        {
            InitializeComponent();
            ac = accion;
            producto_id = pro_id;
            csCategoriasProductos objcat = new csCategoriasProductos();
            cmbCategoria.DataSource = objcat.CategoriaCombobox().Tables[0];
            cmbCategoria.ValueMember = "Categoria_ID";
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.SelectedItem = null;
            if (accion == 0) //Si la accion es =0 entonces se crea el producto 
            {
                btnRegistrar.Enabled = true; btnRegistrar.Visible = true; btnRegistrar.BringToFront();
            }
            else //De lo contrario quiere decir que tendriamos que modificar un producto segun el id que se envia en el parámetro
            {
                btnGuardar.Enabled = true; btnGuardar.Visible = true; btnGuardar.BringToFront();
                btnRegistrar.Enabled = false; btnRegistrar.Visible = false;
                txtNombre.Text = nomb;
                txtDescipcion.Text = cantidad;

              
                cmbCategoria.SelectedValue = categ;
                cmb_Estado.Enabled = true; cmb_Estado.Visible = true;
                lblEstado.Visible = true;
                if (esta == 0) cmb_Estado.SelectedItem = "Inactivo";
                else cmb_Estado.SelectedItem = "Activo";


                char[] delimitador = { ',' }; 
                string[] precio_venta_separado = precio.Split(delimitador);
                for (int j = 0; j < precio_venta_separado.Length; j++)
                {
                    txtPrecioV1.Text = precio_venta_separado[j];
                    j++;
                    txtPrecioV2.Text = precio_venta_separado[j];
                }

            }
        }


        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (valida.comprobar == 1 && valida2.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 && cmbCategoria.SelectedItem != null)
            {
                if (txtPrecioV1.Text == "00" && txtPrecioV2.Text == "00" || txtPrecioV1.Text == "0" || txtPrecioV2.Text == "0")
                {
                    MessageBox.Show("EL PRECIO NO PUEDE SER 0", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //AQUI ENVIAR A REGISTRAR EL PRODUCTO PERO ESTE NO PUEDE REPETIRSE EN EL NOMBRE 
                    decimal precio_venta = decimal.Parse(txtPrecioV1.Text + "," + txtPrecioV2.Text);
                    csProductos objProducto = new csProductos(txtNombre.Text, precio_venta, txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()));
                    if (objProducto.Verficador_notifiacion == 1) { notifica.EnabledNoti = true; }
                    else { notifica_error.EnabledNoti = true; }
                    txtNombre.Text = "";
                    txtPrecioV1.Text = "00";
                    txtPrecioV2.Text = "00";
                    txtDescipcion.Text = "";
                    cmbCategoria.SelectedItem = null;
                }
            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

            if (valida.comprobar == 1 && valida2.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 && cmbCategoria.SelectedItem != null  && cmb_Estado.SelectedItem != null)
            {
                if (txtPrecioV1.Text == "00" && txtPrecioV2.Text == "00" || txtPrecioV1.Text == "0" || txtPrecioV2.Text == "0")
                {
                    MessageBox.Show("EL PRECIO NO PUEDE SER 0", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    //PARA GUARDAR LOS CAMBIOS QUE SE LE HACE AL PRODUCTO 
                    //        public csProductos(int pro_id, string nombre, decimal precio, string cantidad_produc, int cate, int esta)
                    decimal precio_venta = decimal.Parse(txtPrecioV1.Text + "," + txtPrecioV2.Text);
                    int estado = 0;
                    if (cmb_Estado.SelectedItem == "Activo") estado = 1;
                    csProductos objProducto = new csProductos(producto_id, txtNombre.Text, precio_venta, txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()), estado);
                    if (objProducto.Verficador_notifiacion == 1) { notifica.TitleText = "CAMBIOS EFECTUADOS"; notifica.Text = "Se actualizó el producto"; notifica.EnabledNoti = true; }
                    else { notifica_error.EnabledNoti = true; }
                    this.Close();
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
