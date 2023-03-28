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
    public partial class frm_Cita_Pospuesta : Form
    {
        int detalle_cita_id_;
        public frm_Cita_Pospuesta(int id)
        {
            detalle_cita_id_ = id;
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string hora = txtHora.Text+":"+TxtMinutos.Text;
            csCitas objcitas = new csCitas(detalle_cita_id_,datetimeFecha_Destinada.Value,hora);
            notifi_cita_pospuesta.EnabledNoti = true;
        }
    }
}
