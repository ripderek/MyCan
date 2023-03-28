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
    public partial class frm_VER_TOP_5_POR_TIPOS : Form
    {
        string TIPO_;
        public frm_VER_TOP_5_POR_TIPOS(string tipo)
        {
            TIPO_ = tipo;
            InitializeComponent();
        }

        private void frm_VER_TOP_5_POR_TIPOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS' Puede moverla o quitarla según sea necesario.
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS, Convert.ToDateTime("07/03/2022"), Convert.ToDateTime("01/01/2030"),TIPO_, 1);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void dt_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date, TIPO_, 2);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void dt_fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date, TIPO_, 2);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle.Checked == false)
            {
                //AQUI SE DESACTIVA LA FECHA DE INICIO Y DE FIN Y SE TOMA LA FECHA CON EL ITEM SELECCIONADO DEL COMBOBOX
                dt_fecha_inicio.Enabled = false;
                dt_fecha_fin.Enabled = false;
                dt_fecha.Enabled = true; cmbFiltro.Enabled = true;
                if (cmbFiltro.SelectedItem != null)
                {
                    COMBO_CAMBIA();
                }
            }
            else
            {
                dt_fecha_inicio.Enabled = true;
                dt_fecha_fin.Enabled = true;
                dt_fecha.Enabled = false; cmbFiltro.Enabled = false;
                this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS, dt_fecha_inicio.Value.Date, dt_fecha_fin.Value.Date, TIPO_,2);
                this.reportViewer1.RefreshReport();
                this.reportViewer2.RefreshReport();
                this.reportViewer3.RefreshReport();


            }
        }

        private void dt_fecha_ValueChanged(object sender, EventArgs e)
        {
            COMBO_CAMBIA();

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMBO_CAMBIA();
        }
        private void COMBO_CAMBIA()
        {
            if (cmbFiltro.SelectedItem != null)
            {
                if (cmbFiltro.SelectedItem == "Año")
                                    this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS,  dt_fecha.Value.Date, dt_fecha.Value.Date, TIPO_,3);

                else if (cmbFiltro.SelectedItem == "Mes")
                                                        this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS,  dt_fecha.Value.Date, dt_fecha.Value.Date, TIPO_,4);
                else if (cmbFiltro.SelectedItem == "Dia")
                    this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS, dt_fecha.Value.Date, dt_fecha.Value.Date, TIPO_, 5);
                else if (cmbFiltro.SelectedItem == "Todo")
                    this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.Fill(this.DataSet_TOP_5_POR_TIPOS.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS, dt_fecha.Value.Date, dt_fecha.Value.Date, TIPO_, 1);
                this.reportViewer1.RefreshReport();
                this.reportViewer2.RefreshReport();
                this.reportViewer3.RefreshReport();
            }

        }
    }
}
