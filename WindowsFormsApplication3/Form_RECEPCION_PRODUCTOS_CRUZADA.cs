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
    public partial class Form_RECEPCION_PRODUCTOS_CRUZADA : Form
    {
        public Form_RECEPCION_PRODUCTOS_CRUZADA()
        {
            InitializeComponent();
        }

        private void Form_RECEPCION_PRODUCTOS_CRUZADA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_AÑO' Puede moverla o quitarla según sea necesario.
          
        }

        private void dt_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            this.SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter.Fill(this.DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_AÑO,dt_fecha_inicio.Value.Date,dt_fecha_fin.Value.Date);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_TOTAL' Puede moverla o quitarla según sea necesario.
            this.SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter.Fill(this.DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_TOTAL, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);

            this.reportViewer1.RefreshReport();
        }

        private void dt_fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            this.SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter.Fill(this.DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_AÑO, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_TOTAL' Puede moverla o quitarla según sea necesario.
            this.SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter.Fill(this.DataSet_REPECION_COMPRAS_CRUZADA.SP_ANLITICS_COMPRA_PRO_TOTAL, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);

            this.reportViewer1.RefreshReport();
        }
    }
}
