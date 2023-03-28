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
    
    public partial class frmFacturacion : Form
    {
        //VARIABLES GLOBALES 
        int product_id_lis=-1;
        string product_name_lis;
        decimal product_pice_lis;
        string pr;
        int empleado_id;
        int cliente_id_dta;
        int cliente_fila;
        int cliente_posicion;
        //VARIABLES PARA LOS DATAGRIDVIEW
        int posicion_producto;
        int fila_producto;
        int fila;              /**/
        /**/
        int posicion;
        int iva_id=-1;
        string ur;
        /**/
        int posicion_productos;/**/


        public frmFacturacion(int id_emp)
        {
            empleado_id = id_emp;
            InitializeComponent();
        }

        private void uI_ShadowPanel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProducto.Text))
                {
                    // panel_proveedores.Visible = false;
                    panel_lispro.Visible = false;
                }             
                else
                {
                    panel_lispro.Visible = true;
                    Listar_Productos_Servicios_Factura proserfac = new Listar_Productos_Servicios_Factura();
                    proserfac.palabra_clave = txtProducto.Text;
                    listaProductos.DataSource = proserfac.listarpro();              
                    
                }

            }
            catch (Exception ne)
            {
            }
        }

        private void listaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion_producto = listaProductos.CurrentRow.Index;
                fila_producto = e.RowIndex;
                int columna = e.ColumnIndex;
                product_id_lis = int.Parse(listaProductos[0, posicion_producto].Value.ToString());
                txtProducto.Text = listaProductos[1, posicion_producto].Value.ToString();
                product_name_lis = listaProductos[1, posicion_producto].Value.ToString();
                product_pice_lis = decimal.Parse(listaProductos[2, posicion_producto].Value.ToString());
                //AQUI VERIFICAR SI EL PRODUCTO TIENE UNA OFERTA ENVIANDO EL ID
                panel_lispro.Visible = false;
            }
            catch (Exception ne) { }
          
        }

     
     
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            decimal subtotal_text = 0;
            decimal total = 0;
            decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text)/100;
            try
            {
                csValidarCampos valida = new csValidarCampos();
                valida.TextBoxVacios(txtProducto, "Nombre producto");

                csValidarCampos valida2 = new csValidarCampos();
                valida2.TextBoxPrecio(txtCantidad, "Cantidad");

                csValidarCampos valida3 = new csValidarCampos();
                valida3.TextBoxVacios(txtCantidad, "Cantidad");

            

                if (valida.comprobar ==1 && valida2.comprobarprecio == 1 && valida3.comprobar == 1&&product_id_lis!=-1 )
                {
                    //AÑADIR UN CAMPO EN EL DATAGRIDVIEW PARA QUE SE GUARDE LA OFERTA, SI NO EXITE SERÍA 0 

                    //AQUI RECORRER EL DATA PARA VER SI HAY UN ID REPETIDO Y SUMAR LA CANTIDAD Y ADEMAS DE ESO VERIFICAR LA OFERTA
                    
                     int repetido = 0;
                     for (int i = 0; i < dtg_Productos.RowCount; i++)
                     {
                         if (product_id_lis == int.Parse(dtg_Productos.Rows[i].Cells[0].Value.ToString()))  //.Parse(dtg_Productos.Rows[i].Cells[4].Value.ToString())
                         {
                             //dtg_Productos[2, i].Value = int.Parse(dtg_Productos[2, i].Value.ToString()) + int.Parse(txtStockPro.Text);
                             dtg_Productos[4, i].Value = int.Parse(dtg_Productos[4, i].Value.ToString())+int.Parse(txtCantidad.Text);
                             csProductos ofertaproducto = new csProductos(int.Parse(dtg_Productos[0, i].Value.ToString()), int.Parse(dtg_Productos[4, i].Value.ToString()), true);
                             dtg_Productos[2, i].Value = ofertaproducto.Oferta_Descuento_;
                             decimal precioNuevo = decimal.Parse(dtg_Productos[6, i].Value.ToString()) - (decimal.Parse(dtg_Productos[6, i].Value.ToString()) * ofertaproducto.Oferta_Descuento_);
                             dtg_Productos[3, i].Value = precioNuevo;
                             dtg_Productos[5, i].Value = int.Parse(dtg_Productos[4, i].Value.ToString())*precioNuevo;
                             txtProducto.Text = "";
                             txtCantidad.Text = "0";
                             repetido = 1;
                         }
                     }
                     if (repetido == 0)
                     {
                         DataGridViewRow fila = new DataGridViewRow();
                         csProductos ofertaproducto = new csProductos(product_id_lis, int.Parse(txtCantidad.Text), true);
                         fila.CreateCells(dtg_Productos);
                         fila.Cells[0].Value = product_id_lis.ToString();
                         fila.Cells[1].Value = product_name_lis;
                         fila.Cells[2].Value = ofertaproducto.Oferta_Descuento_;
                         fila.Cells[3].Value = (product_pice_lis - (product_pice_lis * ofertaproducto.Oferta_Descuento_)).ToString("N2");
                         decimal precioNuevo = decimal.Parse((product_pice_lis - (product_pice_lis * ofertaproducto.Oferta_Descuento_)).ToString("N2"));
                         fila.Cells[4].Value = txtCantidad.Text;
                         fila.Cells[5].Value = (int.Parse(txtCantidad.Text) * precioNuevo).ToString();
                         fila.Cells[6].Value = product_pice_lis;
                         dtg_Productos.Rows.Add(fila);
                         //if (ofertaproducto.Veri_Oferta == true)
                         //   MessageBox.Show("PRODUCTO EN OFERTA");

                         //RECORRER EL DATA GRID VIEW PARA SUMAR LOS TOTALES DE LOS PRODUCTOS Y ALMACENARLOS EN SUBTOTAL 
                        
                       
                         txtProducto.Text = "";
                         txtCantidad.Text = "0";
                     }
                     if (dtg_Productos.RowCount != 0)
                     {

                         for (int i = 0; i < dtg_Productos.RowCount; i++)
                         {
                             subtotal_text += decimal.Parse(dtg_Productos.Rows[i].Cells[5].Value.ToString());
                             txtSubtotal.Text = subtotal_text.ToString();
                             decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                             total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                             txtTotalTotal.Text = total.ToString("N2");
                         }
                     }
                   
                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }
                
            }
            catch (Exception ne)
            { MessageBox.Show(ne.Message); }
        }

        private void txtDescuentoGe_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;
            decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
            total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
            txtTotalTotal.Text = total.ToString("N2");

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

            int IDProducto;
            int CantidadPro;
            bool valida = false;
            string Producto;

            int ac = -1;
            int cliente_id = 0;
            if (toggle_cliente.Checked == true)
                cliente_id = 0;
            else
            { cliente_id = cliente_id_dta; } //AQUIE HACER QUE LA VARIABLES cliente_id tome el valor que tenga el id que se esocjio del datagridview

            if (dtg_Productos.RowCount != 0 &&cliente_id!=-1&&iva_id!=-1)
            {

                csFactura objFac = new csFactura();

                foreach (DataGridViewRow i in dtg_Productos.Rows)
                {
                    IDProducto = Convert.ToInt32(i.Cells[0].Value.ToString());
                    CantidadPro = Convert.ToInt32(i.Cells[4].Value.ToString());
                    Producto = i.Cells[1].Value.ToString();
                    objFac.IDProduc_ = IDProducto;
                    objFac.SACARELSTOCKPRO();
                    if (CantidadPro > objFac.Cantidad)
                    {
                        MessageBox.Show("Hay menos stock del producto " + Producto + " de lo solicitado para la venta", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        valida = true;
                    }
                }
                if (valida == false)
                {
                    csFactura objfactura = new csFactura(empleado_id, cliente_id, Decimal.Parse(txtDescuentoGe.Text) / 100, iva_id);
                    foreach (DataGridViewRow row in dtg_Productos.Rows)
                    {
                        //row.Cells["nombre"].Value.ToString(),
                        csFactura objdetalle = new csFactura(int.Parse(row.Cells["product_id"].Value.ToString()), int.Parse(row.Cells["quantity"].Value.ToString()), decimal.Parse(row.Cells["oferta_producto"].Value.ToString()), true);
                        ac = objdetalle.Verificar;
                    }

                    if (ac == 1)
                    {
                        // MessageBox.Show("TRUE");
                        dtg_Productos.Rows.Clear();
                        txtCantidad.Text = "";
                        toggle_cliente.Checked = false;
                        txtDescuentoGe.Text = "0";
                        txtSubtotal.Text = "0";
                        txtTotal.Text = "0";
                        iva_id = -1;
                        notifica.EnabledNoti = true;
                        frm_FACTURA_ELECTRONICAXD factura = new frm_FACTURA_ELECTRONICAXD();
                        factura.Show();
                        ////////////////////////////////////////////&---------[IMPRIMIR LA FACTURA ]
                    }
                }
            }
            else
            {
                MessageBox_Campos_Vacios objcampos = new MessageBox_Campos_Vacios();
                objcampos.ShowDialog();
            }


        }

       
        private void toggle_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_cliente.Checked == true)
                txtCliente.Enabled = false; 
            else
                txtCliente.Enabled = true;
        }

        private void uI_ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    panel_Cliente.Visible = false;
                }
                else
                {
                    panel_Cliente.Visible = true;
                    csBuscar_Clinete_Cedula proserfac = new csBuscar_Clinete_Cedula();
                    proserfac.palabra_clave = txtCliente.Text;
                    dtgvCliente.DataSource = proserfac.listarpro();
                }
            }
            catch (Exception ne)
            {
            }
        }
        private void dtgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //GUARDAR EL ID DEL CLIENTE EN UNA VARIABLE 
            try
            {
                cliente_posicion = dtgvCliente.CurrentRow.Index;
                cliente_fila = e.RowIndex;
                int columna = e.ColumnIndex;
                cliente_id_dta = int.Parse(dtgvCliente[0, cliente_posicion].Value.ToString());
                txtCliente.Text = dtgvCliente[1, cliente_posicion].Value.ToString();
                panel_Cliente.Visible = false;
            }
            catch (Exception ne) { }
        }

        //EVENTO PARA SABER SI SE QUIERE ELIMINAR O EDITAR 
        private void dtg_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                posicion_productos = dtg_Productos.CurrentRow.Index;


                decimal total = 0;
                decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;
                txtSubtotal.Text = (decimal.Parse(txtSubtotal.Text) - decimal.Parse(dtg_Productos[5, posicion_productos].Value.ToString())).ToString("N2");
                decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                txtTotalTotal.Text = total.ToString("N2");


                dtg_Productos.Rows.Remove(dtg_Productos.CurrentRow);

            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                dtg_Productos.Enabled = false;
                posicion_productos = dtg_Productos.CurrentRow.Index;                              //AQUI SE TOMA LA POSICION DE LA FILA PARA PODER EDITARLA
                btnGuardar.Enabled = true; btnGuardar.Visible = true; btnGuardar.BringToFront();  //SE LA OBTIENE EN ESTA PARTE PARA EVITAR ERRORES CUANDO SE VUELVA
                btnAñadir.Enabled = false; btnAñadir.Visible = false;

                product_id_lis = int.Parse(dtg_Productos[0, posicion_productos].Value.ToString());
                product_name_lis = dtg_Productos[1, posicion_productos].Value.ToString();
                product_pice_lis = Convert.ToDecimal(dtg_Productos[6, posicion_productos].Value.ToString());
                txtCantidad.Text = (dtg_Productos[4, posicion_productos].Value.ToString());
                txtProducto.Text=product_name_lis;
                txtProducto.Enabled = false;
                panel_lispro.Enabled = false;
                panel_lispro.Visible = false;
            }              
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false; btnGuardar.Visible = false;
            btnAñadir.Visible = true; btnAñadir.Enabled = true;
            btnAñadir.BringToFront();

            if (product_id_lis != -1)
            {
                csProductos ofertaproducto = new csProductos(product_id_lis, int.Parse(txtCantidad.Text), true);
                dtg_Productos[0, posicion_productos].Value = product_id_lis.ToString();
                dtg_Productos[1, posicion_productos].Value = product_name_lis;
                dtg_Productos[2, posicion_productos].Value = ofertaproducto.Oferta_Descuento_;
                dtg_Productos[3, posicion_productos].Value = (product_pice_lis - (product_pice_lis * ofertaproducto.Oferta_Descuento_)).ToString("N2");
                decimal precioNuevo = decimal.Parse((product_pice_lis - (product_pice_lis * ofertaproducto.Oferta_Descuento_)).ToString("N2"));
                dtg_Productos[4, posicion_productos].Value = txtCantidad.Text;
                dtg_Productos[5, posicion_productos].Value = (int.Parse(txtCantidad.Text) * precioNuevo).ToString();
                txtProducto.Text = "";
                txtCantidad.Text = "";
                dtg_Productos.Enabled = true;
                txtProducto.Enabled = true;
                panel_lispro.Enabled = true;

                decimal subtotal_text = 0;
                decimal total = 0;
                decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;
                for (int i = 0; i < dtg_Productos.RowCount; i++)
                {
                    subtotal_text += decimal.Parse(dtg_Productos.Rows[i].Cells[5].Value.ToString());
                    txtSubtotal.Text = subtotal_text.ToString();
                    decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                    total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                    txtTotalTotal.Text = total.ToString("N2");
                }
            }
        }

        private void dtIva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dtIva.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                iva_id = int.Parse(dtIva[0, posicion].Value.ToString());
                txtTotal.Text = (dtIva[2, posicion].Value.ToString());               
                panel_Iva.Visible = false;

                decimal total = 0;
                decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;
                decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                txtTotalTotal.Text = total.ToString("N2");

            }
            catch (Exception ne) { }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //AQUI ABRIR EL PANEL DEL IVA 
            try
            {
                if (string.IsNullOrWhiteSpace(txtTotal.Text))
                {
                    panel_Iva.Visible = false;
                }

                else
                {
                    panel_Iva.Visible = true;
                    ListarIva_recepcion objIAVA = new ListarIva_recepcion();
                    objIAVA.palabra_clave = txtTotal.Text;
                    dtIva.DataSource = objIAVA.listarpro();
                }
            }
            catch (Exception ne)
            { }
        }
           
    }
}
