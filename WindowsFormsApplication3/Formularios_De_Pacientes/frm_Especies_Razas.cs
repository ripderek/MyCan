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
    public partial class frm_Especies_Razas : Form
    {
       int id_especie;
        int fila;
        int posicion;

        public frm_Especies_Razas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerar_MouseLeave(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Transparent;
            btnCerar.ForeColor = Color.White;
           
        }

        private void btnCerar_MouseEnter(object sender, EventArgs e)
        {
            btnCerar.BackColor = Color.Red;
            btnCerar.ForeColor = Color.Black;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtNombre_especie, "Especie");
            int comprobrar = valida.comprobar;

            if (comprobrar == 1)
            {
                csEspecie_Raza_Animal objespecie = new csEspecie_Raza_Animal();
                objespecie.Nombre_Especie = txtNombre_especie.Text;
                objespecie.InsertarEspecie();
                txtNombre_especie.Text = "";
                notifi_agregar_especie.EnabledNoti = true;
                try
                {
                    ListasEspecies listE = new ListasEspecies();
                    dtgvEspecie.DataSource = listE.listarEspecie();
                }
                catch (Exception en)
                { MessageBox.Show(en.Message); }
            }
            else
            {
                MessageBox_Campos_Vacios ms2 = new MessageBox_Campos_Vacios();
                ms2.ShowDialog();
            }
        }

        private void frm_Especies_Razas_Load(object sender, EventArgs e)
        {
            try
            {
                ListasEspecies listE = new ListasEspecies();
                dtgvEspecie.DataSource = listE.listarEspecie();
            }
            catch (Exception en)
            { MessageBox.Show(en.Message); }
        }

        private void dtgvEspecie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgvEspecie.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            id_especie = int.Parse((dtgvEspecie[0, posicion].Value.ToString()));
            MessageBox.Show(dtgvEspecie[0, posicion].Value.ToString());
            //MODIFICAR 
            //LLENAR EL OTRO DATAGRIDVIEW CON LOS DATOS DE LA RAZA SEGUN LA ESPECIE 
            try
            {
                ListarRazas listra = new ListarRazas();
                listra.ID_ES = id_especie;
                dtgvRazas.DataSource = listra.listarRazas();

            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }




        }

        private void uI_ButtonMaterial1_Click(object sender, EventArgs e)
        {
            csValidarCampos valida = new csValidarCampos();
            valida.TextBoxVacios(txtRaza, "Raza");
            int comprobrar = valida.comprobar;

            if (dtgvRazas.DataSource == null)
            {
                MessageBox.Show("Debe selecionar una especie");
            }
            else
            {

            if (comprobrar == 1)
            {
                try
                {
                    MessageBox.Show(id_especie.ToString());
                    csEspecie_Raza_Animal objRaza = new csEspecie_Raza_Animal();
                    objRaza.ID_ES = id_especie;
                    objRaza.Raza_Animal = txtRaza.Text;
                    objRaza.InsertarRaza();
                }
                catch (Exception me)
                {
                    MessageBox.Show(me.Message);
                }
                //ACTUALIZAR EL DATAGRIDVIEW DE LAS RAZAS
                try
                {
                    ListarRazas listra = new ListarRazas();
                    listra.ID_ES = id_especie;
                    dtgvRazas.DataSource = listra.listarRazas();

                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message);
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
}
