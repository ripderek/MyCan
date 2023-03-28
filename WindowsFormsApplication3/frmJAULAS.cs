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
    public partial class frmJAULAS : Form
    {
        public frmJAULAS()
        {
            InitializeComponent();
        }

        private void uI_ShadowPanel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecintos_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion( new frmRecintos());
        }
    }
}
