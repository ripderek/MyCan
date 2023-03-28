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
    public partial class frm_Ver_Registrar_Historial_Clinico : Form
    {
        int paciente_id;
        public frm_Ver_Registrar_Historial_Clinico(int pac)
        {
            paciente_id = pac;
            InitializeComponent();
        }

        private void frm_Ver_Registrar_Historial_Clinico_Load(object sender, EventArgs e)
        {
            csHistorial_Clinico ultimoid = new csHistorial_Clinico();
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Registrar_Historial_Clinico.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_Registrar_Historial_Clinico.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Registrar_Historial_Clinico.SP_VER_DATOS_PACIENTE_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter.Fill(this.DataSet_Registrar_Historial_Clinico.SP_VER_DATOS_PACIENTE_DATASET01, paciente_id);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Registrar_Historial_Clinico.SP_HISTORIA_CLINICA_RECIEN' Puede moverla o quitarla según sea necesario.
            this.SP_HISTORIA_CLINICA_RECIENTableAdapter.Fill(this.DataSet_Registrar_Historial_Clinico.SP_HISTORIA_CLINICA_RECIEN, ultimoid.Detalle_historial_id_);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Registrar_Historial_Clinico.SP_MEDICAMENTO_USADO_ULTIMO_DETALLE' Puede moverla o quitarla según sea necesario.
            this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter.Fill(this.DataSet_Registrar_Historial_Clinico.SP_MEDICAMENTO_USADO_ULTIMO_DETALLE, ultimoid.Detalle_historial_id_);

            this.reportViewer1.RefreshReport();
        }
    }
}
