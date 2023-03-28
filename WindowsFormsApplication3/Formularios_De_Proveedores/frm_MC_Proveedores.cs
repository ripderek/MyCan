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
    public partial class frm_MC_Proveedores : Form
    {
        int act;
        string cmb_cedula;
        int fila;
        int posicion;
        string usr;
        public frm_MC_Proveedores(string user)
        {
            usr = user;
            InitializeComponent();
            try
            {
                Listar_ProveedoresDGV listP = new Listar_ProveedoresDGV();
                dataGridView1.DataSource = listP.listarProveedores();
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Organizar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_MC_Modificar_CrearProveedor(1));
        }

        private void uI_ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uI_ShadowPanel3_Click(object sender, EventArgs e)
        {
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.Pp_Agregar1 == 1)
            {
                Personalizacion per = new Personalizacion(new frm_MC_Modificar_CrearProveedor(0));
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
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
            cmb_cedula = (dataGridView1[3, posicion].Value.ToString());

            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.Pp_Modificar1 == 1)
            {
                Personalizacion per = new Personalizacion(new frm_MC_Modificar_CrearProveedor(1, cmb_cedula));
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombre Compañia")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmNombreCompania"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Nombre")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmNombre"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellido")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmApellido"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
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
            else if (cmb_Tipo.Text == "Celular")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmCelular"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Numero Sucursal")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmNSucursal"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
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
        }
    }
}
