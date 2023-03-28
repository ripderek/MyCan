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
    public partial class frm_Report_FACS : Form
    {
        public frm_Report_FACS()
        {
            InitializeComponent();
        }

        private void dt_Facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Report_FACS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
        
            csNUMERO_FACTURAS NUM_FACTS = new csNUMERO_FACTURAS();
            dt_Facturas.DataSource = NUM_FACTS.listarIVA();
        }

        private void dt_Facturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dt_Facturas.CurrentRow.Index;
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;



            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_DATOS_DETALLE_FACTURA_DATASET' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_DATOS_DETALLE_FACTURA_DATASET,int.Parse(dt_Facturas[0,posicion].Value.ToString()));
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASET' Puede moverla o quitarla según sea necesario.
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASET, int.Parse(dt_Facturas[0, posicion].Value.ToString()));
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_RESULTADOS_DETALLE_FACTURA_DATASET' Puede moverla o quitarla según sea necesario.
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_RESULTADOS_DETALLE_FACTURA_DATASET, int.Parse(dt_Facturas[0, posicion].Value.ToString()));
            this.reportViewer1.RefreshReport();


        }
    }
}
