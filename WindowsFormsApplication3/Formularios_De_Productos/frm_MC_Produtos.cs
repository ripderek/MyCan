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
    public partial class frm_MC_Produtos : Form
    {
        int id_emple;
        int fila;
        int posicion;
        public frm_MC_Produtos(int id_empleado)
        {
            id_emple = id_empleado;
            InitializeComponent();
        }

        private void uI_ShadowPanel3_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion( new frm_MC_Producto_Agregar_Editar());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void piNew_Click(object sender, EventArgs e)
        { 
            //ENVIAR EN FRMCOMPRAPRODUCTOS EL ID DEL EMPLEADO 
            Personalizacion per = new Personalizacion(new frmCompra_Productos(id_emple));
        }

        private void frm_MC_Produtos_Load(object sender, EventArgs e)
        {
            ListarProductosDATA listapro = new ListarProductosDATA();
            dataProductos.DataSource = listapro.listarProductos();
        }

        private void picAgregarProducto_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmNuevoProducto());
        }

        private void dataProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //AQUI PARA ELIMINAR O EDITAR 
            DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            { 
               //ELIMINAR DE LA BASE DE DATOS 
                posicion = dataProductos.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                csProductos objpro = new csProductos(int.Parse(dataProductos[0, posicion].Value.ToString()));
                if (objpro.Verficador_notifiacion == 1) { notifica.EnabledNoti = true; }
                else { notifica_error.EnabledNoti = true; }
                ListarProductosDATA listapro = new ListarProductosDATA();
                dataProductos.DataSource = listapro.listarProductos();
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                posicion = dataProductos.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                //cmb_cedula = (dataProductos[2, posicion].Value.ToString());
                //ENVIAR EL PARAMETRO DE ACCION Y LOS DEMAS PARAMETROS
                Personalizacion per = new Personalizacion(new frmNuevoProducto(1, int.Parse(dataProductos[0, posicion].Value.ToString()), 
                                                                                       dataProductos[1, posicion].Value.ToString(), 
                                                                                       dataProductos[2, posicion].Value.ToString(),
                                                                                       dataProductos[4, posicion].Value.ToString(),
                                                                                       int.Parse(dataProductos[6, posicion].Value.ToString()),
                                                                                       int.Parse(dataProductos[7, posicion].Value.ToString())));
                ListarProductosDATA listapro = new ListarProductosDATA();
                dataProductos.DataSource = listapro.listarProductos();
            }
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmCompra_Productos(id_emple));
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //OFERTAS 
            Personalizacion per = new Personalizacion(new frmOfertas_Productos());
        }

        private void uI_ShadowPanel3_Click_1(object sender, EventArgs e)
        {

            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox_Accion_Combos();
            resultado = mensaje.ShowDialog();

            //COMBOS  

            if (resultado == DialogResult.OK) // Ver combos
            {
                Personalizacion per = new Personalizacion(new frm_Detalles_de_combos());
            }
            else if (resultado == DialogResult.Ignore) //  //Registrar crear
            {

                //Registrar crear
                Personalizacion per = new Personalizacion(new frmCombos());
            }

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombre")
            {

                dataProductos.CurrentCell = null;
                foreach (DataGridViewRow fila in dataProductos.Rows)
                {
                    fila.Visible = fila.Cells["clmNombre"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Precio Venta")
            {

                dataProductos.CurrentCell = null;
                foreach (DataGridViewRow fila in dataProductos.Rows)
                {
                    fila.Visible = fila.Cells["clmPrecioVenta"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Stock")
            {

                dataProductos.CurrentCell = null;
                foreach (DataGridViewRow fila in dataProductos.Rows)
                {
                    fila.Visible = fila.Cells["clmStock"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Cantidad por unidad")
            {

                dataProductos.CurrentCell = null;
                foreach (DataGridViewRow fila in dataProductos.Rows)
                {
                    fila.Visible = fila.Cells["clmCantidadporunidad"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Categoria")
            {

                dataProductos.CurrentCell = null;
                foreach (DataGridViewRow fila in dataProductos.Rows)
                {
                    fila.Visible = fila.Cells["clmCategoria"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }

        private void uI_ShadowPanel4_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmMENU_IVAS());
        }
    }
}
