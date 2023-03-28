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
    public partial class frm_Listar_Paciente_Receta : Form
    {
        int posicion;
        int fila;
        private string paciente;
        private int paciente_ID;    

        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        public int Paciente_ID
        {
            get { return paciente_ID; }
            set { paciente_ID = value; }
        }
        public frm_Listar_Paciente_Receta()
        {
            InitializeComponent();
        }

        private void frm_Listar_Paciente_Receta_Load(object sender, EventArgs e)
        {
            Listar_PacientesDTGV paciente = new Listar_PacientesDTGV();
            dtg_Empleados.DataSource = paciente.listarPAC();
        }

        private void dtg_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtg_Empleados.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            txtMedicamento.Text = (dtg_Empleados[1, posicion].Value.ToString());
            Paciente_ID = int.Parse(dtg_Empleados[0, posicion].Value.ToString());
        }

        private void uI_ButtonMaterial1_Click(object sender, EventArgs e)
        {
            Paciente = txtMedicamento.Text; 
        }
    }
}
