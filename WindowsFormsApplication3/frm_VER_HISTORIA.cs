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
    public partial class frm_VER_HISTORIA : Form
    {
        int pac;
        public frm_VER_HISTORIA(int paciente_id)
        {
            pac = paciente_id;
            InitializeComponent();
        }

        private void frm_VER_HISTORIA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_HISTORIA.SP_VER_DATOS_PACIENTE_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter.Fill(this.DataSet_HISTORIA.SP_VER_DATOS_PACIENTE_DATASET01, pac);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_HISTORIA.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_HISTORIA.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_HISTORIA.SP_DATASET_HISTORIAL' Puede moverla o quitarla según sea necesario.
            this.SP_DATASET_HISTORIALTableAdapter.Fill(this.DataSet_HISTORIA.SP_DATASET_HISTORIAL, pac);

            this.reportViewer1.RefreshReport();
        }
    }
}
