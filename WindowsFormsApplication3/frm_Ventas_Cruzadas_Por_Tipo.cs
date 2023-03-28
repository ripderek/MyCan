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
    public partial class frm_Ventas_Cruzadas_Por_Tipo : Form
    {
        string TIPO_;
        public frm_Ventas_Cruzadas_Por_Tipo(string tipo)
        {
            TIPO_ = tipo;
            InitializeComponent();
        }

        private void frm_Ventas_Cruzadas_Por_Tipo_Load(object sender, EventArgs e)
        {
            dt_fecha_inicio.Value = DateTime.UtcNow;
            dt_fecha_fin.Value = DateTime.UtcNow;
            if (TIPO_ == "General")
            {
                this.SP_ANALITICS_VENTA_PRO_AÑOTableAdapter.Fill(this.DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO, TIPO_, dt_fecha_inicio.Value, dt_fecha_fin.Value, 1);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO' Puede moverla o quitarla según sea necesario.
                this.SP_ANALITICS_VENTA_PRO_AÑOTableAdapter.Fill(this.DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO, TIPO_, dt_fecha_inicio.Value, dt_fecha_fin.Value, 2);
                this.reportViewer1.RefreshReport();
            }
        }

        private void dt_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            if (TIPO_ == "General")
            {
                this.SP_ANALITICS_VENTA_PRO_AÑOTableAdapter.Fill(this.DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO, TIPO_, dt_fecha_inicio.Value, dt_fecha_fin.Value, 1);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO' Puede moverla o quitarla según sea necesario.
                this.SP_ANALITICS_VENTA_PRO_AÑOTableAdapter.Fill(this.DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO, TIPO_, dt_fecha_inicio.Value, dt_fecha_fin.Value, 2);
                this.reportViewer1.RefreshReport();
            }
        }

        private void dt_fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            if (TIPO_ == "General")
            {
                this.SP_ANALITICS_VENTA_PRO_AÑOTableAdapter.Fill(this.DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO, TIPO_, dt_fecha_inicio.Value, dt_fecha_fin.Value, 1);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO' Puede moverla o quitarla según sea necesario.
                this.SP_ANALITICS_VENTA_PRO_AÑOTableAdapter.Fill(this.DataSet_CRUZADA_POR_TIPOS.SP_ANALITICS_VENTA_PRO_AÑO, TIPO_, dt_fecha_inicio.Value, dt_fecha_fin.Value, 2);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
