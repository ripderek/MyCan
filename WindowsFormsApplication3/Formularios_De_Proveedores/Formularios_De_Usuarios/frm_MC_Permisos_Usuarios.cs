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
    public partial class frm_MC_Permisos_Usuarios : Form
    {
       int P_lista; //
       int  P_Agregar;//
       int P_Modificar;//
       int C_lista;//
       int C_Agregar;//
       int C_Modificar;//
       int Pp_lista;//
       int Pp_Agregar;//
       int Pp_Modificar;//
       int Pa_Lista;//
       int Pa_Agregar;//
       int Pa_Modificar;//
       int Pr_Lista;//
       int Pr_Agregar;//
       int Pr_Modificar;//
       int Er_LAM;        //
       int Citas_agendar;  //
       int Citas_Modificar; //
       int His_listar;     //
       int His_Registrar;  //
       int His_Modificar;  //
       int Factura_LAM;  //
       int Servi;  //
       int Hospi;  //
       int Config;

       public frm_MC_Permisos_Usuarios(int ac = 0, int id = 0) //si act = 1 entonces tendria que modificar y pasar el id
       {
           InitializeComponent();
           notifyIcon1.Visible = true;
       }
       public int verficar_check(UIDC.UI_MaterialToggle rad)  //RETORNAR 1 SI EL TOGGLE ESTA EN CHECKED, 0 SI ES UNCHECKED 
       {
           int op = 0;
           if (rad.Checked == true)
               op=1;
           return op;
       }
       public void Valores_Variables() //ENVIAR TODAS LAS VARIABLES A VERIFICAR
       {
           P_lista = verficar_check(P_lista_toggle);//
           P_Agregar = verficar_check(P_Agregar_toggle);//
           P_Modificar = verficar_check(P_ModificarlToggle);//
           C_lista = verficar_check(C_listaToggle);
           C_Agregar = verficar_check(C_AgregarToggle5);
           C_Modificar = verficar_check(C_ModificarToggle4);
           Pp_lista = verficar_check(Pp_listaToggle9);
           Pp_Agregar = verficar_check(Pp_AgregarToggle8);
           Pp_Modificar = verficar_check(Pp_ModificarToggle7);
           Pa_Agregar = verficar_check(Pa_Agregartoggle11);
           Pa_Lista = verficar_check(Pa_ListaToggle12);
           Pa_Modificar = verficar_check(Pa_ModificarToggle10);
           Pr_Agregar = verficar_check(Pr_AgregarToggle14);
           Pr_Lista = verficar_check(Pr_ListaToggle15);
           Pr_Modificar = verficar_check(Pr_ModificarToggle13);
           His_listar = verficar_check(His_listarToggle18);
           His_Registrar = verficar_check(His_Registrartoggle17);
           His_Modificar = verficar_check(His_ModificarToggle16);
           Er_LAM = verficar_check(Er_LAMToggle1);
           Citas_agendar = verficar_check(Citas_agendarToggle21);
           Citas_Modificar = verficar_check(Citas_ModificarToggle19);
           Factura_LAM = verficar_check(Factura_LAMtoggle22);
           Servi = verficar_check(ServiToggle20);
           Hospi = verficar_check(HospiToggle23);
           Config = verficar_check(ConfigToggle24);
       }
       public void Guardar() //funcion para enviar a guardar todos los datos a la base de datos. SIRVE PARA GUARDAR O MODIFICAR 
       {

          // if (string.IsNullOrWhiteSpace(txtUsername.Text)) { }
           //MessageBox.Show("EL CAMPO USUARIO ESTA VACIO ");
         //  else
           //{
               Valores_Variables();
               csUsuarios objUser = new csUsuarios(txtUsername.Text, P_lista, P_Agregar, P_Modificar, C_lista, C_Agregar, C_Modificar,
                               Pp_lista, Pp_Agregar, Pp_Modificar, Pa_Lista, Pa_Agregar, Pa_Modificar, Pr_Lista,
                               Pr_Agregar, Pr_Modificar, Er_LAM, Citas_agendar, Citas_Modificar, His_listar,
                               His_Registrar, His_Modificar, Factura_LAM, Servi, Hospi, Config);
          // }
 
       }

       private void label1_Click(object sender, EventArgs e)
       {
          // XD(C_AgregarToggle5);
       }

       private void P_lista_toggle_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();         
       }

       private void P_Agregar_toggle_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void P_ModificarlToggle_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void C_listaToggle_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void C_AgregarToggle5_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void C_ModificarToggle4_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pp_listaToggle9_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pp_AgregarToggle8_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pp_ModificarToggle7_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pa_ListaToggle12_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pa_Agregartoggle11_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pa_ModificarToggle10_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pr_ListaToggle15_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pr_AgregarToggle14_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Pr_ModificarToggle13_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void His_listarToggle18_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void His_Registrartoggle17_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void His_ModificarToggle16_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Citas_agendarToggle21_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Citas_ModificarToggle19_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Factura_LAMtoggle22_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void ServiToggle20_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void HospiToggle23_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void ConfigToggle24_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void Er_LAMToggle1_CheckedChanged(object sender, EventArgs e)
       {
           Guardar();   
       }

       private void txtUsuario_TextChanged(object sender, EventArgs e)
       {
           try
           {
               csEmpleado objem = new csEmpleado(txtUsuario.Text, true);
               txtUsername.Text = objem.User1;
           }
           catch(Exception ne)
           {
               MessageBox.Show(ne.Message);
           }
       }

       private void PERMISOS(UIDC.UI_MaterialToggle rad1, int val1)
       {
           if (val1 == 1)
               rad1.Checked = true;
           else
               rad1.Checked = false;
       }

       private void txtUsername_TextChanged(object sender, EventArgs e)
       {
           if (string.IsNullOrWhiteSpace(txtUsername.Text))
           {

               P_lista_toggle.Checked = false;
               P_Agregar_toggle.Checked = false;
               P_ModificarlToggle.Checked = false;
               C_listaToggle.Checked = false;
               C_AgregarToggle5.Checked = false;
               C_ModificarToggle4.Checked = false;
               Pp_listaToggle9.Checked = false;
               Pp_AgregarToggle8.Checked = false;
               Pp_ModificarToggle7.Checked = false;
               Pa_Agregartoggle11.Checked = false;
               Pa_ListaToggle12.Checked = false;
               Pa_ModificarToggle10.Checked = false;
               Pr_AgregarToggle14.Checked = false;
               Pr_ListaToggle15.Checked = false;
               Pr_ModificarToggle13.Checked = false;
               His_listarToggle18.Checked = false;
               His_Registrartoggle17.Checked = false;
               His_ModificarToggle16.Checked = false;
               Er_LAMToggle1.Checked = false;
               Citas_agendarToggle21.Checked = false;
               Citas_agendarToggle21.Checked = false;
               Citas_ModificarToggle19.Checked = false;
               Factura_LAMtoggle22.Checked = false;
               ServiToggle20.Checked = false;
               HospiToggle23.Checked = false;
               ConfigToggle24.Checked = false;
               //INNABILITAR LOS TOOGLE

               P_lista_toggle.Enabled= false;
               P_Agregar_toggle.Enabled = false;
               P_ModificarlToggle.Enabled = false;
               C_listaToggle.Enabled = false;
               C_AgregarToggle5.Enabled = false;
               C_ModificarToggle4.Enabled = false;
               Pp_listaToggle9.Enabled = false;
               Pp_AgregarToggle8.Enabled = false;
               Pp_ModificarToggle7.Enabled = false;
               Pa_Agregartoggle11.Enabled = false;
               Pa_ListaToggle12.Enabled = false;
               Pa_ModificarToggle10.Enabled = false;
               Pr_AgregarToggle14.Enabled = false;
               Pr_ListaToggle15.Enabled = false;
               Pr_ModificarToggle13.Enabled = false;
               His_listarToggle18.Enabled = false;
               His_Registrartoggle17.Enabled = false;
               His_ModificarToggle16.Enabled = false;
               Er_LAMToggle1.Enabled = false;
               Citas_agendarToggle21.Enabled = false;
               Citas_agendarToggle21.Enabled = false;
               Citas_ModificarToggle19.Enabled = false;
               Factura_LAMtoggle22.Enabled = false;
               ServiToggle20.Enabled = false;
               HospiToggle23.Enabled = false;
               ConfigToggle24.Enabled = false;

           }
           else
           {
               P_lista_toggle.Enabled = true;
               P_Agregar_toggle.Enabled = true;
               P_ModificarlToggle.Enabled = true;
               C_listaToggle.Enabled = true;
               C_AgregarToggle5.Enabled = true;
               C_ModificarToggle4.Enabled = true;
               Pp_listaToggle9.Enabled = true;
               Pp_AgregarToggle8.Enabled = true;
               Pp_ModificarToggle7.Enabled = true;
               Pa_Agregartoggle11.Enabled = true;
               Pa_ListaToggle12.Enabled = true;
               Pa_ModificarToggle10.Enabled = true;
               Pr_AgregarToggle14.Enabled = true;
               Pr_ListaToggle15.Enabled = true;
               Pr_ModificarToggle13.Enabled = true;
               His_listarToggle18.Enabled = true;
               His_Registrartoggle17.Enabled = true;
               His_ModificarToggle16.Enabled = true;
               Er_LAMToggle1.Enabled = true;
               Citas_agendarToggle21.Enabled = true;
               Citas_agendarToggle21.Enabled = true;
               Citas_ModificarToggle19.Enabled = true;
               Factura_LAMtoggle22.Enabled = true;
               ServiToggle20.Enabled = true;
               HospiToggle23.Enabled = true;
               ConfigToggle24.Enabled = true;


               //RECIBIR LOS DATOS 
               try
               {

                   csUsuarios objuser = new csUsuarios(txtUsername.Text, true);
                   PERMISOS(P_lista_toggle, objuser.P_lista1);
                   PERMISOS(P_Agregar_toggle, objuser.P_Agregar1);
                   PERMISOS(P_ModificarlToggle, objuser.P_Modificar1);
                   PERMISOS(C_listaToggle, objuser.C_lista1);
                   PERMISOS(C_AgregarToggle5, objuser.C_Agregar1);
                   PERMISOS(C_ModificarToggle4, objuser.C_Modificar1);
                   PERMISOS(Pp_listaToggle9, objuser.Pp_lista1);
                   PERMISOS(Pp_AgregarToggle8, objuser.Pp_Agregar1);
                   PERMISOS(Pp_ModificarToggle7, objuser.Pp_Modificar1);
                   PERMISOS(Pa_Agregartoggle11, objuser.Pa_Agregar1);
                   PERMISOS(Pa_ListaToggle12, objuser.Pa_Lista1);
                   PERMISOS(Pa_ModificarToggle10, objuser.Pa_Modificar1);
                   PERMISOS(Pr_AgregarToggle14, objuser.Pr_Agregar1);
                   PERMISOS(Pr_ListaToggle15, objuser.Pr_Lista1);
                   PERMISOS(Pr_ModificarToggle13, objuser.Pr_Modificar1);
                   PERMISOS(His_listarToggle18, objuser.His_listar1);
                   PERMISOS(His_Registrartoggle17, objuser.His_Registrar1);
                   PERMISOS(His_ModificarToggle16, objuser.His_Modificar1);
                   PERMISOS(Er_LAMToggle1, objuser.Er_LAM1);
                   PERMISOS(Citas_agendarToggle21, objuser.Citas_agendar1);
                   PERMISOS(Citas_ModificarToggle19, objuser.Citas_Modificar1);
                   PERMISOS(Factura_LAMtoggle22, objuser.Factura_LAM1);
                   PERMISOS(ServiToggle20, objuser.Servi1);
                   PERMISOS(HospiToggle23, objuser.Hospi1);
                   PERMISOS(ConfigToggle24, objuser.Config1);
               }
               catch (Exception ne)
               {
                   MessageBox.Show(ne.Message);
               }

 
           }
       }
       private void Cambiar_Estado_Checek(UIDC.UI_MaterialToggle rad1)
       {
           
 
       }
    }
}
