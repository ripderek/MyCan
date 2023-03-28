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
    public partial class frmVACUNAScs : Form
    {
        int posicion;
        int fila;
        int medicamento_id;
        public frmVACUNAScs()
        {
            InitializeComponent();
        }

        private void picAgregarProducto_Click(object sender, EventArgs e)
        {
            Personalizacion per = new Personalizacion(new frmCrear_Modiciar_Medicamento());
            Listar_Medicamentos_DATA medicadata = new Listar_Medicamentos_DATA();
            dt_vacunas.DataSource = medicadata.listarIVA();
        }

        private void frmVACUNAScs_Load(object sender, EventArgs e)
        {
            Listar_Medicamentos_DATA medicadata = new Listar_Medicamentos_DATA();
            dt_vacunas.DataSource = medicadata.listarIVA();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_vacunas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dt_vacunas.CurrentRow.Index;
            fila = e.RowIndex;
            DialogResult resultado = new DialogResult();
            Form mensaje = new messageboxAccionOrden();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                csMedicamentos eliminar = new csMedicamentos(int.Parse(dt_vacunas[0, posicion].Value.ToString()));
                Listar_Medicamentos_DATA medicadata = new Listar_Medicamentos_DATA();
                dt_vacunas.DataSource = medicadata.listarIVA();
                if (eliminar.Verificar == 1)
                {
                    notifica.EnabledNoti = true;
                }
                else
                    notifica_error.EnabledNoti = true;

            }
            else if (resultado == DialogResult.Ignore) //EDITAR
            {                   
                //                                                                                                                                                                                                                  int categoria=0, int estado=0 ,int accion=0
                Personalizacion per = new Personalizacion(new frmCrear_Modiciar_Medicamento(int.Parse(dt_vacunas[0, posicion].Value.ToString()), dt_vacunas[1, posicion].Value.ToString(), dt_vacunas[2, posicion].Value.ToString(), dt_vacunas[4, posicion].Value.ToString(), int.Parse(dt_vacunas[6, posicion].Value.ToString()), int.Parse(dt_vacunas[7, posicion].Value.ToString()), 1  /**/));
                Listar_Medicamentos_DATA medicadata = new Listar_Medicamentos_DATA();
                dt_vacunas.DataSource = medicadata.listarIVA();
            }
        }
    }
}
