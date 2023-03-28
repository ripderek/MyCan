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
    public partial class frmClientes : Form
    {
        string cmb_cedula;
        int fila;
        int posicion;
        string usr;
        public frmClientes(string User)
        {
            usr = User;
            InitializeComponent();
            try
            {
                Listar_ClientesDGV listC = new Listar_ClientesDGV();
                dataGridView1.DataSource = listC.listarClientes();
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.White;
        }

        private void piNew_Click(object sender, EventArgs e)
        {

            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.C_Agregar1 == 1)
            { Personalizacion per31 = new Personalizacion(new frm_MC_Crear_Modificar_Cliente()); }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
           
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_Ayuda_FDTGV());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            cmb_cedula = (dataGridView1[2, posicion].Value.ToString());
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.C_Modificar1 == 1)
            { Personalizacion per = new Personalizacion(new frm_MC_Crear_Modificar_Cliente(1, cmb_cedula)); }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }


            
            
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

            if (cmb_Tipo.Text == "Nombres")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmNombre"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellidos")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmApellidos"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Identificacion")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmIdentificacion"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Celular")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmCelular"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Direccion")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmDireccion"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Ocupacion")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmIOcupacion"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }

        }
    }
}
