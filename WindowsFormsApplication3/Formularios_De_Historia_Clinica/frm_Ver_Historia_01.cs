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
    public partial class frm_Ver_Historia_01 : Form
    {
        int paciente_id;
        public frm_Ver_Historia_01( int paciente)
        {
            InitializeComponent();
            paciente_id = paciente;
        }

        private void frm_Ver_Historia_01_Load(object sender, EventArgs e)
        {
        
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
