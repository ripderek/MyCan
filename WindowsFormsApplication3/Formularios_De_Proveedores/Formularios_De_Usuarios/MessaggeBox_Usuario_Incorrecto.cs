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
    public partial class MessaggeBox_Usuario_Incorrecto : Form
    {
        public MessaggeBox_Usuario_Incorrecto()
        {
            InitializeComponent();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador - 1;
            this.lblContador.Text = contador.ToString();
            if (contador == 0)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
        }
        int contador;
        private void MessaggeBox_Usuario_Incorrecto_Load(object sender, EventArgs e)
        {
            contador = 5;
            this.lblContador.Text = contador.ToString();
            this.timer1.Enabled = true;
        }
    }
}
