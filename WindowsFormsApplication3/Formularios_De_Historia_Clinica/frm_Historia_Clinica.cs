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
    public partial class frm_Historia_Clinica : Form
    {
        int fila;
        int posicion;
        public frm_Historia_Clinica()
        {
            InitializeComponent();
        }

        private void frm_Historia_Clinica_Load(object sender, EventArgs e)
        {
            Listar_PacientesDTGV oblispac = new Listar_PacientesDTGV();
            dtgv_Pacientes.DataSource = oblispac.listarPAC();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_Pacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //AQUI ABRIR LAS CONFIGURACIONES DEL HISTORIAL CLINICO
            posicion = dtgv_Pacientes.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
           int ID_PAC = int.Parse(dtgv_Pacientes[0, posicion].Value.ToString());
           Personalizacion per = new Personalizacion(new frm_Accion_Historia_Clinica(ID_PAC));
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombre Paciente")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmNombrePaciente"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Especie")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmEspecie"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Raza")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmRaza"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Sexo")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmSexo"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Color")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmColor"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellido Cliente")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmApellidoClie"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Identificacion Cliente")
            {

                dtgv_Pacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Pacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmIdentificacionClien"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }
    }
}
