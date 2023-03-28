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
    public partial class frm_Registrar_Historial_Clinico : Form
    {
        int paciente_ID;
        int posicion;
        int fila;
        string ur;
        int medica_id;
        public frm_Registrar_Historial_Clinico(int id_pac)
        {
            InitializeComponent();
            paciente_ID = id_pac;
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frm_Registrar_Historial_Clinico_Load(object sender, EventArgs e)
        {
            try
            {

            csPaciente ObjPacientes = new csPaciente(paciente_ID);
            txtNombrePac.Text = ObjPacientes.Nombre_Paciente_;
            txtEspecie.Text = ObjPacientes.TIPO_ESPECIE_;
            txtRaza.Text = ObjPacientes.TIPO_RAZA_;
            txtSexo.Text = ObjPacientes.Sexo_Paciente_;
            txtColor.Text = ObjPacientes.Color_Paciente_;
            txtFecha_Nac.Text = ObjPacientes.Fecha_Nacimiento_Paciente.ToShortDateString();
            txtDueño.Text = ObjPacientes.Nombre_Persona;
            txtCedula_Dueño.Text = ObjPacientes.Identificacion_Persona;
            pic_Foto.Image = System.Drawing.Bitmap.FromStream(ObjPacientes.ms);

            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void toggle_vacunacion_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void uI_MaterialToggle1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (uI_MaterialToggle1.Checked == true)
                txtdesparacitacion.ReadOnly = false;
            else
                txtdesparacitacion.ReadOnly = true;
            txtdesparacitacion.Text = "";
             * */
        }

        private void cmbAlimentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            if (cmbAlimentacion.SelectedItem == "Otros")
                txtAlimentacion.ReadOnly = false;
            else
                txtAlimentacion.ReadOnly = true;
            txtAlimentacion.Text = "";

            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void toogle_ultimo_Parto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            if (toogle_ultimo_Parto.Checked == true)
                datetime_ultimo_parto.Enabled = true;
            else
                datetime_ultimo_parto.Enabled = false;
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int Cantidad;
            string IDMedica;
            String NombreMedica;
            int validar = 0;

            bool Accion = false;
           
            try
            {  ////

                csValidarCampos valida = new csValidarCampos();
                valida.TextBoxVacios(txtPeso, "Peso");

                csValidarCampos valida2 = new csValidarCampos();
                valida2.TextBoxPrecio(txtPeso, "Peso");

                csValidarCampos valida3 = new csValidarCampos();
                valida3.TextBoxVacios(txtTemperatura, "Temperatura");

                csValidarCampos valida4 = new csValidarCampos();
                valida4.TextBoxPrecio(txtTemperatura, "Temperatura");

                if (txtAlimentacion.ReadOnly == false)
                {
                    csValidarCampos valida5 = new csValidarCampos();
                valida5.TextBoxVacios(txtAlimentacion, "Alimentacion");

                    if (valida5.comprobar != 1)
                    {
                        validar = 1;
                    }

                }

                try
                {
                    foreach (DataGridViewRow i in dt_medicamentos_usados.Rows)
                    {
                        IDMedica = i.Cells[0].Value.ToString();
                        NombreMedica = i.Cells[1].Value.ToString();
                        Cantidad = Convert.ToInt32(i.Cells[2].Value.ToString());
                        Accion = false;

                        if (IDMedica == "" || NombreMedica == "" || Cantidad.ToString() == "" )
                        {
                            Accion = true;
                        }
                    }

                }
                catch (Exception n)
                {
                    MessageBox.Show(n.Message);
                    Accion = true;
                }

                if (Accion == false && valida.comprobar == 1 && valida2.comprobarprecio == 1 && valida3.comprobar == 1 && valida4.comprobarprecio == 1 && validar == 0 && txtProblemas_Previos.Text != "" && txtAlergias_Encontradas.Text != "" && cmbAlimentacion.SelectedItem != null && cmbProcedencia.SelectedItem != null && cmbEstadoReproductivo.SelectedItem != null && cmbHabitad.SelectedItem != null && txtCirugia.Text != "" && txtMotivo_Consulta.Text != "" && txtTratamiento.Text != "" && txtDiagnostico.Text != "")
                {

                    string Alimentacion_ = cmbAlimentacion.SelectedItem.ToString();
                    string fech_par = "No";
                    string despara = "No";
                    if (uI_MaterialToggle1.Checked == true)
                        despara = "SI";
                    if (cmbAlimentacion.SelectedItem == "Otros")
                        Alimentacion_ = txtAlimentacion.Text;
                    if (toogle_ultimo_Parto.Checked == true)
                        fech_par = datetime_ultimo_parto.Value.Date.ToString();
                    csHistorial_Clinico ObjClinico = new csHistorial_Clinico(paciente_ID, despara, txtProblemas_Previos.Text, txtAlergias_Encontradas.Text, cmbHabitad.SelectedItem.ToString(), Alimentacion_, cmbProcedencia.SelectedItem.ToString(), txtCirugia.Text, cmbEstadoReproductivo.SelectedItem.ToString(), fech_par, txtTemperatura.Text, txtPeso.Text, txtMotivo_Consulta.Text, txtDiagnostico.Text, txtTratamiento.Text, datetime_Fecha_Consulta.Value.Date);
                    //RECORRER EL DATA GRID VIEW DE LOS MEDICAMENTOS USADOS 
                    int veris = 0;
                    foreach (DataGridViewRow row in dt_medicamentos_usados.Rows)
                    {
                        csHistorial_Clinico MedicamentosUSADOS = new csHistorial_Clinico(int.Parse(row.Cells["medicamento_id"].Value.ToString()), int.Parse(row.Cells["cantidad_usada"].Value.ToString()));
                        veris = MedicamentosUSADOS.Verfi;
                        //row.Cells["nombre"].Value.ToString(),
                        //csFactura objdetalle = new csFactura(int.Parse(row.Cells["product_id"].Value.ToString()), int.Parse(row.Cells["quantity"].Value.ToString()), decimal.Parse(row.Cells["oferta_producto"].Value.ToString()), true);
                        //ac = objdetalle.Verificar;
                    }
                    //AQUI MOSTRAR EL REPORT CON EL DETALLE CLINICO
                    if (veris == 1 && ObjClinico.Verfi == 1)
                    {
                        notifica.EnabledNoti = true;
                        frm_Ver_Registrar_Historial_Clinico historialver = new frm_Ver_Registrar_Historial_Clinico(paciente_ID);
                        historialver.Show();
                    }
                    else
                        notifi_error.EnabledNoti = true;

                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }
                
            }  ////
            catch(Exception ne)
            {
                MessageBox.Show(ne.Message);
            }
        }
        private string Toggler_CHEKED(UIDC.UI_MaterialToggle tochk, TextBox tex)
        {
            
            string value="";
            if (tochk.Checked == true)
                value = tex.Text;
            else
                value = "NO";
            return value;
        }

        private void txtMedicamento_TextChanged(object sender, EventArgs e)
        {
            try
            {

            //AQUI ABRIR EL PANEL_MEDICAMENTOS Y QUE CARGE LOS MEDICAMENTOS 
            if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                panel_medicamentos.Visible = false;                
            }
            else if (txtMedicamento.Text == ur)
            {
                panel_medicamentos.Visible = false;               
            }
            else
            {
                panel_medicamentos.Visible = true;
                Listar_Medicamentos_Historial_Clinico listarmedi = new Listar_Medicamentos_Historial_Clinico();
                listarmedi.Palabra_Clave = txtMedicamento.Text;
                dt_medicamento.DataSource = listarmedi.listarpro();

                if (dt_medicamento.RowCount != 0)
                    ur = (dt_medicamento[1, posicion].Value.ToString());
                else
                    panel_medicamentos.Visible = false;
            }
            }
            catch (Exception n)
            {
                MessageBox.Show("Registre bien los datos" + n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMedicamento_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

            //AQUI ABRIR EL PANEL_MEDICAMENTOS Y QUE CARGE LOS MEDICAMENTOS 
            if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                panel_medicamentos.Visible = false;
            }
            else if (txtMedicamento.Text == ur)
            {
                panel_medicamentos.Visible = false;
            }
            else
            {
                panel_medicamentos.Visible = true;
                Listar_Medicamentos_Historial_Clinico listarmedi = new Listar_Medicamentos_Historial_Clinico();
                listarmedi.Palabra_Clave = txtMedicamento.Text;
                dt_medicamento.DataSource = listarmedi.listarpro();

                if (dt_medicamento.RowCount != 0)
                    ur = (dt_medicamento[1, posicion].Value.ToString());
                else
                    panel_medicamentos.Visible = false;
            }

            }
            catch (Exception n)
            {
               // MessageBox.Show( n.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dt_medicamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dt_medicamento.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                medica_id = int.Parse(dt_medicamento[0, posicion].Value.ToString());
                txtMedicamento.Text=dt_medicamento[1,posicion].Value.ToString();
                panel_medicamentos.Visible = false;
            }
           catch (Exception ne) 
            {
                //MessageBox.Show(ne.Message, "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pic_agregar_medicamento_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtMedicamento, "Medicamento");

            csValidarCampos valida3 = new csValidarCampos();
            valida3.TextBoxVacios(txtCantidadMedicamento, "CantidadMedicamento");

            csValidarCampos valida4 = new csValidarCampos();
            valida4.TextBoxPrecio(txtCantidadMedicamento, "CantidadMedicamento");

            if (medica_id.ToString() != "" && valida.comprobar == 1 && valida3.comprobar == 1 && valida4.comprobarprecio == 1 && int.Parse(txtCantidadMedicamento.Text)>0)
            {
                //VALIDAR CAMPOS 
                //RECORRER EL DATAGRIDVIEW Y HACER QUE BUSQUE UN ID IGUAL, SI EL ID ES IGUAL A UNO INGRESADO SE SUMAN LAS CANTIDADES
                bool repetido = false;
                for (int i = 0; i < dt_medicamentos_usados.RowCount; i++)
                {
                    if (medica_id == int.Parse(dt_medicamentos_usados.Rows[i].Cells[0].Value.ToString()))  //.Parse(dtg_Productos.Rows[i].Cells[4].Value.ToString())
                    {
                        dt_medicamentos_usados[2, i].Value = int.Parse(dt_medicamentos_usados[2, i].Value.ToString())+int.Parse(txtCantidadMedicamento.Text);
                        txtMedicamento.Text = ""; txtCantidadMedicamento.Text = "";
                        repetido = true;
                    }                  
                }
                if (repetido == false)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dt_medicamentos_usados);
                    fila.Cells[0].Value = medica_id;
                    fila.Cells[1].Value = txtMedicamento.Text;
                    fila.Cells[2].Value = txtCantidadMedicamento.Text;
                    dt_medicamentos_usados.Rows.Add(fila);
                    txtMedicamento.Text = ""; txtCantidadMedicamento.Text = "";
                }              
            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }

        }
    }
}
