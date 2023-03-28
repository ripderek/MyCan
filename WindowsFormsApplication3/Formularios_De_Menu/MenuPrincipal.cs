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
    public partial class MenuPrincipal : Form
    {
        string cedA, ape, usr;
        int id_u;
        int ID_US_; int ID_Empleado_user;
        public MenuPrincipal(string ced_user, string apellid_user, int id_user, string username, int ID_USARIO_)
        {
            InitializeComponent();
            uI_Animation1.Enabled = true;
            usr = username;
            cedA = ced_user; ape = apellid_user; id_u = id_user;
            persolanizarDiseño();
            ID_US_ = ID_USARIO_;
            csEmpleado objemple = new csEmpleado(ced_user);
            ID_Empleado_user = objemple.ID_EMPLEADO1;

            AbrirFormulario(new frm_MC_Inicio(ced_user,apellid_user,id_user,usr,ID_US_));
            frm_ProgressBar_Inicio pro = new frm_ProgressBar_Inicio();
            pro.ShowDialog();
            contador = 2;
            this.timer1.Enabled = true;
        }

        private void persolanizarDiseño()
            {
        }
        private void ocualtarSubMenu()
        {
          
        }
        private void verSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocualtarSubMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }
    
        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private Form formularioActivo = null;
        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo!=null)
            {
                formularioActivo.Close();
            }
                formularioActivo = nuevoFormulario;
                nuevoFormulario.TopLevel = false;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                nuevoFormulario.Dock = DockStyle.Fill;
                panel_Formulario.Controls.Add(nuevoFormulario);
                panel_Formulario.Tag = nuevoFormulario;
               // nuevoFormulario.BringToFront();
                nuevoFormulario.Show();     
        }

        private void AbrirSubmenu()
        {
            if (panel_submenu.Visible == false)
            { panel_submenu.Visible = true; panel_submenu.BringToFront(); timerAbrir.Start(); 
            
            }
            else
            {
                btn_Home.Visible = false;
                btn_Personal.Visible = false;
                btn_Productos.Visible = false;
                btn_Servicios.Visible = false;
                btnCategoria.Visible = false;
                btnProductos.Visible = false;
                btnConfig2.Visible = false;
                btn_Analitycs.Visible = false;
                btnReportes.Visible = false;

                timerCerrar.Start();  }
        }

        //MEOTOD PARA ABIRIR EL SUBMENU
        private void uI_TitleBanner1_Click(object sender, EventArgs e)
        {
            AbrirSubmenu();
            if (panel_Menu_Analytics.Visible == true)
                panel_Menu_Analytics.Visible = false;
            if (Analitycs_PRODUCTOS.Visible == true)
                Analitycs_PRODUCTOS.Visible = false;

        }

        private void btn_Home_MouseEnter(object sender, EventArgs e)
        {
            btn_Home.BaseColor = Color.FromArgb(250, 209, 38);
        }

        private void btn_Home_MouseLeave(object sender, EventArgs e)
        {
            btn_Home.BaseColor = Color.FromArgb(83, 82, 237);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            txtTITULO.Text = "Inicio";
            AbrirFormulario(new frm_MC_Inicio(cedA,ape,id_u,usr,ID_US_));
            panel_superior.UIBottomRight = Color.FromArgb( 55, 66, 250);
            panel_superior.UIBottomLeft = Color.FromArgb( 83, 82, 237); 

            AbrirSubmenu();

        }


        private void uI_ShadowPanel2_MouseEnter(object sender, EventArgs e)
        {
            btn_Personal.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Personal_MouseLeave(object sender, EventArgs e)
        {
            btn_Personal.BaseColor = Color.FromArgb(83, 82, 237);
        }

        private void btn_Proveedores_MouseEnter(object sender, EventArgs e)
        {
           // btn_Proveedores.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Proveedores_MouseLeave(object sender, EventArgs e)
        {
           // btn_Proveedores.BaseColor = Color.FromArgb(103, 23, 205);

        }

        private void btn_Clientes_MouseEnter(object sender, EventArgs e)
        {
            //btn_Clientes.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Clientes_MouseLeave(object sender, EventArgs e)
        {
            //btn_Clientes.BaseColor = Color.FromArgb(103, 23, 205);

        }

        private void btn_Productos_MouseEnter(object sender, EventArgs e)
        {
            btn_Productos.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Productos_MouseLeave(object sender, EventArgs e)
        {
            btn_Productos.BaseColor = Color.FromArgb(83, 82, 237);

        }

        private void btn_Pacientes_MouseEnter(object sender, EventArgs e)
        {
            //btn_Pacientes.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Pacientes_MouseLeave(object sender, EventArgs e)
        {
          //  btn_Pacientes.BaseColor = Color.FromArgb(103, 23, 205);

        }

        private void btn_Consultas_MouseEnter(object sender, EventArgs e)
        {
          //  btn_Consultas.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Consultas_MouseLeave(object sender, EventArgs e)
        {
           // btn_Consultas.BaseColor = Color.FromArgb(103, 23, 205);

        }

        private void btn_Servicios_MouseEnter(object sender, EventArgs e)
        {
            btn_Servicios.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Servicios_MouseLeave(object sender, EventArgs e)
        {
            btn_Servicios.BaseColor = Color.FromArgb(83, 82, 237);

        }

        private void btn_Configuracion_MouseEnter(object sender, EventArgs e)
        {
            //btn_Configuracion.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Configuracion_MouseLeave(object sender, EventArgs e)
        {
           // btn_Configuracion.BaseColor = Color.FromArgb(103, 23, 205);

        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.P_lista1 == 1)
            {
                txtTITULO.Text = "Personal";
                AbrirFormulario(new frm_MC_Personal(usr));
                panel_superior.UIBottomRight = Color.FromArgb(255, 86, 78);
                panel_superior.UIBottomLeft = Color.FromArgb(103, 23, 205); 
                AbrirSubmenu();
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
        }

        private void btn_Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfig2_MouseEnter(object sender, EventArgs e)
        {
            btnConfig2.BaseColor = Color.FromArgb(250, 209, 38);
          
        }

        private void btnConfig2_MouseLeave(object sender, EventArgs e)
        {
            btnConfig2.BaseColor = Color.FromArgb(83, 82, 237);
        }

        private void btnConfig2_MouseClick(object sender, MouseEventArgs e)
        {
            csUsuarios objuser = new csUsuarios(usr, true);
            if (objuser.Config1 == 1)
            {
                txtTITULO.Text = "Configuracion";
                AbrirFormulario(new frm_Configuracion(cedA, ape, id_u));
                panel_superior.UIBottomRight = Color.FromArgb(255, 224, 112); 
                panel_superior.UIBottomLeft = Color.FromArgb(250, 209, 38);
                AbrirSubmenu();
            }
            else
            {
                messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
                men1.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void btnCerar_MouseEnter(object sender, EventArgs e)
        {
            btnCerar.ForeColor = Color.Red;
        }

        private void btnCerar_MouseLeave(object sender, EventArgs e)
        {
            btnCerar.ForeColor = Color.FromName("ControlLight");
        }

        private void btn_Personal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Servicios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfig2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerAbrir_Tick(object sender, EventArgs e)
        {
            if (panel_submenu.Width < 250)
            {
                panel_submenu.Width = panel_submenu.Width + 25;
            }
            else
            {
                timerAbrir.Stop();
                //HACER QUE SEAN VISIBLES LOS BOTONES
                btn_Home.Visible=true;
                btn_Personal.Visible=true;
                btn_Productos.Visible=true;
                btn_Servicios.Visible=true;
                btnCategoria.Visible=true;
                btnProductos.Visible=true;
                btnConfig2.Visible = true;
                btn_Analitycs.Visible = true;
                btnReportes.Visible = true;
            }
        }

        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            if (panel_submenu.Width > 0)
            {
                panel_submenu.Width = panel_submenu.Width - 80;
            }
            else
            {
                panel_submenu.Visible = false;
                timerCerrar.Stop();           
                //HACER QUE LOS BOTONES SEAN INVISIBLES
                
            }
        }

        private void btn_Servicios_Click(object sender, EventArgs e)
        {
           // Personalizacion per = new Personalizacion(new frmServicios());
            AbrirFormulario(new frmServicios());
            AbrirSubmenu();
            txtTITULO.Text = "Servicios";
        }

        private void btn_Productos_Click(object sender, EventArgs e) ///FACTURACION
        {
           // csUsuarios objuser = new csUsuarios(usr, true);
            //if (objuser.Config1 == 1)
            //{
                  csEmpleado objemple = new csEmpleado(cedA);       
                 int ID_Empleado_user = objemple.ID_EMPLEADO1;


                txtTITULO.Text = "Factura";
                AbrirFormulario(new frmFacturacion(ID_Empleado_user));
                panel_superior.UIBottomRight = Color.FromArgb(255, 224, 112);
                panel_superior.UIBottomLeft = Color.FromArgb(250, 209, 38);
                AbrirSubmenu();
           // }
            //else
            //{
               // messge_Usuario_sin_permiso men1 = new messge_Usuario_sin_permiso();
             //   men1.ShowDialog();
           // }
        }

        private void btnCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario(new frm_Categorias());
            AbrirSubmenu();
            txtTITULO.Text = "Categorias";
        }

        private void btnProductos_MouseClick(object sender, MouseEventArgs e)
        {
            //Personalizacion per = new Personalizacion(new frmNuevoProducto());
            //AQUI ABRIR EL FORMULARIO DE RECEPCION DE PRODUCTOS
            //ID_Empleado_user
            AbrirFormulario(new frmCompra_Productos(ID_Empleado_user));
            AbrirSubmenu();
        
        }

        private void btnCategoria_MouseEnter(object sender, EventArgs e)
        {
            btnCategoria.BaseColor = Color.FromArgb(250, 209, 38);
        }

        private void btnCategoria_MouseLeave(object sender, EventArgs e)
        {
            btnCategoria.BaseColor = Color.FromArgb(83, 82, 237);
        }

        private void btnProductos_MouseEnter(object sender, EventArgs e)
        {
            btnProductos.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            btnProductos.BaseColor = Color.FromArgb(83, 82, 237);
        }

        private void btn_Analitycs_MouseEnter(object sender, EventArgs e)
        {
            btn_Analitycs.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btn_Analitycs_MouseLeave(object sender, EventArgs e)
        {
                    btn_Analitycs.BaseColor = Color.FromArgb(83, 82, 237);

        }

        private void btn_Analitycs_MouseClick(object sender, MouseEventArgs e)
        {
            //AQUI ABRIR UN PANEL CON OPCIONES PARA ESCOJER UN REPORTE CON ANALYTICS 
            //EL SUBMENU MIDE 250 
            Abrir_Panel_Analitycs();
            
        }

        private void Abrir_Panel_Analitycs()
        {
            if (panel_Menu_Analytics.Visible == true)
                panel_Menu_Analytics.Visible = false;
            else
                panel_Menu_Analytics.Visible = true;
        }

        private void btn_Analitycs_Productos_Click(object sender, EventArgs e)
        {
            //AQUI ABRIR EL PANEL CON EL MENU DE ANALITYCS PARA PRODUCTOS
            //Analitycs_PRODUCTOS
            Abrir_Panel_Analitycs_Products();
        }

        private void btnAnalitics_Productos_Top_10_Click(object sender, EventArgs e)
        {
            //AQUI ABRIR EL FORMULARIO CON EL ANALISIS DE LOS PRODUCTOS CON TOP 10 EN VENTAS, SE PUEDE ENVIAR RANGOS DE FECHAS 
            AbrirFormulario(new frm_VER_TOP_25_PRODUCTOS());
            Abrir_Panel_Analitycs_Products();
            Abrir_Panel_Analitycs();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);

        }

        private void Abrir_Panel_Analitycs_Products()
        {
            if (Analitycs_PRODUCTOS.Visible == true)
                Analitycs_PRODUCTOS.Visible = false;
            else
                Analitycs_PRODUCTOS.Visible = true;
        }
        int contador;
        private void timer_hora_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador - 1;
            if (contador == 0)
            {
                this.timer1.Enabled = false;
                frmNOVEDADES_DEL_DIA novedades = new frmNOVEDADES_DEL_DIA();
                novedades.ShowDialog();
            }
        }

        private void btnCategoria_MouseEnter_1(object sender, EventArgs e)
        {
            btnCategoria.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btnCategoria_MouseLeave_1(object sender, EventArgs e)
        {
            btnCategoria.BaseColor = Color.FromArgb(83, 82, 237);

        }

        private void btnProductos_MouseEnter_1(object sender, EventArgs e)
        {
            btnProductos.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btnProductos_MouseLeave_1(object sender, EventArgs e)
        {
            btnProductos.BaseColor = Color.FromArgb(83, 82, 237);

        }

        private void uI_ShadowPanel3_MouseEnter(object sender, EventArgs e)
        {
            uI_ShadowPanel3.BackColor = Color.FromArgb(55, 4, 120);

        }

        private void uI_ShadowPanel3_MouseLeave(object sender, EventArgs e)
        {
            uI_ShadowPanel3.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnAnalitics_Productos_Top_10_MouseEnter(object sender, EventArgs e)
        {
            btnAnalitics_Productos_Top_10.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void btnAnalitics_Productos_Top_10_MouseLeave(object sender, EventArgs e)
        {
            btnAnalitics_Productos_Top_10.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnAnalitics_Combos_Top_10_MouseEnter(object sender, EventArgs e)
        {
            btnAnalitics_Combos_Top_10.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void btnAnalitics_Combos_Top_10_MouseLeave(object sender, EventArgs e)
        {
            btnAnalitics_Combos_Top_10.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnAnalitics_Medicina_Top_10_MouseEnter(object sender, EventArgs e)
        {
            btnAnalitics_Medicina_Top_10.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void btnAnalitics_Medicina_Top_10_MouseLeave(object sender, EventArgs e)
        {
            btnAnalitics_Medicina_Top_10.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnAnalitics_Servicios_Top_10_MouseLeave(object sender, EventArgs e)
        {
            btnAnalitics_Servicios_Top_10.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnAnalitics_Servicios_Top_10_MouseEnter(object sender, EventArgs e)
        {
            btnAnalitics_Servicios_Top_10.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void btnAnalitics_Global_Top_10_MouseEnter(object sender, EventArgs e)
        {
            btnAnalitics_Global_Top_10.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void btnAnalitics_Global_Top_10_MouseLeave(object sender, EventArgs e)
        {
            btnAnalitics_Global_Top_10.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnAnalitics_Combos_Top_10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_VER_TOP_5_POR_TIPOS("Combo"));
            Abrir_Panel_Analitycs_Products();
            Abrir_Panel_Analitycs();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void btnAnalitics_Medicina_Top_10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_VER_TOP_5_POR_TIPOS("Medicamento"));
            Abrir_Panel_Analitycs_Products();
            Abrir_Panel_Analitycs();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void btnAnalitics_Servicios_Top_10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_VER_TOP_5_POR_TIPOS("Servicio"));
            Abrir_Panel_Analitycs_Products();
            Abrir_Panel_Analitycs();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void btnAnalitics_Global_Top_10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_VER_TOP_GLOBAL());
            Abrir_Panel_Analitycs_Products();
            Abrir_Panel_Analitycs();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            btnReportes.BaseColor = Color.FromArgb(250, 209, 38);

        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.BaseColor = Color.FromArgb(83, 82, 237);

        }

        private void label14_Click(object sender, EventArgs e)
        {
            ABRIR_PANEL_REPORTES();
        }
        private void ABRIR_PANEL_REPORTES()
        {
            if (panel_Reportes.Visible == true)
                panel_Reportes.Visible = false;
            else
                panel_Reportes.Visible = true;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            ABRIR_ANALITYCS_VENTAS();
        }
        private void ABRIR_ANALITYCS_VENTAS()
        {
            if (panel_AnalitycsReportes.Visible == true)
                panel_AnalitycsReportes.Visible = false;
            else
                panel_AnalitycsReportes.Visible = true;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_VENTAS_CRUZADAS_POR_AÑOS());
            ABRIR_PANEL_REPORTES();
            ABRIR_ANALITYCS_VENTAS();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Ventas_Cruzadas_Por_Tipo("Producto"));
            ABRIR_PANEL_REPORTES();
            ABRIR_ANALITYCS_VENTAS();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Ventas_Cruzadas_Por_Tipo("Medicamento"));
            ABRIR_PANEL_REPORTES();
            ABRIR_ANALITYCS_VENTAS();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Ventas_Cruzadas_Por_Tipo("Servicio"));
            ABRIR_PANEL_REPORTES();
            ABRIR_ANALITYCS_VENTAS();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Ventas_Cruzadas_Por_Tipo("Combo"));
            ABRIR_PANEL_REPORTES();
            ABRIR_ANALITYCS_VENTAS();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Ventas_Cruzadas_Por_Tipo("General"));
            ABRIR_PANEL_REPORTES();
            ABRIR_ANALITYCS_VENTAS();
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Abrir_panel_citas();
        }
        private void Abrir_panel_citas()
        {
            if (panel_analisis_citas.Visible == true)
                panel_analisis_citas.Visible = false;
            else
                panel_analisis_citas.Visible = true;
        }

        private void panel17_MouseEnter(object sender, EventArgs e)
        {
            panel17.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel17_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_CITA_ESTADISTICA());
            panel_analisis_citas.Visible = false;
            panel_Menu_Analytics.Visible = false;
            AbrirSubmenu();
            txtTITULO.Text = "Dashboard";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Comprobantes_Recepcion());
            ABRIR_PANEL_REPORTES();
            AbrirSubmenu();
            txtTITULO.Text = "Recepcion";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            AbrirFormulario (new frm_Report_FACS());
            ABRIR_PANEL_REPORTES();
            AbrirSubmenu();
            txtTITULO.Text = "Factura";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void label27_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form_RECEPCION_PRODUCTOS_CRUZADA());
            ABRIR_PANEL_REPORTES();
            AbrirSubmenu();
            txtTITULO.Text = "Recepcion";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnRecetas_MouseEnter(object sender, EventArgs e)
        {
            btnRecetas.BackColor = Color.FromArgb(33, 2, 73);

        }

        private void btnRecetas_MouseLeave(object sender, EventArgs e)
        {
            btnRecetas.BackColor = Color.FromArgb(103, 23, 205);

        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmOPCION_RECETAS());
            ABRIR_PANEL_REPORTES();
            AbrirSubmenu();
            txtTITULO.Text = "Recetas Medicas";
            ///////////////////////////////////////////KELLY XD
            panel_superior.UIBottomRight = Color.FromArgb(69, 228, 255);
            panel_superior.UIBottomLeft = Color.FromArgb(41, 59, 255);
        }

    }
}
