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
    public partial class frmDatos_Veterinaria : Form
    {
        public frmDatos_Veterinaria()
        {
            InitializeComponent();
        }

        private void frmDatos_Veterinaria_Load(object sender, EventArgs e)
        {
            csVeterinaria objVete = new csVeterinaria(1);
            txtNombres_Vete.Text = objVete.NombreV;
            txtDireccion_Vete.Text = objVete.DireccionV;
            lblRuc_Vete.Text = objVete.RucV;
            lblCelular_Vete.Text = objVete.CelularV;
            lblNum_Sucursal.Text = objVete.NumeroSucursalV;
        }


    }
}
