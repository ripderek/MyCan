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
    public partial class frm_FACTURA_ELECTRONICAXD : Form
    {
        public frm_FACTURA_ELECTRONICAXD()
        {
            InitializeComponent();
        }

        private void frm_FACTURA_ELECTRONICAXD_Load(object sender, EventArgs e)
        {
            csFactura numfac = new csFactura();
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_DATOS_DETALLE_FACTURA_DATASET' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_DATOS_DETALLE_FACTURA_DATASET, numfac.ID_Ultima_Factura);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASET' Puede moverla o quitarla según sea necesario.
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASET, numfac.ID_Ultima_Factura);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_FACTURA_ELECTRONICA.SP_RESULTADOS_DETALLE_FACTURA_DATASET' Puede moverla o quitarla según sea necesario.
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter.Fill(this.DataSet_FACTURA_ELECTRONICA.SP_RESULTADOS_DETALLE_FACTURA_DATASET, numfac.ID_Ultima_Factura);

            this.reportViewer1.RefreshReport();
        }
    }
}
