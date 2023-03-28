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
    public partial class frmListar_Medicamentos_RECETA : Form
    {
        int posicion;
        int fila;
        private string medicamento;
        private int medicento_ID;    
        public string Medicamento
        {
            get { return medicamento; }
            set { medicamento = value; }
        }
        public int Medicento_ID
        {
            get { return medicento_ID; }
            set { medicento_ID = value; }
        }
        public frmListar_Medicamentos_RECETA()
        {
            InitializeComponent();
        }

        private void frmListar_Medicamentos_RECETA_Load(object sender, EventArgs e)
        {
            Listar_Medicamentos_DATA medicamentos = new Listar_Medicamentos_DATA();
            dtg_Empleados.DataSource = medicamentos.listarIVA();
        }

        private void dtg_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtg_Empleados.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            txtMedicamento.Text = (dtg_Empleados[1, posicion].Value.ToString());
            Medicento_ID = int.Parse(dtg_Empleados[0, posicion].Value.ToString());
        }

        private void uI_ButtonMaterial1_Click(object sender, EventArgs e)
        {
            Medicamento = txtMedicamento.Text;
        }
    }
}
