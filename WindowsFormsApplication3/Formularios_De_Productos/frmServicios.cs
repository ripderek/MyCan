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
    public partial class frmServicios : Form
    {
        int posicion;
        int IDServicio;
        int accion;
        int fila;
        public frmServicios()
        {
            InitializeComponent();

            LISTAR_SERVICIOS lisser = new LISTAR_SERVICIOS();
            dtgvServicio.DataSource = lisser.listarEmpleado();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

          
        }


        /// //////////////////////////////////

        private void dtgvServicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgvServicio.CurrentRow.Index;
            fila = e.RowIndex;
            DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            { 
               //ELIMINAR DE LA BASE DE DATOS 
                csCompraProductos eliminarser = new csCompraProductos(int.Parse(dtgvServicio[0, posicion].Value.ToString()),true);
                if (eliminarser.Verificar == 1) notifica.EnabledNoti = true; else notifica_error.EnabledNoti = true;
                LISTAR_SERVICIOS lisser = new LISTAR_SERVICIOS();
                dtgvServicio.DataSource = lisser.listarEmpleado();
         
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                Personalizacion per = new Personalizacion(new frmServicios_Agregar_Modificar(1, int.Parse(dtgvServicio[0, posicion].Value.ToString()),
                                        dtgvServicio[1, posicion].Value.ToString(), dtgvServicio[2, posicion].Value.ToString(), dtgvServicio[3, posicion].Value.ToString(),
                                         int.Parse(dtgvServicio[5, posicion].Value.ToString()), int.Parse(dtgvServicio[6, posicion].Value.ToString())));
                LISTAR_SERVICIOS lisser = new LISTAR_SERVICIOS();
                dtgvServicio.DataSource = lisser.listarEmpleado();
            }




            /*
         
            IDServicio = Convert.ToInt32(dtgvServicio[0, posicion].Value);
            txtNombre.Text = (dtgvServicio[1, posicion].Value.ToString());
            txtDescipcion.Text = (dtgvServicio[3, posicion].Value.ToString());

            //Poner el el combobox 
            cmbCategoria.SelectedValue = int.Parse(dtgvServicio[5, posicion].Value.ToString());

            // SEPARAR LOS PRECIOS 
            //PRECIO DE VENTA
            char[] delimitador = { ',' }; 
            string precio_venta = dtgvServicio[2, posicion].Value.ToString();
            string[] precio_venta_separado = precio_venta.Split(delimitador);
            for (int j = 0; j < precio_venta_separado.Length; j++)
            {
                txtPrecioV1.Text = precio_venta_separado[j];
                j++;
                txtPrecioV2.Text = precio_venta_separado[j];
            }

            accion = 1;
            lblRegistrar_Guardar.Text = "Guardar";
             * */
 
        }

        private void picAgregarProducto_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmServicios_Agregar_Modificar());
            LISTAR_SERVICIOS lisser = new LISTAR_SERVICIOS();
            dtgvServicio.DataSource = lisser.listarEmpleado();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombre")
            {

                dtgvServicio.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvServicio.Rows)
                {
                    fila.Visible = fila.Cells["clmNombre"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Precio Venta")
            {

                dtgvServicio.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvServicio.Rows)
                {
                    fila.Visible = fila.Cells["clmPrecioVenta"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Descripcion")
            {

                dtgvServicio.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvServicio.Rows)
                {
                    fila.Visible = fila.Cells["clmDescripcion"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Categoria")
            {

                dtgvServicio.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvServicio.Rows)
                {
                    fila.Visible = fila.Cells["clmCategoria"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }
    }
}
