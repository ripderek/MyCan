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
    public partial class frmCrearRecetaMedica : Form
    {
        private int doctor_ID;
        private int paciente_ID;
        private int medicamento_ID;
        private int posicion;
        private int fila;
        public frmCrearRecetaMedica()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            //AQUI ABRIR EL FORMULARIO DE DOCTORES
            frmListar_Empleados_Receta listaemple = new frmListar_Empleados_Receta();
            if (listaemple.ShowDialog() == DialogResult.OK)
            {
                txtDoctor.Text = listaemple.Doctor_;
                doctor_ID = listaemple.Doctor_ID_;
            }
        }

        private void uI_ShadowPanel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            //AQUI ABRIR PARA SELECCION EL PACIENTE 
            frm_Listar_Paciente_Receta paciente = new frm_Listar_Paciente_Receta();
            if (paciente.ShowDialog() == DialogResult.OK)
            {
                txtPaciente.Text = paciente.Paciente;
                //lblID.Visible = true;
               // lblID.Text = paciente.Paciente_ID.ToString();
                paciente_ID = paciente.Paciente_ID;
            }
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            //AQUI ABRIR PARA SELEECIONAR EL MEDICAMENTO 
            frmListar_Medicamentos_RECETA medicamentos = new frmListar_Medicamentos_RECETA();
            if (medicamentos.ShowDialog() == DialogResult.OK)
            {
                txtMedicamento.Text = medicamentos.Medicamento;            
               // lblID.Visible = true;
                lblID.Text = medicamentos.Medicento_ID.ToString();
                medicamento_ID = medicamentos.Medicento_ID;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //VERFICIAR REPETIDOS
            csValidarCampos Valida = new csValidarCampos();
            Valida.TextBoxVacios(txtMedicamento,"");
            if (Valida.comprobar == 1 && !string.IsNullOrWhiteSpace(txtDosis.Text) && !string.IsNullOrWhiteSpace(txtIndicacion.Text))
            {
                int repetido = 0;
                for (int i = 0; i < dtg_Productos.RowCount; i++)
                {
                    if (medicamento_ID == int.Parse(dtg_Productos.Rows[i].Cells[0].Value.ToString()))  //.Parse(dtg_Productos.Rows[i].Cells[4].Value.ToString())
                    {
                        repetido = 1;
                    }
                }
                if (repetido == 1)
                {
                    MessageBox.Show("ESTE MEDICAMENTO SE ENCUENTRA EN EL REGISTRO");
                }
                else
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dtg_Productos);
                    fila.Cells[0].Value = medicamento_ID.ToString();
                    fila.Cells[1].Value = txtMedicamento.Text;
                    fila.Cells[2].Value = txtDosis.Text;
                    fila.Cells[3].Value = txtIndicacion.Text;
                    dtg_Productos.Rows.Add(fila);
                    txtMedicamento.Text = "";
                    txtDosis.Text = "";
                    txtIndicacion.Text = "";
                }
            }
            else
            {
                MessageBox_Campos_Vacios camposVacios = new MessageBox_Campos_Vacios();
                camposVacios.ShowDialog();
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtDoctor,"");
            csValidarCampos valida1 = new csValidarCampos();
            valida1.TextBoxVacios(txtPaciente,"");
            if (valida.comprobar == 1 && valida1.comprobar == 1 && dtg_Productos.RowCount != 0)
            {
                //AQUI SE REGISTRA PRIMERO LA RECETA MEDICA 
                csRecetaMedica receta = new csRecetaMedica(paciente_ID, doctor_ID);
                //LUEGO EL DETALLE MEDICO 
                int ver = 0;
                foreach (DataGridViewRow row in dtg_Productos.Rows)
                {
                    csRecetaMedica detalle_receta = new csRecetaMedica(int.Parse(row.Cells["medicamento_id"].Value.ToString()), row.Cells["dosis_m"].Value.ToString(), row.Cells["indicacion_m"].Value.ToString());
                    ver = detalle_receta.verficar;
                }
                if (receta.verficar == 1 && ver == 1)
                {
                    notifica.EnabledNoti = true;
                    csRecetaMedica rec = new csRecetaMedica();
                    fmr_RECETA_VER ver_receta = new fmr_RECETA_VER(rec.N_receta_);
                    ver_receta.Show();
                }
            }
            else
            {
                MessageBox_Campos_Vacios camposVacios = new MessageBox_Campos_Vacios();
                camposVacios.ShowDialog();
            }
        }
        //SE ESTA TRABAJANDO EN ESTA PARTE
        private void dtg_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                posicion = dtg_Productos.CurrentRow.Index;
                dtg_Productos.Rows.Remove(dtg_Productos.CurrentRow);
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                btnAñadir.Visible = false; btnAñadir.Enabled = false;
                btnGuardar.Visible = true; btnGuardar.Enabled = true; btnGuardar.BringToFront();
                posicion = dtg_Productos.CurrentRow.Index;
                medicamento_ID = int.Parse(dtg_Productos[0, posicion].Value.ToString());
                txtMedicamento.Text = dtg_Productos[1, posicion].Value.ToString();
                txtDosis.Text = dtg_Productos[2, posicion].Value.ToString();
                txtIndicacion.Text = dtg_Productos[3, posicion].Value.ToString();
                dtg_Productos.Enabled = false;
            }
        }
        //AQUI GUARDAR EL CAMBIO
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtg_Productos.Enabled = true;
            btnGuardar.Visible = false; btnGuardar.Enabled = false;
            btnAñadir.Visible = true; btnAñadir.Enabled = true; btnAñadir.BringToFront();
            dtg_Productos[0, posicion].Value = medicamento_ID.ToString();
            dtg_Productos[1, posicion].Value = txtMedicamento.Text;
            dtg_Productos[2, posicion].Value = txtDosis.Text;
            dtg_Productos[3, posicion].Value = txtIndicacion.Text;
        }

        private void btnGuardar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
