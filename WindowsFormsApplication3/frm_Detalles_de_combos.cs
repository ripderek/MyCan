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
    public partial class frm_Detalles_de_combos : Form
    {
        public frm_Detalles_de_combos()
        {
            InitializeComponent();
        }

        private void frm_Detalles_de_combos_Load(object sender, EventArgs e)
        {
            csListarDetalleCombo objcombo = new csListarDetalleCombo();
            cmbCombos.DataSource = objcombo.CombosCombobox().Tables[0];
            cmbCombos.ValueMember = "Producto_ID";
            cmbCombos.DisplayMember = "NombreProducto";
            cmbCombos.SelectedItem = null;
        }

        private void cmbCombos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            csListarDetalleCombo objCombo = new csListarDetalleCombo();
            objCombo.IDcombo = int.Parse(cmbCombos.SelectedValue.ToString());
            dtg_DetalleCombo.DataSource = objCombo.listarDetalleCombo();
        }
    }
}
