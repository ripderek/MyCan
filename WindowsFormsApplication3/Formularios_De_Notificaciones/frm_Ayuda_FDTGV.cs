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
    public partial class frm_Ayuda_FDTGV : Form
    {
        int cont=0 ;
        public frm_Ayuda_FDTGV()
        {
            InitializeComponent();
            panel2.Visible = false; panel2.Enabled = false;
            panel3.Visible = false; panel3.Enabled = false;
            panel4.Visible = false; panel4.Enabled = false;

        }

        private void btnCerar_MouseEnter(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Red;

            btnCerar.ForeColor = Color.Black;
        }

        private void btnCerar_MouseLeave(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Transparent;
            btnCerar.ForeColor = Color.White;
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (panel2.Visible == false&&cont==0)
            {
                panel1.Visible = false; panel1.Enabled = false;
                panel2.Visible = true; panel2.Enabled = true;
                panel2.BringToFront(); btnGuardar.BringToFront();
                cont = 1;

            }
            else if (panel3.Visible == false  &&cont==1)
            {
                panel2.Visible = false; panel2.Enabled = false;
                panel3.Visible = true; panel3.Enabled = true; panel3.BringToFront(); btnGuardar.BringToFront();
                cont = 2;

            }
            else if (panel4.Visible == false &&cont==2)
            {
                panel3.Visible = false; panel3.Enabled = false;
                panel4.Visible = true; panel4.Enabled = true;
                panel4.BringToFront(); btnGuardar.BringToFront();
                cont = 3;

            }
            else if (panel1.Visible == false &&cont==3 )
            {
                panel4.Visible = false; panel4.Enabled = false;
                panel1.Visible = true; panel1.Enabled = true;
                panel1.BringToFront(); btnGuardar.BringToFront();
                cont = 0;
            }
        }
    }
}
