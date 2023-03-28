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
    public partial class frm_Categorias : Form
    {
        int posicion;
        int accion;
        int IDCategoria;
        int fila;

        public frm_Categorias()
        {
            InitializeComponent();
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Categorias_Load(object sender, EventArgs e)
        {
            //Listar las categorias en el datavg
            csCategoriasProductos objCategoria = new csCategoriasProductos();
            dtgvCategorias.DataSource = objCategoria.ListarCategoria();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxVacios(txtDescipcion, "Descripcion");

            if (valida.comprobar == 1 && valida2.comprobar == 1)
            {
                if (accion == 1)     //Modificar categoria
                {
                    csCategoriasProductos objModiCategori = new csCategoriasProductos(IDCategoria,txtNombre.Text, txtDescipcion.Text);
                    accion = 0;
                    txtNombre.Text = ""; txtDescipcion.Text = "";
                    dtgvCategorias.DataSource = objModiCategori.ListarCategoria();
                    if (objModiCategori.verificar == 1)
                    {
                        notifica.TitleText = "CATEGORIA MODIFICADA";
                        notifica.Text = "Se editó la categoria";
                        notifica.EnabledNoti = true;
                    }
                    else
                    {
                        notifica_error.TitleText = "ERROR AL MODIFICAR";
                        notifica_error.EnabledNoti = true;
                    }
                }
                else  // Registrar categoria
                {
                    csCategoriasProductos objRegiCategori = new csCategoriasProductos(txtNombre.Text, txtDescipcion.Text);

                    txtNombre.Text = ""; txtDescipcion.Text = "";
                    dtgvCategorias.DataSource = objRegiCategori.ListarCategoria();
                    if (objRegiCategori.verificar == 1)
                    {
                        notifica.EnabledNoti = true;
                    }
                    else
                    {
                        notifica_error.EnabledNoti = true;
                    }
                }
            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }

        }


        private void dtgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgvCategorias.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;

             DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                csCategoriasProductos objRegiCategori = new csCategoriasProductos(Convert.ToInt32(dtgvCategorias[0, posicion].Value));
                if (objRegiCategori.verificar == 1)
                {
                    notifica.TitleText = "SE ELIMINÓ LA CATEGORIA";
                    notifica.Text = "Categoria elimninada";
                    notifica.EnabledNoti = true;
                    dtgvCategorias.DataSource = objRegiCategori.ListarCategoria();
                }
                else
                {
                    notifica_error.TitleText = "ERROR AL ELIMINAR";
                    notifica_error.EnabledNoti = true;
                }
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                IDCategoria = Convert.ToInt32(dtgvCategorias[0, posicion].Value);
                txtNombre.Text = (dtgvCategorias[1, posicion].Value.ToString());
                txtDescipcion.Text = (dtgvCategorias[2, posicion].Value.ToString());
                accion = 1;
            }

          

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombre")
            {

                dtgvCategorias.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvCategorias.Rows)
                {
                    fila.Visible = fila.Cells["clmNombreCategoria"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Descripcion")
            {

                dtgvCategorias.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvCategorias.Rows)
                {
                    fila.Visible = fila.Cells["clmDescripcionCate"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }
    }
}
