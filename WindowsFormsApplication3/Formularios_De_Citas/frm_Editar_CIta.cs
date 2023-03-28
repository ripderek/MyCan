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
    public partial class frm_Editar_CIta : Form
    {
        int detalle_cita_id_;
        public frm_Editar_CIta(int detalle_cita)
        {
            detalle_cita_id_ = detalle_cita;
            InitializeComponent();
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form formularioActivo = null;
        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            panel_opcion.Controls.Add(nuevoFormulario);
            panel_opcion.Tag = nuevoFormulario;
            // nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }

        private void btnCita_Terminada_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Cita_Terminada(detalle_cita_id_));
        }

        private void btn_Cita_Nunca_LLegó_Click(object sender, EventArgs e)
        {
            csCitas objcita = new csCitas(detalle_cita_id_);
            notifi_no_llego.EnabledNoti = true;
        }

        private void btnCita_Pospuesta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Cita_Pospuesta(detalle_cita_id_));
        }
    }
}
