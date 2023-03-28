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
    public partial class frm_MC_Modificar_Crear_Personal : Form
    {
        int ac;
        string ced;
        int ID_PE;
        public frm_MC_Modificar_Crear_Personal(int MC=0, string ceds ="") //PARAMETRO CREAR O MODIFICAR
        {
            ac = MC;
            ced = ceds;
            InitializeComponent();
            if (MC == 1)   //SE CREA DESDE LA VISTA PREDETERMINADA
            {
                lblCrear.Visible = true;
                lblCrear.BringToFront();
                panel_Empleado.Visible = true;
                btnAgregar.Visible = true;
                btnAgregar.BringToFront();
                BtnGuardar.Visible = true;
                cmbBuscar.Visible = false;
                btnbuscar.Visible = false;
                btnFoto.Visible = true;
                btnVista.Visible = false;
                cmbEstado.Visible = false;
                cmbEstado.Enabled = false;
                lblestado.Visible = false;
                BtnGuardar.Visible = false;
                BtnGuardar.Enabled = false;
            }
                else if (MC==0)  //CREAR, MODIFICA, O ELIMINA DESDE LA 2DA VISTA
                {
                    lblPersonal.Visible = true;
                    lblPersonal.BringToFront();
                    btncerrar.Visible = false;
                    btnVista.Visible = true;
                    panel_Empleado.Visible = true;
                    btnAgregar.Visible = true;
                    btnAgregar.BringToFront();
                    btnFoto.Visible = true;
                    csEmpleado emple = new csEmpleado();
                    cmbBuscar.DataSource = emple.ListarEmpleadosCMB().Tables[0];
                    cmbBuscar.ValueMember = "Iden";
                    cmbBuscar.DisplayMember = "Iden";
                  
                    cmbBuscar.SelectedItem = null;
 
                }

            else if (MC == 3) //MODIFICA DESDE CLIENTE //BORRAR PIC FOTO Y BOTON VISTA, TAMBIEN HABILITAR EL BOTON CERRAR
            {
                lblCrear.Visible = true;
                pic_Foto.Visible = false;
                pic_Foto.Enabled = false;
                btnFoto.Enabled = false;
                btnFoto.Visible = false; btncerrar.Visible = true;
                BtnGuardar.Visible = true; BtnEliminar.Visible = true;
                panel_Empleado.Visible = false; panel_Empleado.Enabled = false;
                cmbBuscar.Visible = false; cmbBuscar.Enabled = false;
                btnbuscar.Visible = false; btnbuscar.Enabled = false;
                BtnGuardar.BringToFront();
                btncerrar.Visible = true;
                BtnEliminar.Visible = false;
            }
            else if (MC==4) //CREAR DESD CLIENTE
            {
                lblModificar.Visible = true;           
                pic_Foto.Visible = false;
                pic_Foto.Enabled = false;
                btnFoto.Enabled = false;
                btnFoto.Visible = false; btncerrar.Visible = true;
                BtnGuardar.Visible = true; 
                panel_Empleado.Visible = false; panel_Empleado.Enabled = false;
                cmbBuscar.Visible = false; cmbBuscar.Enabled = false;
                btnbuscar.Visible = false; btnbuscar.Enabled = false;
                BtnGuardar.BringToFront();
                btncerrar.Visible = true;
              BtnEliminar.Visible = true;
            }


            else    //MODIFICA DESDE LA 1ERA VISTA
            {
                try 
                {
                //=2 MODIFICAR EL PERSONAL
                 
 
                lblModificar.Visible = true;
                lblModificar.BringToFront();
                btnAgregar.Visible = false;
                BtnGuardar.Visible = true;
                cmbBuscar.Visible = false;
                btnbuscar.Visible = false;
                btnFoto.Visible = true;
                btnVista.Visible = false;
                panel_Empleado.Visible = true;
                BtnEliminar.Visible = true;
                BtnGuardar.Enabled = true;

                //BUSCAR LOS DATOS DE LA PERSONA SEGUN LA CEDULA 
                csEmpleado per = new csEmpleado(ced);
                ID_PE = per.ID;
                lblID.Text = per.ID.ToString();
                txtNombre.Text = per.Nombre_Persona;
                txtApellidos.Text = per.Apellido_Persona;
                cmbIdentifiacion.SelectedItem = per.T_Identi_Persona;
                txtIdentificacion.Text = per.Identificacion_Persona;
                txtCelular.Text = per.Celular_Persona;
                txtDireccion.Text = per.Direccion_Persona;
                cmbTipo.SelectedItem = per.Tipo_E;
                cmbArea.SelectedItem = per.Area_E;
                txtOficina.Text = per.Oficina_E.ToString();
                pic_Foto.Image = System.Drawing.Bitmap.FromStream(per.ms);//
                if (per.Estado_E == 1)
                    cmbEstado.SelectedItem = "Activo";
                else
                    cmbEstado.SelectedItem = "Inactivo";
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void uI_PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            panelVista.Size = new Size(1239, 636);
            panelVista.BringToFront();
            AbrirFormulario(new frm_MC_Personal());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pic_Foto_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //VALIDAR LOS CAMPOS
            int cantidad = 0;

            if (cmbIdentifiacion.SelectedItem == "Cedula")
            {
                cantidad = 10;
            }
            else if (cmbIdentifiacion.SelectedItem == "Pasaporte")
            {
                cantidad = 10;
            }
            else if (cmbIdentifiacion.SelectedItem == "Ruc")
            {
                cantidad = 13;
            }

            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");
            int comprobrar = valida.comprobar;

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxVacios(txtApellidos, "Apellidos");
            int comprobrar2 = valida2.comprobar;

            csValidarCampos valida3 = new csValidarCampos();
            valida3.tamaño(txtIdentificacion, cantidad);
            int comprobrar3 = valida3.comprobartamaño;

            csValidarCampos valida4 = new csValidarCampos();
            valida4.tamaño(txtCelular, 10);
            int comprobrar4 = valida4.comprobartamaño;

            csValidarCampos valida5 = new csValidarCampos();
            valida5.TextBoxVacios(txtDireccion, "Dirección");
            int comprobrar5 = valida5.comprobar;

            csValidarCampos valida6 = new csValidarCampos();
            valida6.TextBoxVacios(txtOficina, "Oficina");
            int comprobrar6 = valida6.comprobar;

            csValidarCampos valida7 = new csValidarCampos();
            valida7.TextBoxPrecio(txtIdentificacion, "Identificacion");
            int comprobrar7 = valida7.comprobarprecio;

            csValidarCampos valida8 = new csValidarCampos();
            valida8.TextBoxPrecio(txtCelular, "Telefono");
            int comprobrar8 = valida8.comprobarprecio;


            if (comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && comprobrar8 == 1 && cmbIdentifiacion.SelectedItem != null && cmbTipo.SelectedItem != null && cmbArea.SelectedItem != null  )
            {
                if (ac == 1) //CREA EL PERSONAL
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pic_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    csEmpleado objEmpleado = new csEmpleado(txtNombre.Text, txtApellidos.Text, cmbIdentifiacion.SelectedItem.ToString(), txtIdentificacion.Text, txtCelular.Text, txtDireccion.Text, cmbTipo.SelectedItem.ToString(), cmbArea.SelectedItem.ToString(), int.Parse(txtOficina.Text), ms.GetBuffer());
                    notifi_agregar.Text = txtNombre.Text;
                    notifi_agregar.EnabledNoti = true;
                    txtNombre.Text = ""; txtApellidos.Text = ""; cmbIdentifiacion.SelectedItem = null; txtIdentificacion.Text = ""; txtCelular.Text = ""; txtDireccion.Text = "";
                    cmbTipo.SelectedItem = null; cmbArea.SelectedItem = null; txtOficina.Text = "";
                }
            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }
           
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

        private void frm_MC_Modificar_Crear_Personal_Load(object sender, EventArgs e)
        {
           
        }


        //GUARDAS CAMBIOS
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            //ALMACENA LA FOTO EN UN BUFFER XD
            int cantidad = 0;

            if (cmbIdentifiacion.SelectedItem == "Cedula")
            {
                cantidad = 10;
            }
            else if (cmbIdentifiacion.SelectedItem == "Pasaporte")
            {
                cantidad = 10;
            }
            else if (cmbIdentifiacion.SelectedItem == "Ruc")
            {
                cantidad = 13;
            }

            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre, "Nombre");
            int comprobrar = valida.comprobar;

            csValidarCampos valida2 = new csValidarCampos();
            valida2.TextBoxVacios(txtApellidos, "Apellidos");
            int comprobrar2 = valida2.comprobar;

            csValidarCampos valida3 = new csValidarCampos();
            valida3.tamaño(txtIdentificacion, cantidad);
            int comprobrar3 = valida3.comprobartamaño;

            csValidarCampos valida4 = new csValidarCampos();
            valida4.tamaño(txtCelular, 10);
            int comprobrar4 = valida4.comprobartamaño;

            csValidarCampos valida5 = new csValidarCampos();
            valida5.TextBoxVacios(txtDireccion, "Dirección");
            int comprobrar5 = valida5.comprobar;

            csValidarCampos valida6 = new csValidarCampos();
            valida6.TextBoxVacios(txtOficina, "Oficina");
            int comprobrar6 = valida6.comprobar;

            csValidarCampos valida7 = new csValidarCampos();
            valida7.TextBoxPrecio(txtIdentificacion, "Identificacion");
            int comprobrar7 = valida7.comprobarprecio;

            csValidarCampos valida8 = new csValidarCampos();
            valida8.TextBoxPrecio(txtCelular, "Telefono");
            int comprobrar8 = valida8.comprobarprecio;


            if (comprobrar == 1 && comprobrar2 == 1 && comprobrar3 == 1 && comprobrar4 == 1 && comprobrar5 == 1 && comprobrar6 == 1 && comprobrar7 == 1 && comprobrar8 == 1 && cmbIdentifiacion.SelectedItem != null && cmbTipo.SelectedItem != null && cmbArea.SelectedItem != null && cmbEstado.SelectedItem != null )
            {

             System.IO.MemoryStream ms = new System.IO.MemoryStream();
             pic_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


                if (ac == 2||ac==0) //VERIFICAR SI EL CAMBIO LO REALIZA EN EMPLEADO  
                {
                    int estado = 1;
                    if (cmbEstado.SelectedItem == "Inactivo")
                    {
                        estado = 0;
                    }
                    csEmpleado obemple = new csEmpleado(ID_PE, txtNombre.Text, txtApellidos.Text, cmbIdentifiacion.SelectedItem.ToString(), txtIdentificacion.Text, txtCelular.Text, txtDireccion.Text, cmbTipo.SelectedItem.ToString(), cmbArea.SelectedItem.ToString(), int.Parse(txtOficina.Text), ms.GetBuffer(),estado);
                }

            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BtnEliminar.Visible = true; BtnEliminar.Enabled = true;
                int ID_E;             
                btnAgregar.Visible = false; btnAgregar.Enabled = false;
                BtnGuardar.Visible = true; BtnGuardar.Enabled = true; BtnGuardar.BringToFront();
                //csEmpleado objemple = new csEmpleado(cmbBuscar.SelectedValue.ToString());
                csEmpleado objemple = new csEmpleado(cmbBuscar.SelectedValue.ToString());
                ID_E = objemple.ID;
                ID_PE = ID_E;
                txtNombre.Text = objemple.Nombre_Persona;
                txtApellidos.Text = objemple.Apellido_Persona;
                cmbIdentifiacion.SelectedItem = objemple.T_Identi_Persona;
                txtIdentificacion.Text = objemple.Identificacion_Persona;
                txtCelular.Text = objemple.Celular_Persona;
                txtDireccion.Text = objemple.Direccion_Persona;
                cmbTipo.SelectedItem = objemple.Tipo_E;
                cmbArea.SelectedItem = objemple.Area_E;
                txtOficina.Text = objemple.Oficina_E.ToString();
                if (objemple.Estado_E == 1)
                    cmbEstado.SelectedItem = "Activo";
                else
                    cmbEstado.SelectedItem = "Inactivo";
                pic_Foto.Image = System.Drawing.Bitmap.FromStream(objemple.ms);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void cmbIdentifiacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIdentificacion.Text = null;
            txtIdentificacion.Enabled = true;
            if (cmbIdentifiacion.SelectedItem == "Cedula")
            {
                txtIdentificacion.MaxLength = 10;
            }
            else if (cmbIdentifiacion.SelectedItem == "Pasaporte")
            {
                txtIdentificacion.MaxLength = 10;
            }
            else if (cmbIdentifiacion.SelectedItem == "Ruc")
            {
                txtIdentificacion.MaxLength = 13;
            }
        }
    }
}
