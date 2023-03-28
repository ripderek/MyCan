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
    public partial class frm_Cita_Terminada : Form
    {
        int detalle_cita_;
        public frm_Cita_Terminada(int detalle_cita)
        {
            detalle_cita_ = detalle_cita;
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            //  public csCitas(int id_d_c_ , string est_, string ho_leg,  DateTime fecha_pos_, string hora_d_,int ac)
            string hora_llega = txtHora.Text+":"+TxtMinutos.Text;
            csCitas objcitas = new csCitas(detalle_cita_,hora_llega);
            notifi_cita_terminada.EnabledNoti = true;
        }
    }
}
