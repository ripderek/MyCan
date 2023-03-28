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
    public partial class frmCliente_Agregar_Modificar : Form
    {
        public frmCliente_Agregar_Modificar(int accion=3)
        {
            InitializeComponent();
            AbrirFormulario(new frm_MC_Modificar_Crear_Personal(accion));
           
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
            panelFormulario.Controls.Add(nuevoFormulario);
            panelFormulario.Tag = nuevoFormulario;
            nuevoFormulario.Show();


        }
    }
}
