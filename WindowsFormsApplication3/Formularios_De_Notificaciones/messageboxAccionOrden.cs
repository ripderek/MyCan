﻿using System;
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
    public partial class messageboxAccionOrden : Form
    {
        public messageboxAccionOrden()
        {
            InitializeComponent();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; //ELIMINAR
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore; //EDITAR
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
