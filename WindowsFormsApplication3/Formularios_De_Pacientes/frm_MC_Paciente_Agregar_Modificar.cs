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
    public partial class frm_MC_Paciente_Agregar_Modificar : Form
    {
        int mc;
        int id_cliente;
        int id_paciente;
        public frm_MC_Paciente_Agregar_Modificar(int accion=1, int id=0)
        {
            mc = accion;
            id_paciente= id;
            InitializeComponent();
            csEspecie_Raza_Animal obj_especie = new csEspecie_Raza_Animal();
            cmbEspecie.DataSource = obj_especie.ListarEspeciesAnimalesCMB().Tables[0];
            cmbEspecie.ValueMember = "id_Especie";
            cmbEspecie.DisplayMember = "Nombre_Especie";


            if (accion == 1) //Modificar
            {
                lblCrear.Visible = false; lblModificar.Visible = true; lblModificar.BringToFront();
                btnGuardar.Enabled = true;
                csPaciente objpac = new csPaciente(id);             
                txtNombre.Text = objpac.Nombre_Paciente_;
                txtCedulaDueno.Text = objpac.Identificacion_Persona;
                txtNombreDueño.Text = objpac.Nombre_Persona;
                cmbEspecie.SelectedItem = objpac.TIPO_ESPECIE_;
                cmbRaza.SelectedItem = objpac.TIPO_RAZA_;
                cmbSexo.SelectedItem = objpac.Sexo_Paciente_;
                cmbColor.SelectedItem = objpac.Color_Paciente_;
                date_fecha_nac.Value = objpac.Fecha_Nacimiento_Paciente;
                pic_Foto.Image = System.Drawing.Bitmap.FromStream(objpac.ms);


            }
            else //Crear
            {
              
            }
        }

        private void uI_TransparentTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerar_MouseEnter(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Red;
            btnCerar.ForeColor = Color.White;
        }

        private void btnCerar_MouseLeave(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Transparent;
            btnCerar.ForeColor = Color.Black;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pic_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                csValidarCampos valida = new csValidarCampos();
                valida.TextBoxVacios(txtNombreDueño, "NombreDueño");
                int comprobrar = valida.comprobar;

                csValidarCampos valida2 = new csValidarCampos();
                valida2.TextBoxVacios(txtNombre, "Nombre");
                int comprobrar2 = valida2.comprobar;

                if (comprobrar == 1 && comprobrar2 == 1 && cmbEspecie.SelectedItem != null && cmbRaza.SelectedItem != null && cmbSexo.SelectedItem != null && cmbColor.SelectedItem != null)
                {

                    if (mc == 1)//modificar
                    {
                        csPaciente objpac = new csPaciente(id_paciente, id_cliente, int.Parse(cmbEspecie.SelectedValue.ToString()), int.Parse(cmbRaza.SelectedValue.ToString()), txtNombre.Text, cmbSexo.SelectedItem.ToString(), cmbColor.SelectedItem.ToString(), date_fecha_nac.Value, ms.GetBuffer());
                        notifi_agregar.TitleText = "Paciente Modificado";
                        notifi_agregar.Text = "Se modificó un paciente";
                        notifi_agregar.EnabledNoti = true;
                        this.Close();
                        this.Close();
                    }
                    else //AGREGAR
                    {
                        //int ID_CLIEN, int ID_ESPE, int ID_RA, string NOM, string SE, string COLO4, DateTime NAC, byte[] pic
                        csPaciente objpac = new csPaciente(id_cliente, int.Parse(cmbEspecie.SelectedValue.ToString()), int.Parse(cmbRaza.SelectedValue.ToString()), txtNombre.Text, cmbSexo.SelectedItem.ToString(), cmbColor.SelectedItem.ToString(), date_fecha_nac.Value, ms.GetBuffer());
                        notifi_agregar.TitleText = "Paciente Agregado";
                        notifi_agregar.Text = "Se agregó un paciente";
                        notifi_agregar.EnabledNoti = true;
                        txtNombre.Text = "";
                        txtNombreDueño.Text = "";
                        txtCedulaDueno.Text = "";

                        cmbEspecie.SelectedItem = null;
                        cmbRaza.SelectedItem = null;
                        cmbSexo.SelectedItem = null;
                        cmbColor.SelectedItem = null;
                    }

                }
                else
                {
                    MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                    ms2.ShowDialog();
                }

            }
            catch(Exception ne)
            {
                MessageBox.Show(ne.Message);
            }
        }

        private void frm_MC_Paciente_Agregar_Modificar_Load(object sender, EventArgs e)
        {
            

      
        }

        private void btnActualizarcmb_Click(object sender, EventArgs e)
        {
         
        }

        private void btnactualizarClien_Click(object sender, EventArgs e)
        {
            

        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEspecie.SelectedItem != null)
                {
                    csEspecie_Raza_Animal obj_Raza = new csEspecie_Raza_Animal();
                    obj_Raza.ID_ES = int.Parse(cmbEspecie.SelectedValue.ToString());
                    cmbRaza.DataSource = obj_Raza.ListarRAZASAnimalesCMB().Tables[0];
                    cmbRaza.ValueMember = "Id";
                    cmbRaza.DisplayMember = "Nombre_Raza";
                    cmbRaza.SelectedItem = null;
                }
            }
            catch
            {
            }
        }

        private void cmbDueño_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fo = new OpenFileDialog();
            DialogResult Rs = Fo.ShowDialog();
            if (Rs == DialogResult.OK)
            {
                pic_Foto.Image = Image.FromFile(Fo.FileName);

            }
        }

        private void txtCedulaDueno_TextChanged(object sender, EventArgs e)
        {
            csClientes objclient = new csClientes(txtCedulaDueno.Text);
            txtNombreDueño.Text = objclient.Nombre_Persona;
            id_cliente = objclient.ID_CLIENTE_;
        }
    }
}
