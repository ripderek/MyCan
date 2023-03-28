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
    public partial class frmOfertas_Productos : Form
    {
        string ur;
        int posicion;
        int fila;
        int produc_id;
        int oferta_id;
        public frmOfertas_Productos()
        {
            InitializeComponent();
        }

        private void txtDescipcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOfertas_Productos_Load(object sender, EventArgs e)
        {
            Listar_Ofertas ofertaslistas = new Listar_Ofertas();
            dtg_Ofertas.DataSource = ofertaslistas.listarEmpleado();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //AQUI REGISTRAR LA OFERTA XD  Decimal.Parse(txtDescuento.Text) / 100
            csOfertas CrearOferta = new csOfertas(produc_id, datetime_Inicio.Value.Date, datetime_Fin.Value.Date, Decimal.Parse(txtDescuento.Text) / 100, int.Parse(txtCantidad.Text));
            if (CrearOferta.Verficador_notifiacion == 1)
                notifica.EnabledNoti = true;
            else
                notifica_error.EnabledNoti = true;
            //ACTUALIZAR EL DATAGRIDVIEW 
            Listar_Ofertas ofertaslistas = new Listar_Ofertas();
            dtg_Ofertas.DataSource = ofertaslistas.listarEmpleado();
            txtCantidad.Text = "";
            txtDescuento.Text = "";
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                panel_productos.Visible = false;
            }
            else if (txtProducto.Text == ur)
            {
                panel_productos.Visible = false;
            }
            else
            {
                panel_productos.Visible = true;
                csLISTAR_PRODUCTOS_PARA_COMBOS objproducto = new csLISTAR_PRODUCTOS_PARA_COMBOS();
                objproducto.PalabraClave = txtProducto.Text;
                dtproductos.DataSource = objproducto.listarproparaoferta();

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
                produc_id = int.Parse(dtproductos[0, posicion].Value.ToString());
                txtProducto.Text = dtproductos[1, posicion].Value.ToString();
                panel_productos.Visible = false;
            }
            catch (Exception ne) { }
        }

        private void dtproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void dtg_Ofertas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtg_Ofertas.CurrentRow.Index;
            fila = e.RowIndex;
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox_Oferta_Accion();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                //CAMBIAR ESTADO 
                csOfertas cambiarEstado = new csOfertas(int.Parse(dtg_Ofertas[0, posicion].Value.ToString()), int.Parse(dtg_Ofertas[9, posicion].Value.ToString()));
                //ACTUALIZAR EL DATAGRIDVIEW 
                Listar_Ofertas ofertaslistas = new Listar_Ofertas();
                dtg_Ofertas.DataSource = ofertaslistas.listarEmpleado();
                if (cambiarEstado.Verficador_notifiacion == 1)
                { notifica.TitleText = "ESTADO CAMBIADO"; notifica.Text = "Estado editado"; notifica.EnabledNoti = true; }
                else
                    notifica_error.EnabledNoti = true;
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                // oferta_id
                txtProducto.Visible = false;
                txtNombreVEREDITAR.Visible = true;
                txtNombreVEREDITAR.BringToFront();
                oferta_id =int.Parse(dtg_Ofertas[0, posicion].Value.ToString());
                txtNombreVEREDITAR.Text = dtg_Ofertas[2, posicion].Value.ToString();
                datetime_Inicio.Value =Convert.ToDateTime(dtg_Ofertas[3, posicion].Value.ToString());
                datetime_Fin.Value = Convert.ToDateTime(dtg_Ofertas[4, posicion].Value.ToString());
                txtDescuento.Text = dtg_Ofertas[5, posicion].Value.ToString();
                txtCantidad.Text = dtg_Ofertas[6, posicion].Value.ToString();
                uI_ShadowPanel2.Visible = true; uI_ShadowPanel2.BringToFront();
                btnRegistrar.Visible = false;
            }

        }

        private void dtg_Ofertas_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dtg_Ofertas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //PARA CAPTURAR EL EVENTO CLICK DERECHO DEL MOUSE 
            {
                posicion = dtg_Ofertas.CurrentRow.Index;
                fila = e.RowIndex;
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox_Oferta_Accion();
                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK) //ELIMINAR
                {
                    //CAMBIAR ESTADO 

                }
                else if (resultado == DialogResult.Ignore) //EDITAR
                {
                }
            }
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            //GUARDAR CAMBIOS
            csOfertas Editar_Oferta = new csOfertas(oferta_id, datetime_Inicio.Value.Date, datetime_Fin.Value.Date, Decimal.Parse(txtDescuento.Text) / 100, int.Parse(txtCantidad.Text),true);
            //ACTUALIZAR EL DATAGRIDVIEW 
            Listar_Ofertas ofertaslistas = new Listar_Ofertas();
            dtg_Ofertas.DataSource = ofertaslistas.listarEmpleado();
            if (Editar_Oferta.Verficador_notifiacion == 1)
            { notifica.TitleText = "OFERTA EDITADA"; notifica.Text = "Se editó una oferta"; notifica.EnabledNoti = true; }
            else
                notifica_error.EnabledNoti = true;
            uI_ShadowPanel2.Visible = false; 
            btnRegistrar.Visible = true;
            btnRegistrar.BringToFront();
            txtNombreVEREDITAR.Visible = false;
            txtProducto.Visible = true;
            txtProducto.BringToFront();
            txtCantidad.Text = "";
            txtDescuento.Text = "";


        }
    }
}
