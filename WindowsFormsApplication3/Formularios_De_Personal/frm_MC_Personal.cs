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
    public partial class frm_MC_Personal : Form  //ARREGLAR ESTE FORMULARIO LEER BIEN EL CODIGO YA QUE ESTE FORMULARIO SIRVE
    {                                            // PARA LOS EMPLEADOS COMO PARA LOS CLIENTES 
        int act;
        string cmb_cedula;
        int fila;
        int posicion;
        string usr;
        public frm_MC_Personal(string user="", int accion = 1)
        {
            usr = user;
            InitializeComponent();
            btnConfig.Visible = false; btnConfig.Enabled = false;
            act = accion;
            if (accion == 0)
            {
                btncerrar.Visible = true;
                lbltipo.Visible = false;
                cmb_Tipo.Visible = false;
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
            }
            else
            {
               
            }
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            if (act == 0)
            {
                Personalizacion per = new Personalizacion(new frmCliente_Agregar_Modificar(4));
            }
            else
            {
                Personalizacion per = new Personalizacion(new frm_MC_Modificar_Crear_Personal(2,cmb_cedula));
            }
        }

        private void uI_ShadowPanel3_Click(object sender, EventArgs e)
        {
            if (act == 1)  ///
            {
                csUsuarios objuser = new csUsuarios(usr, true);
                if (objuser.P_Agregar1 == 1)
                {
                    Personalizacion per = new Personalizacion(new frm_MC_Modificar_Crear_Personal(1));
                }
                else
                {
                    messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                    men1.ShowDialog();
                }


            }
                /*
            else
            {
                csUsuarios objuser = new csUsuarios(usr, true);
                if (objuser.P_Agregar1 == 1)
                {
                    Personalizacion per = new Personalizacion(new frmCliente_Agregar_Modificar(1));
                }
                else
                {
                    messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                    men1.ShowDialog();
                }
            }
                 * */

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.P_Agregar1 == 1 && objuser.P_Modificar1==1)
            {
                panelVista.Size = new Size(1239, 636);
                panelVista.BringToFront();
                AbrirFormulario(new frm_MC_Modificar_Crear_Personal(0));
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
           
        }

        private Form formularioActivo = null;
        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
           panelVista.Controls.Add(nuevoFormulario);
           panelVista.Tag = nuevoFormulario;
            // nuevoFormulario.BringToFront();
            nuevoFormulario.Show();


        }

        private void frm_MC_Personal_Load(object sender, EventArgs e)
        {
            if (act == 1) //OSEA QUE SE USARÁN LOS DATOS DE EMPLEADOS 
            {
                ListarEmpleadoDGV objmple = new ListarEmpleadoDGV();
                dataGridView1.DataSource = objmple.listarEmpleado();
            }
  
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AQUI PARA EDITAR XD EL PERSONAL O CLIENTE XD 

            //04 CEDULA AUN NO SE VALIDA SI HAY CEDULAS REPETIDAS X LO QUE X EL MOMENTO NO DEBERIAN DE INGRESARSE PARA NO CREAR CONFLICTOS X FAVOR
    
                posicion = dataGridView1.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                cmb_cedula = (dataGridView1[3, posicion].Value.ToString());

                if (act == 1) //EDITAR EL PERSONAL SEGUN LA CEDULA 
                {
                    csUsuarios objuser = new csUsuarios(usr, true);
                    if  (objuser.P_Modificar1 == 1)
                    {
                        Personalizacion per = new Personalizacion(new frm_MC_Modificar_Crear_Personal(2, cmb_cedula));
                    }
                    else
                    {
                        messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                        men1.ShowDialog();
                    }



                  
                }
                else
                {
                    //En caso de ser 0 se tiene que editar los datos del cliente
                }
            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frm_Ayuda_FDTGV());
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "Nombres")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmNombres"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
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
            else if (cmb_Tipo.Text == "Tipo Identificacion")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmTipoIdentifica"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
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
            else if (cmb_Tipo.Text == "Area")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmArea"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Tipo")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmTipo"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
            else if (cmb_Tipo.Text == "Oficina")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmOficina"].Value.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper());
                }
            }
        }
    }
}
