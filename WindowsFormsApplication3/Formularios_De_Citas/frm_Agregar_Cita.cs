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
    public partial class frm_Agregar_Cita : Form
    {
        int ID_Cliente;
        int ID_Empleado_Agenda;
        int ID_Empleado_Med;
        public frm_Agregar_Cita(int id_empleado_a)
        {
            InitializeComponent();
            ID_Empleado_Agenda = id_empleado_a;
            //asignar el id_empleado_agend trasladando por formularios el id del usario con el que se ingresa en el programa desde el login
        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtCedulaCliente.Text))
             { }
            else 
             {
            csClientes objCliente = new csClientes(txtCedulaCliente.Text);
            txtNombreCliente.Text = objCliente.Nombre_Persona;
            ID_Cliente = objCliente.ID_CLIENTE_;
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            { }
            else
            {
                csEmpleado objemple = new csEmpleado();
                objemple.Datos_Empedo_CED(textBox1.Text);
                txtNombreMedico.Text = objemple.Nombre_Persona;
                ID_Empleado_Med = objemple.ID_EMPLEADO1;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            //AGENDAR LA CITA CON SU DETALLE DE CITA 
            // LOS VALORES DE LOS DETALLES DE LA CITA HORA LLEGADA=0 ESTADO=Agendada        otros estados serían Terminada, Pospuesta, Nunca Llegó
          // public csCitas(int id_cliente_, int id_empleado_agen_, int id_empleado_med_,  string descrip, int duracion,
                        //DateTime fecha_destinada_,string hora_llegada_, string Estado, string hora_d)
            try
            {


                csValidarCampos valida = new csValidarCampos();
                valida.TextBoxVacios(txtCedulaCliente, "CedulaCliente");

                csValidarCampos valida2 = new csValidarCampos();
                valida2.TextBoxVacios(txtNombreCliente, "NombreCliente");

                csValidarCampos valida3 = new csValidarCampos();
                valida3.TextBoxVacios(textBox1, "CedilaMedico");

                csValidarCampos valida4 = new csValidarCampos();
                valida4.TextBoxVacios(txtNombreMedico, "NombreMedico");

                csValidarCampos valida5= new csValidarCampos();
                valida5.TextBoxPrecio(txtTiempoDuracion, "TiempoDuracion");

                csValidarCampos valida6 = new csValidarCampos();
                valida6.TextBoxVacios(txtTiempoDuracion, "TiempoDuracion");

                csValidarCampos valida7 = new csValidarCampos();
                valida7.TextBoxVacios(txtHora, "Hora");

                csValidarCampos valida8 = new csValidarCampos();
                valida8.TextBoxVacios(TxtMinutos, "Minutos");

                csValidarCampos valida9 = new csValidarCampos();
                valida9.TextBoxPrecio(txtHora, "Hora");

                csValidarCampos valida10 = new csValidarCampos();
                valida10.TextBoxPrecio(TxtMinutos, "Minutos");

                if (txtDescripcion.Text != "" && valida.comprobar == 1 && valida2.comprobar == 1 && valida3.comprobar == 1 && valida4.comprobar == 1 && valida5.comprobarprecio == 1 && valida6.comprobar == 1 && valida7.comprobar == 1 && valida8.comprobar == 1 && valida9.comprobarprecio == 1 && valida10.comprobarprecio == 1 && int.Parse(txtHora.Text) <= 23 && int.Parse(TxtMinutos.Text) <= 59 && int.Parse(txtHora.Text) >= 0 && int.Parse(TxtMinutos.Text) >=0)
                {
                    string Time_Hora_destinada1 = txtHora.Text + ":" + TxtMinutos.Text;

                    //string ho = hora + ".0000000";
                    //DateTime ac = Convert.ToDateTime( Time_Hora_destinada);
                    csCitas objCitas = new csCitas(ID_Cliente, ID_Empleado_Agenda, ID_Empleado_Med, txtDescripcion.Text, int.Parse(txtTiempoDuracion.Text), datetimeFecha_Destinada.Value, "0", "Agendada", Time_Hora_destinada1);
                    notifi_agregar.EnabledNoti = true;


                    txtCedulaCliente.Text = "";
                    txtNombreCliente.Text = "";
                    textBox1.Text = "";
                    txtNombreMedico.Text = "";
                    txtTiempoDuracion.Text = "";
                    txtDescripcion.Text = "";
                    txtHora.Text = "";
                    TxtMinutos.Text = "";

                    this.Close();

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

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtMinutos_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtHora_MouseEnter(object sender, EventArgs e)
        {
            if (txtHora.Text=="00")
            {
                txtHora.Text = "";
            }
        }

        private void TxtMinutos_MouseEnter(object sender, EventArgs e)
        {
            if (TxtMinutos.Text == "00")
            {
                TxtMinutos.Text = "";
            }
        }

        private void txtHora_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHora.Text))
            {
                txtHora.Text = "00";
            }

        }

        private void TxtMinutos_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMinutos.Text))
            {
                TxtMinutos.Text = "00";
            }
        }
    }
}
