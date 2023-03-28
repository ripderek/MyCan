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
    public partial class MessageBox_Oferta_Accion : Form
    {
        public MessageBox_Oferta_Accion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; //DESHABILITAR

        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore; //EDITAR
        }
    }
}
