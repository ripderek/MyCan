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
    public partial class frm_CITA_ESTADISTICA : Form
    {
        public frm_CITA_ESTADISTICA()
        {
            InitializeComponent();
        }

        private void frm_CITA_ESTADISTICA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_SI_SE' Puede moverla o quitarla según sea necesario.
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_SI_SE, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_NO_SE' Puede moverla o quitarla según sea necesario.
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_NO_SE,dt_fecha_inicio.Value.Date,dt_fecha_fin.Value.Date);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_ESTADISTICA_CITAS.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NO' Puede moverla o quitarla según sea necesario.
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NO,dt_fecha_inicio.Value.Date,dt_fecha_fin.Value.Date);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void dt_fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NO, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_NO_SE, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_SI_SE, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void dt_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NO, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_NO_SE, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter.Fill(this.DataSet_ESTADISTICA_CITAS.SP_ANALITICS_GRAFICA_PASTEL_SI_SE, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
