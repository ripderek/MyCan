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
    public partial class frm_Historia_Clinica_Nueva : Form
    {
        int paciente_id;
        public frm_Historia_Clinica_Nueva(int id_p =0)
        {
            paciente_id = id_p;
            InitializeComponent();
        }

        private void frm_Historia_Clinica_Nueva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Historia_Clinica_Nuevo_Mejorada.SP_VER_DATOS_PACIENTE_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter.Fill(this.DataSet_Historia_Clinica_Nuevo_Mejorada.SP_VER_DATOS_PACIENTE_DATASET01, paciente_id);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Historia_Clinica_Nuevo_Mejorada.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_Historia_Clinica_Nuevo_Mejorada.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Historia_Clinica_Nuevo_Mejorada.SP_VER_DATOS_HISOTRIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter.Fill(this.DataSet_Historia_Clinica_Nuevo_Mejorada.SP_VER_DATOS_HISOTRIA_DATASET01, paciente_id);

            this.reportViewer1.RefreshReport();
        }
    }
}
