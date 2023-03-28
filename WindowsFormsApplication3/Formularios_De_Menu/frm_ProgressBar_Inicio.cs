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
    public partial class frm_ProgressBar_Inicio : Form
    {
        public frm_ProgressBar_Inicio()
        {
            InitializeComponent();
        }
        int contador;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador + 1;
            //this.lblContador.Text = contador.ToString();
            this.pg_procesamiento.Value=contador;
            if (contador == 100)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
