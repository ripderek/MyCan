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
    public partial class frmListar_Empleados_Receta : Form
    {
        int posicion;
        int fila;
        private string doctor;
        private int doctor_ID;

        public string Doctor_
        {
            get { return doctor; }
            set { doctor = value; }
        }
        
        public int Doctor_ID_
        {
            get { return doctor_ID; }
            set { doctor_ID = value; }
        }
        public frmListar_Empleados_Receta()
        {
            InitializeComponent();
        }

        private void frmListar_Empleados_Receta_Load(object sender, EventArgs e)
        {
            ListarEmpleadoDGV lis = new ListarEmpleadoDGV();
            dtg_Empleados.DataSource = lis.listarEmpleado();
        }

        private void uI_ButtonMaterial1_Click(object sender, EventArgs e)
        {
            Doctor_ = txtMedicamento.Text;
        }

        private void dtg_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtg_Empleados.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            txtMedicamento.Text = (dtg_Empleados[0, posicion].Value.ToString()) +" "+ (dtg_Empleados[1, posicion].Value.ToString());
            Doctor_ID_ = int.Parse(dtg_Empleados[8, posicion].Value.ToString());
        }
    }
}
