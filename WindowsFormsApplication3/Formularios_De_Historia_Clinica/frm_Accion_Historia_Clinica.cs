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
    public partial class frm_Accion_Historia_Clinica : Form
    {
        int id_pac;
        public frm_Accion_Historia_Clinica(int id_paciente)
        {
            id_pac = id_paciente;
            InitializeComponent();
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_Registrar_Historial_Clinico(id_pac));
        }

        private void btn_Ver_Historial_Click(object sender, EventArgs e)
        {
         //   frm_Historia_Clinica_Nueva verh = new frm_Historia_Clinica_Nueva(id_pac);
          //  verh.Show();
            frm_VER_HISTORIA veg = new frm_VER_HISTORIA(id_pac);
            veg.Show();
        }

        private void btn_Ver_Historial_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
