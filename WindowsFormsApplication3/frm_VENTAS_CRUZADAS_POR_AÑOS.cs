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
    public partial class frm_VENTAS_CRUZADAS_POR_AÑOS : Form
    {
        public frm_VENTAS_CRUZADAS_POR_AÑOS()
        {
            InitializeComponent();
        }

        private void frm_VENTAS_CRUZADAS_POR_AÑOS_Load(object sender, EventArgs e)
        {
            try
            {


            dt_fecha_inicio.Value= DateTime.UtcNow;
            dt_fecha_fin.Value = DateTime.UtcNow;
            // TODO: esta línea de código carga datos en la tabla 'DataSet_VENTAS_CRUZADAS_POR_AÑOS.SP_ANALITICS_VENTAS_MEN_AÑO' Puede moverla o quitarla según sea necesario.
            this.SP_ANALITICS_VENTAS_MEN_AÑOTableAdapter.Fill(this.DataSet_VENTAS_CRUZADAS_POR_AÑOS.SP_ANALITICS_VENTAS_MEN_AÑO,dt_fecha_inicio.Value.ToString(),dt_fecha_fin.Value.ToString(),1);

            this.reportViewer1.RefreshReport();

            }
            catch (Exception n)
            {
                MessageBox.Show("No se pudo cargar el formulario");
            }
        }

        private void dt_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {

            try
            {


            this.SP_ANALITICS_VENTAS_MEN_AÑOTableAdapter.Fill(this.DataSet_VENTAS_CRUZADAS_POR_AÑOS.SP_ANALITICS_VENTAS_MEN_AÑO, dt_fecha_inicio.Value.Date.ToString(), dt_fecha_fin.Value.Date.ToString(), 2);

            this.reportViewer1.RefreshReport();

            }
            catch (Exception n)
            {
                MessageBox.Show("No se pudo cargar el formulario");
            }
        }

        private void dt_fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            try
            {

            this.SP_ANALITICS_VENTAS_MEN_AÑOTableAdapter.Fill(this.DataSet_VENTAS_CRUZADAS_POR_AÑOS.SP_ANALITICS_VENTAS_MEN_AÑO, dt_fecha_inicio.Value.Date.ToString(), dt_fecha_fin.Value.Date.ToString(), 2);

            this.reportViewer1.RefreshReport();

            }
            catch (Exception n)
            {
                MessageBox.Show("No se pudo cargar el formulario");
            }
        }
    }
}
