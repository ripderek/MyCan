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
    public partial class frm_Ver_Comprobante_Recepcion : Form
    {
        public frm_Ver_Comprobante_Recepcion()
        {
            InitializeComponent();
        }

        private void frm_Ver_Comprobante_Recepcion_Load(object sender, EventArgs e)
        {
            csCompraProductos comp = new csCompraProductos();
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Comprobante_Recepcion_Producto.SP_DATOS_REPCION' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_REPCIONTableAdapter.Fill(this.DataSet_Comprobante_Recepcion_Producto.SP_DATOS_REPCION,comp.Comprabante_recepcion_id);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Comprobante_Recepcion_Producto.SP_LISTAR_PRODUCTOS_RECEPCION' Puede moverla o quitarla según sea necesario.
            this.SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter.Fill(this.DataSet_Comprobante_Recepcion_Producto.SP_LISTAR_PRODUCTOS_RECEPCION, comp.Comprabante_recepcion_id);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Comprobante_Recepcion_Producto.SP_RESULTADOS_RECEPCION_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter.Fill(this.DataSet_Comprobante_Recepcion_Producto.SP_RESULTADOS_RECEPCION_PRODUCTOS, comp.Comprabante_recepcion_id);

            this.reportViewer1.RefreshReport();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void uI_ShadowPanel4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
