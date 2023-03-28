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
    public partial class frmMENU_IVAS : Form
    {
        int posicion;
        int fila;
        int iva_ID_DATA;
        public frmMENU_IVAS()
        {
            InitializeComponent();
        }

        private void frmMENU_IVAS_Load(object sender, EventArgs e)
        {
            csListar_IVA_DATAGRID listarIVA = new csListar_IVA_DATAGRID();
            dtg_IVAS.DataSource = listarIVA.listarIVA();
        }

        private void btnGaurdar_Click(object sender, EventArgs e)
        {
            csIVA crearIVA = new csIVA(iva_ID_DATA,txtCodigo.Text, txtDescripcion.Text, Decimal.Parse(txtPorcentaje.Text) / 100);
            if (crearIVA.Verficiar_noti == 1)
            {
                notifica.TitleText = "IVA EDITADO";
                notifica.Text = "Modificado";
                notifica.EnabledNoti = true;
                txtCodigo.Text = ""; txtDescripcion.Text = ""; txtPorcentaje.Text = "";
                csListar_IVA_DATAGRID listarIVA = new csListar_IVA_DATAGRID();
                dtg_IVAS.DataSource = listarIVA.listarIVA();
                btnCrear.Visible = true;
                btnCrear.Enabled = true;
                btnGaurdar.Visible = false; btnGaurdar.Enabled = false; btnCrear.BringToFront();
            }
            else
                notifica_error.EnabledNoti = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            csIVA crearIVA = new csIVA(txtCodigo.Text,txtDescripcion.Text,Decimal.Parse(txtPorcentaje.Text)/100);
            if (crearIVA.Verficiar_noti == 1)
            { notifica.EnabledNoti = true;
            txtCodigo.Text = ""; txtDescripcion.Text = ""; txtPorcentaje.Text = "";
            csListar_IVA_DATAGRID listarIVA = new csListar_IVA_DATAGRID();
            dtg_IVAS.DataSource = listarIVA.listarIVA();
            }
            else
                notifica_error.EnabledNoti = false;
        }

        private void dtg_IVAS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             posicion = dtg_IVAS.CurrentRow.Index;
            fila = e.RowIndex;
            DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                csIVA ivaEliminar = new csIVA(int.Parse(dtg_IVAS[0,posicion].Value.ToString()));
                if (ivaEliminar.Verficiar_noti == 1)
                {
                    notifica.TitleText = "ELIMINADO"; notifica.Text = "Se eliminó el Iva"; notifica.EnabledNoti = true;
                    csListar_IVA_DATAGRID listarIVA = new csListar_IVA_DATAGRID();
                    dtg_IVAS.DataSource = listarIVA.listarIVA();
                }
                else
                    notifica_error.EnabledNoti = true;
            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {
                iva_ID_DATA = int.Parse(dtg_IVAS[0, posicion].Value.ToString());
                txtCodigo.Text = dtg_IVAS[1, posicion].Value.ToString();
                txtDescripcion.Text = dtg_IVAS[2, posicion].Value.ToString();
                txtPorcentaje.Text =dtg_IVAS[3, posicion].Value.ToString();
                btnCrear.Visible = false;
                btnCrear.Enabled = false;
                btnGaurdar.Visible = true; btnGaurdar.Enabled = true; btnGaurdar.BringToFront();
            }
        }
    }
}
