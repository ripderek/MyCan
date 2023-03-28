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
    public partial class frmCombos : Form
    {
        string ur;
        int posicion;
        int fila;
        //VARIABLES PARA GUARDAR LAS PROPIEDADES DE LOS PRODUCTOS QUE SE SELECCIONEN 
        int product_ID_DT;
        int stock_dt;
        string precio_venta_dt;
        csLISTAR_PRODUCTOS_PARA_COMBOS productosparacombos = new csLISTAR_PRODUCTOS_PARA_COMBOS();
        public frmCombos()
        {
            InitializeComponent();
            csCategoriasProductos objcat = new csCategoriasProductos();
            cmbCategoria.DataSource = objcat.CategoriaCombobox().Tables[0];
            cmbCategoria.ValueMember = "Categoria_ID";
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.SelectedItem = null;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //AQUI ABRIR EL PANEL DEL IVA 
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                panel_productos.Visible = false;
            }
            else if (txtNombre.Text == ur)
            {
                panel_productos.Visible = false;
            }
            else
            {
                panel_productos.Visible = true;
                csLISTAR_PRODUCTOS_PARA_COMBOS objproducto = new csLISTAR_PRODUCTOS_PARA_COMBOS();
                objproducto.PalabraClave = txtNombre.Text;
                dtproductos.DataSource = objproducto.listarpro();

                if (dtproductos.RowCount != 0)
                    ur = (dtproductos[2, posicion].Value.ToString());
                else
                    panel_productos.Visible = false;
            }
        }

        private void dtproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dtproductos.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
              // (dtIva[2, posicion].Value.ToString());

                product_ID_DT = int.Parse(dtproductos[0,posicion].Value.ToString());
                txtNombre.Text = dtproductos[1, posicion].Value.ToString();
                stock_dt=int.Parse(dtproductos[2, posicion].Value.ToString()); 
                 precio_venta_dt=dtproductos[3, posicion].Value.ToString() ;
                panel_productos.Visible = false;

               

            }
            catch (Exception ne) { }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int IDProductoVa;
            bool Valida = false;
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtCantidadPorComboProducto, "CantidadPorComboProducto");

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxPrecio(txtCantidadPorComboProducto, "CantidadPorComboProducto");

            if (product_ID_DT != 0 && valida.comprobar == 1 && valida2.comprobarprecio == 1)
            {
                foreach (DataGridViewRow i in dtg_Productos.Rows)
                {
                    IDProductoVa = Convert.ToInt32(i.Cells[0].Value.ToString());
                    if (IDProductoVa == product_ID_DT)
                    {
                        Valida = true;
                    }
                }

                if (Valida != true)
                {
                    
                    if (Convert.ToInt32(txtCantidadPorComboProducto.Text) > 0)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dtg_Productos);


                        fila.Cells[0].Value = product_ID_DT.ToString();
                        fila.Cells[1].Value = txtNombre.Text;
                        fila.Cells[2].Value = stock_dt;
                        fila.Cells[3].Value = precio_venta_dt;
                        fila.Cells[4].Value = txtCantidadPorComboProducto.Text;
                        dtg_Productos.Rows.Add(fila);
                        txtNombre.Text = "";
                        txtCantidadPorComboProducto.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("LA CANTIDAD NO PUEDE SER 0 NI MENOR", "!!ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE AÑADIR EL MISMO PRODUCTO DE NUEVO", "!!ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else
            {
                MessageBox_Campos_Vacios campos_vavio = new MessageBox_Campos_Vacios();
                campos_vavio.ShowDialog();
            }
        }

        private void frmCombos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombreCombo, "Nombre Combo");

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

            csValidarCampos valida8 = new csValidarCampos();
            valida8.TextBoxVacios(txtStockCombo, "Stock Combo");

            csValidarCampos valida9 = new csValidarCampos();
            valida9.TextBoxPrecio(txtStockCombo, "Stock Combo");

            //dtg_Productos
            //AQUI REGISTAR Y VALIDAR CAMPOS
            if (dtg_Productos.RowCount != 0 && dtg_Productos.RowCount != 1 && valida.comprobar == 1 && valida2.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 && valida8.comprobar == 1 && valida9.comprobarprecio == 1 && cmbCategoria.SelectedItem != null)
            {
                int IDProducto, Stock, CantidadProducto, Productoresta, accion = 0;
                string NombreProducto;

                foreach (DataGridViewRow i in dtg_Productos.Rows)
                {
                    IDProducto = Convert.ToInt32(i.Cells[0].Value.ToString());
                    NombreProducto = i.Cells[1].Value.ToString();
                    Stock = Convert.ToInt32(i.Cells[2].Value.ToString());
                    CantidadProducto = Convert.ToInt32(i.Cells[4].Value.ToString());
                    Productoresta = CantidadProducto * Convert.ToInt32(txtStockCombo.Text);
                    if (Productoresta > Stock)
                    {
                        MessageBox.Show("No hay suficiente stock del producto = " + NombreProducto, "!!ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accion = 1;
                    }
                    else
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dtgvProductos_a_restar);
                        fila.Cells[0].Value = IDProducto.ToString();
                        fila.Cells[1].Value = Productoresta.ToString();
                        fila.Cells[2].Value = CantidadProducto.ToString();
                        dtgvProductos_a_restar.Rows.Add(fila);
                    }
                }

                if (accion != 1)
                {
                    decimal precio_venta = decimal.Parse(txtPrecioV1.Text + "," + txtPrecioV2.Text);
                    csProductos objCombo = new csProductos(txtNombreCombo.Text, precio_venta, txtDescipcion.Text, int.Parse(cmbCategoria.SelectedValue.ToString()), Convert.ToInt32(txtStockCombo.Text));

                    if (objCombo.Verificardor_Combo != 1)  //nuevo 
                    {
                        MessageBox.Show("Combo Registrado Correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (DataGridViewRow i in dtgvProductos_a_restar.Rows)
                        {
                            IDProducto = Convert.ToInt32(i.Cells[0].Value.ToString());
                            Productoresta = Convert.ToInt32(i.Cells[1].Value.ToString());
                            CantidadProducto = Convert.ToInt32(i.Cells[2].Value.ToString());
                            csProductos objCombo2 = new csProductos(IDProducto, Productoresta);
                            csProductos objComboDeta = new csProductos(IDProducto, Productoresta, CantidadProducto);
                        }

                        //limpiar la pantalla
                        dtgvProductos_a_restar.Rows.Clear();
                        dtg_Productos.Rows.Clear();

                        txtNombreCombo.Text = "";
                        txtPrecioV1.Text = "00";
                        txtPrecioV2.Text = "00";
                        txtDescipcion.Text = "";
                        txtStockCombo.Text = "";
                        cmbCategoria.SelectedItem = null;
                    }
                    else
                    {
                        dtgvProductos_a_restar.Rows.Clear();  //nuevo 
                    }
                }
                else
                {
                    MessageBox.Show("NO SE REALIZO LA ACCION", "!!ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox_Campos_Vacios campos_vavio = new MessageBox_Campos_Vacios();
                campos_vavio.ShowDialog();
            }
        }
    }
}
