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
    public partial class frm_MC_Paciente : Form
    {
        int ID_PAC;
        int fila;
        int posicion;
        string usr;
        public frm_MC_Paciente(string user)
        {
            usr = user;
            InitializeComponent();
        }


        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
             csUsuarios objuser = new csUsuarios(usr, true);
             if (objuser.Pa_Agregar1 == 1)
             {
                 Personalizacion per = new Personalizacion(new frm_MC_Paciente_Agregar_Modificar(0));
                 Listar_PacientesDTGV oblispac = new Listar_PacientesDTGV();
                 dtgvPacientes.DataSource = oblispac.listarPAC();
             }
             else
             {
                 messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                 men1.ShowDialog();
             }
        }


        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void uI_PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Red;
            btncerrar.ForeColor = Color.White;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Transparent;
            btncerrar.ForeColor = Color.Black;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MC_Paciente_Load(object sender, EventArgs e)
        {
            Listar_PacientesDTGV oblispac = new Listar_PacientesDTGV();
            dtgvPacientes.DataSource = oblispac.listarPAC();
        }

        private void dtgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dtgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgvPacientes.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            ID_PAC = int.Parse(dtgvPacientes[0, posicion].Value.ToString());

            //MessageBox.Show("" + ID_PAC);

            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.Pa_Modificar1 == 1)
            {
                Personalizacion per = new Personalizacion(new frm_MC_Paciente_Agregar_Modificar(1, ID_PAC));
                Listar_PacientesDTGV oblispac = new Listar_PacientesDTGV();
                dtgvPacientes.DataSource = oblispac.listarPAC();
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombre Paciente")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmNombrePaciente"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Especie")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmEspecie"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Raza")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmRaza"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Sexo")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmSexo"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Color")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmColor"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellido Cliente")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmApellidoClie"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Identificacion Cliente")
            {

                dtgvPacientes.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgvPacientes.Rows)
                {
                    fila.Visible = fila.Cells["clmIdentificacionClien"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }
    }
}
