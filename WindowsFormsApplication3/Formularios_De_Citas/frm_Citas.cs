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
    public partial class frm_Citas : Form
    {
        int id_empleado_agenda;
        int fila;
        int posicion;
        private DateTime fecha_actual = DateTime.UtcNow.Date;
        public frm_Citas(int ID_EMPLEADO_A)
        {
            id_empleado_agenda = ID_EMPLEADO_A;
            InitializeComponent();
            metroDateTime1.Value = fecha_actual;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nueva_Cita_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_Agregar_Cita(id_empleado_agenda));
        }

        private void frm_Citas_Load(object sender, EventArgs e)
        {
            try
            {
                csListarCitas objcitas = new csListarCitas();
                objcitas.fech = metroDateTime1.Value;
                dtgv_Citas.DataSource = objcitas.listarCitasD();
            }
            catch(Exception ne)
            {
                MessageBox.Show(ne.Message);
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                csListarCitas objcitas = new csListarCitas();
                objcitas.fech = metroDateTime1.Value;
                dtgv_Citas.DataSource = objcitas.listarCitasD();
            }
            catch (Exception ne)
            {
                MessageBox.Show(ne.Message);
            }
        }

        private void dtgv_Citas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ABRIR LAS OPCIONES DE LA CITA
                posicion = dtgv_Citas.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                int id_detalle_cita = int.Parse((dtgv_Citas[12, posicion].Value.ToString()));
                //MessageBox.Show(id_detalle_cita.ToString());
                Personalizacion per = new Personalizacion(new frm_Editar_CIta(id_detalle_cita));
                try
                {
                    csListarCitas objcitas = new csListarCitas();
                    objcitas.fech = metroDateTime1.Value;
                    dtgv_Citas.DataSource = objcitas.listarCitasD();
                }
                catch (Exception ne)
                {
                    MessageBox.Show(ne.Message);
                }
            }
            catch(Exception ne)
            {
                MessageBox.Show(ne.Message);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Estado")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmEstado"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Nombre Cliente")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmNombreCli"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellido Cliente")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmApellidoCli"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Nombre Atendedor")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmNombreEmpleAtender"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellido Atendedor")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmApellidoEmpleAten"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Nombre Agendador")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmNombreEmpleAgen"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Apellido Agendador")
            {

                dtgv_Citas.CurrentCell = null;
                foreach (DataGridViewRow fila in dtgv_Citas.Rows)
                {
                    fila.Visible = fila.Cells["clmApellidoEmpleAgen"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }
    }
}
