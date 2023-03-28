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
    public partial class frmCompra_Productos : Form
    {
        //VARIBALES GLOBALES//
       /**/ int posicion_productos;/**/
       /**/ int fila;              /**/
       /**/ int posicion;          /**/
       /**/ int id_proveedor;      /**/
       /**/ int empleado_id;       /**/
       int producto_id;
       int iva_id=-1;
       string ur; 
        ////**/////////////////////
        public frmCompra_Productos(int idem)
        {
            empleado_id = idem;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCompra_Productos_Load(object sender, EventArgs e)
        {
            
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            // if (string.IsNullOrWhiteSpace(txtUsername.Text)) { }
            if (string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                panel_proveedores.Visible = false;
            }
            else
            {
                panel_proveedores.Visible = true;
                Listar_Proveedores_Orden_Compra obcom = new Listar_Proveedores_Orden_Compra();
                obcom.PalabraClave = txtProveedor.Text;
                dtgvProveedores.DataSource = obcom.listarpro();
            }
        }

        private void txtProveedor_MouseLeave(object sender, EventArgs e)
        {
            panel_proveedores.Visible = false;
        }

        private void dtgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //HACER QUE EL NOMBRE DE LA COMPAÑIA DEL DATAGRIDVIEW SELECCIONADO SE PASE AL TXTCOMPÑIA Y TAMBIEN SE GUARDE EL ID DEL PROVEEDOR EN UNA VARIABLE GOLBAL 
                posicion = dtgvProveedores.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                id_proveedor = int.Parse((dtgvProveedores[0, posicion].Value.ToString()));
                txtProveedor.Text = (dtgvProveedores[1, posicion].Value.ToString());
                panel_proveedores.Visible = false;
            }
            catch (Exception ne) { }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                csValidarCampos valida = new csValidarCampos();
                valida.TextBoxVacios(txtNombrePro, "Nombre producto");


                csValidarCampos valida3 = new csValidarCampos();
                valida3.TextBoxPrecio(txtStockPro, "Stock Pro");

                csValidarCampos valida4 = new csValidarCampos();
                valida4.TextBoxVacios(txtStockPro, "Stock Pro");

                csValidarCampos valida6 = new csValidarCampos();
                valida6.TextBoxPrecio(txtPrecioC1, "PrecioC1");

                csValidarCampos valida7 = new csValidarCampos();
                valida7.TextBoxPrecio(txtPrecioC2, "PrecioC2");

                decimal subtotal_text = 0;
                decimal total = 0;
                decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;
                if (valida.comprobar == 1 && valida3.comprobarprecio == 1 && valida4.comprobar == 1 && valida6.comprobarprecio == 1 && valida7.comprobarprecio == 1 )
                {
                    if ( txtPrecioC1.Text == "00" || txtPrecioC1.Text == "0")
                    {
                        MessageBox.Show("EL PRECIO NO PUEDE SER 0", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //RECORRER EL DATAGRIDVIEW PARA ENCONTRAR ID SIMILARES Y SI EXISTEN SIMILARES ENTONCES SUMAR EL STOCK O CANTIDAD Y ACTUALIZAR LOS TOTALES
                        
                        int repetido = 0;
                        for (int i = 0; i < dtg_Productos.RowCount; i++)
                        {
                            if (producto_id == int.Parse(dtg_Productos.Rows[i].Cells[0].Value.ToString()))  //.Parse(dtg_Productos.Rows[i].Cells[4].Value.ToString())
                            {
                                //PREGUNTAR QUE ACCION SE QUIERE EFECTUAR, EJEMPLO SI SE QUIERE SUMAR EL STOCK EXISTENTE PERO CON EL PRECIO QUE ESTABA ANTERIOR
                                //O SI SE QUIERE ACTUALIZAR EL STOCK PERO CON EL NUEVO PRECIO QUE SE ESTÁ INGRESANDO
                                DialogResult result = MessageBox.Show("Si=Suma Stock pero mantiene el precio \nNo= Suma Stock y actualiza el precio ", "El producto ya esta registrado", MessageBoxButtons.YesNoCancel);
                               if (result == DialogResult.Yes)
                               {
                                   dtg_Productos[2, i].Value = int.Parse(dtg_Productos[2, i].Value.ToString()) + int.Parse(txtStockPro.Text);
                                   dtg_Productos[4, i].Value = (int.Parse(dtg_Productos[2, i].Value.ToString()) * Convert.ToDecimal(dtg_Productos[3, i].Value.ToString())).ToString("N2");
                                   repetido = 1;
                                   txtNombrePro.Text = "";
                                   txtStockPro.Text = "";
                                   txtPrecioC1.Text = "";
                                   txtPrecioC2.Text = "";   
                               }
                               if (result == DialogResult.No)
                               {
                                   dtg_Productos[2, i].Value = int.Parse(dtg_Productos[2, i].Value.ToString()) + int.Parse(txtStockPro.Text);
                                   dtg_Productos[3, i].Value = txtPrecioC1.Text + "," + txtPrecioC2.Text;
                                   dtg_Productos[4, i].Value = (int.Parse(dtg_Productos[2, i].Value.ToString()) * Convert.ToDecimal(dtg_Productos[3, i].Value.ToString())).ToString("N2");
                                   repetido = 1;
                                   txtNombrePro.Text = "";
                                   txtStockPro.Text = "";
                                   txtPrecioC1.Text = "";
                                   txtPrecioC2.Text = "";   
                               }
                               if (result == DialogResult.Cancel)
                               {
                                   txtNombrePro.Text = "";
                                   txtStockPro.Text = "";
                                   txtPrecioC1.Text = "";
                                   txtPrecioC2.Text = "";
                                   repetido = 1;
                               }
                            }
                        }
                        if (repetido == 0)
                        {

                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dtg_Productos);
                            fila.Cells[0].Value = producto_id.ToString();
                            fila.Cells[1].Value = txtNombrePro.Text;
                            fila.Cells[2].Value = txtStockPro.Text;
                            fila.Cells[3].Value = txtPrecioC1.Text + "," + txtPrecioC2.Text;
                            fila.Cells[4].Value = (int.Parse(txtStockPro.Text) * Convert.ToDecimal(txtPrecioC1.Text + "," + txtPrecioC2.Text)).ToString("N2");
                            dtg_Productos.Rows.Add(fila);
                            txtNombrePro.Text = "";
                            txtStockPro.Text = "";
                            txtPrecioC1.Text = "";
                            txtPrecioC2.Text = "";                            
                        }//SUMAR LOS VALORES
                        if (dtg_Productos.RowCount != 0)
                        {

                            for (int i = 0; i < dtg_Productos.RowCount; i++)
                            {
                                subtotal_text += decimal.Parse(dtg_Productos.Rows[i].Cells[4].Value.ToString());
                                txtSubtotal.Text = subtotal_text.ToString();
                                decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                                total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                                txtTotalTotal.Text = total.ToString("N2");
                            }
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

        private void uI_ShadowPanel11_Click(object sender, EventArgs e) // medica_id.ToString() != ""             TODA ESTA PARTE ARREGLAR //AQUI SE CREA LA RECEPCION DEL PRODUCTO
        {
            int ver=0 ;
            try
            {
                csValidarCampos Valida1 = new csValidarCampos();
                Valida1.TextBoxVacios(txtNumeoFac,"");
                csValidarCampos valida2 = new csValidarCampos();
                valida2.TextBoxPrecio(txtNumeoFac,"Numero factura solo permite numeros");

                if (iva_id!=-1 && dtg_Productos.RowCount != 0 && id_proveedor != 0 && Valida1.comprobar == 1 && valida2.comprobarprecio == 1)
                {
                    //PRIMERO REGISTRAR LA ORDEN DE COMPRA  int id_empleado, decimal desc, int cod_iva, int proveedor_id, string fac)
                    csCompraProductos objOrdenCompra = new csCompraProductos(empleado_id,decimal.Parse(txtDescuentoGe.Text)/100, iva_id,id_proveedor,txtNumeoFac.Text); //SE CREA LA ORDEN DE COMPRA
                    //SEGUNDO RECORRER EL DATAGRIDVIEW
                    foreach (DataGridViewRow row in dtg_Productos.Rows)
                    {
                                                                              //(int stock, double precio_compra, int produc_id)
                        csCompraProductos DetalleRecpcion = new csCompraProductos(int.Parse(row.Cells["product_stock"].Value.ToString()),
                                                                                    Convert.ToDouble(row.Cells["producto_precio_compra"].Value.ToString()),
                                                                                    int.Parse(row.Cells["product_id"].Value.ToString())
                                                                                   );
                        ver = DetalleRecpcion.Verificar;
                    }
                    if (ver== 1)
                    {
                        notifica.EnabledNoti = true;
                        //VACIAR EL DATA 
                        dtg_Productos.Rows.Clear();
                        txtSubtotal.Text = "0,00";
                        txtDescuentoGe.Text = "0,00";
                        txtTotal.Text = "0";          //ESTE ES EL TEXTBOX DEL IVA SOLO QUE ME CONFUNDÍ Y LE DEJÉ COMO TOTAL XD
                        txtTotalTotal.Text = "0,00";
                        frm_Ver_Comprobante_Recepcion comprobante = new frm_Ver_Comprobante_Recepcion();
                        comprobante.Show();
                    }   
                }
                else
                {
                    MessageBox_Campos_Vacios objcampos = new MessageBox_Campos_Vacios();
                    objcampos.ShowDialog();
                }
            }
            catch (Exception ne)
            { MessageBox.Show(ne.Message); }
        }

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
                txtSubtotal.Text = (decimal.Parse(txtSubtotal.Text) - decimal.Parse(dtg_Productos[4, posicion_productos].Value.ToString())).ToString("N2");
                decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                txtTotalTotal.Text = total.ToString("N2");


               dtg_Productos.Rows.Remove(dtg_Productos.CurrentRow);
                         
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                

                posicion_productos = dtg_Productos.CurrentRow.Index;                              //AQUI SE TOMA LA POSICION DE LA FILA PARA PODER EDITARLA
                btnGuardar.Enabled = true; btnGuardar.Visible = true; btnGuardar.BringToFront();  //SE LA OBTIENE EN ESTA PARTE PARA EVITAR ERRORES CUANDO SE VUELVA
                btnAñadir.Enabled = false; btnAñadir.Visible = false;                             // A DAR CLICK EN EL CELL CLCIK 
                producto_id = int.Parse(dtg_Productos[0, posicion_productos].Value.ToString());
                txtNombrePro.Text = dtg_Productos[1, posicion_productos].Value.ToString();
                txtNombrePro.Enabled = false; panel_productos.Visible = false;
                panel_productos.Enabled = false;
                txtStockPro.Text = dtg_Productos[2, posicion_productos].Value.ToString();           // ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢤⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                                                                                                    //⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢤⣶⣄⠀⠀⠀⠀ ⣠⣶⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ////////////////////////////PARA SEPARAR LOS PRECIOS EN DOLARES Y CENTAVOS        //⠀⠀⠀⠀⠀ ⠀⠀⢀⣴⣦⣴⣿⡋⠀⠀⠈⢳⡄⠀⢠⣾⣿⠁⠈⣿⡆⠀⠀⠀
                //PRECIO DE COMPRA                                                                //⠀ ⠀⠀⠀⠀⠀⣰⣿⣿⠿⠛⠉⠉⠁⠀⠀⠀⠹⡄⣿⣿⣿⠀⠀⢹⡇⠀⠀⠀
                char[] delimitador = { ',' };                                                     //⠀⠀⠀⠀⠀⣠⣾⡿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⣰⣏⢻⣿⣿⡆⠀⠸⣿⠀⠀⠀
                string precio_compra = dtg_Productos[3, posicion_productos].Value.ToString();      //⠀  ⢀⣴⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⣿⣆⠹⣿⣷⠀⢘⣿⠀⠀⠀
                string[] precio_compra_separado = precio_compra.Split(delimitador); //⠀           ⠀  ⠀⢀⣴⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⣿⣆⠹⣿⣷⠀⢘⣿⢘⣿⠀⠀⠀
                for (int i = 0; i < precio_compra_separado.Length; i++)                 //           ⠀⢠⠏⠀⠀ ⠀⠀⠀⠀⠀⠀⢀⣤⣿⣿⣿⣷⣾⣿⡇⢀⠀⣼⣿⣿⣿⣧⠀
                {                                                                     //            ⠀⢠⠏⠀⠀⠀⠀⠀⠀⠀ ⠀⢀⣤⣿⣿⣿⣷⣾⣿⡇⢀⠀⣼⣿⣿⣿⣧⠀
                    txtPrecioC1.Text = precio_compra_separado[i];                       //         ⠀⢠⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣿⣿⣿⣷⣾⣿⡇⢀⠀⣼⣿⣿⣿⣧⠀
                    i++;                                                     // ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀                   ⠀⠀⠙⠛⠁⢙⠛⣿⣿⣿⣿⡟⠀⡿⠀⠀⢀⣿⡇
                    txtPrecioC2.Text = precio_compra_separado[i];              // ⠀⠀⠀                               ⠘⣶⣤⣉⣛⠻⠇⢠⣿⣾⣿⡄⢻⡇
                }                                                                                 //⠀⠀⠀             ⠘⣶⣤⣉⣛⠻⠇⢠⣿⣾⣿⡄⢻⡇
                //PRECIO DE VENTA
                dtg_Productos.Enabled = false;
               
               
                //cmbCategoria.SelectedValue=dtg_Productos[]
            }              
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtNombrePro.Enabled = true;
            panel_productos.Enabled = true;
            btnGuardar.Enabled = false; btnGuardar.Visible = false;
            btnAñadir.Visible = true; btnAñadir.Enabled = true;
            btnAñadir.BringToFront();
            dtg_Productos[0, posicion_productos].Value = producto_id.ToString();
            dtg_Productos[1, posicion_productos].Value = txtNombrePro.Text;
            dtg_Productos[2, posicion_productos].Value = txtStockPro.Text;
            dtg_Productos[3, posicion_productos].Value = txtPrecioC1.Text + "," + txtPrecioC2.Text;
            dtg_Productos[4, posicion_productos].Value = (int.Parse(txtStockPro.Text) * Convert.ToDecimal(txtPrecioC1.Text + "," + txtPrecioC2.Text)).ToString("N2"); ;
            txtNombrePro.Text = "";
            txtStockPro.Text = "";
            txtPrecioC1.Text = "00";
            txtPrecioC2.Text = "00";


            decimal subtotal_text = 0;
            decimal total = 0;
            decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;
            for (int i = 0; i < dtg_Productos.RowCount; i++)
            {
                subtotal_text += decimal.Parse(dtg_Productos.Rows[i].Cells[4].Value.ToString());
                txtSubtotal.Text = subtotal_text.ToString();
                decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text) * descuentogeneral);
                total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
                txtTotalTotal.Text = total.ToString("N2");
            }
            dtg_Productos.Enabled = true;

        }

        private void txtPrecioC1_MouseEnter(object sender, EventArgs e)
        {
            if (txtPrecioC1.Text == "00")
                txtPrecioC1.Text = "";
        }

        private void txtPrecioC1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioC1.Text))
                txtPrecioC1.Text = "00";
        }

        private void txtPrecioC2_MouseEnter(object sender, EventArgs e)
        {
            if (txtPrecioC2.Text == "00")
                txtPrecioC2.Text = "";
        }

        private void txtPrecioC2_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioC2.Text))
                txtPrecioC2.Text = "00";
        }

        private void txtPrecioV1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtPrecioV1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtPrecioV2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtPrecioV2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void uI_ShadowPanel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uI_ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombrePro_TextChanged(object sender, EventArgs e)
        {
            //AQUI ABRIR EL PANEL PRODUCTOS
            if (string.IsNullOrWhiteSpace(txtNombrePro.Text))
            {
                panel_productos.Visible = false;
            }
            else
            {
                panel_productos.Visible = true;
                Listar_Productos_Recepcion obprore = new Listar_Productos_Recepcion();
                obprore.palabra_clave = txtNombrePro.Text;
                dgtProductos.DataSource = obprore.listarpro();

            }

        }

        private void dgtProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dgtProductos.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                producto_id = int.Parse(dgtProductos[0, posicion].Value.ToString());
                txtNombrePro.Text = (dgtProductos[1,posicion].Value.ToString());
                panel_productos.Visible = false;
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
            catch(Exception ne )
            {}
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal descuentogeneral = decimal.Parse(txtDescuentoGe.Text) / 100;  
            decimal actualizar_el_total = decimal.Parse(txtSubtotal.Text) - (decimal.Parse(txtSubtotal.Text)*descuentogeneral);
            total = actualizar_el_total + (actualizar_el_total * decimal.Parse(txtTotal.Text));
            txtTotalTotal.Text = total.ToString("N2");

        }
    }
}
