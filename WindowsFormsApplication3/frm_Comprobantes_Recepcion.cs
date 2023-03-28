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
    public partial class frm_Comprobantes_Recepcion : Form
    {
        public frm_Comprobantes_Recepcion()
        {
            InitializeComponent();
        }

        private void frm_Comprobantes_Recepcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECEPCION_PRODUCTOS_FACTURA.Sp_DATOS_RECEPCION_FACTURA' Puede moverla o quitarla según sea necesario.
          //  this.Sp_DATOS_RECEPCION_FACTURATableAdapter.Fill(this.DataSet_RECEPCION_PRODUCTOS_FACTURA.Sp_DATOS_RECEPCION_FACTURA, "674743464564564");
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_LISTAR_PRODUCTOS_RECEPCION_FACTURA' Puede moverla o quitarla según sea necesario.
          //  this.SP_LISTAR_PRODUCTOS_RECEPCION_FACTURATableAdapter.Fill(this.DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_LISTAR_PRODUCTOS_RECEPCION_FACTURA, "674743464564564");
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_RESULTADOS_RECEPCION_PRODUCTOS_FACTURA' Puede moverla o quitarla según sea necesario.
         //   this.SP_RESULTADOS_RECEPCION_PRODUCTOS_FACTURATableAdapter.Fill(this.DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_RESULTADOS_RECEPCION_PRODUCTOS_FACTURA, "674743464564564");


            Listar_Recepciones lis = new Listar_Recepciones();
            dt_Facturas.DataSource = lis.listarIVA();
          //  this.reportViewer1.RefreshReport();
        }

        private void dt_Facturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int  posicion = dt_Facturas.CurrentRow.Index;
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECEPCION_PRODUCTOS_FACTURA.Sp_DATOS_RECEPCION_FACTURA' Puede moverla o quitarla según sea necesario.
            this.Sp_DATOS_RECEPCION_FACTURATableAdapter.Fill(this.DataSet_RECEPCION_PRODUCTOS_FACTURA.Sp_DATOS_RECEPCION_FACTURA, dt_Facturas[4,posicion].Value.ToString());
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_LISTAR_PRODUCTOS_RECEPCION_FACTURA' Puede moverla o quitarla según sea necesario.
            this.SP_LISTAR_PRODUCTOS_RECEPCION_FACTURATableAdapter.Fill(this.DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_LISTAR_PRODUCTOS_RECEPCION_FACTURA, dt_Facturas[4, posicion].Value.ToString());
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_RESULTADOS_RECEPCION_PRODUCTOS_FACTURA' Puede moverla o quitarla según sea necesario.
            this.SP_RESULTADOS_RECEPCION_PRODUCTOS_FACTURATableAdapter.Fill(this.DataSet_RECEPCION_PRODUCTOS_FACTURA.SP_RESULTADOS_RECEPCION_PRODUCTOS_FACTURA, dt_Facturas[4, posicion].Value.ToString());
            this.reportViewer1.RefreshReport();


        }
    }
}
