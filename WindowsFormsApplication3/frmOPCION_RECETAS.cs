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
    public partial class frmOPCION_RECETAS : Form
    {
        int posicion;
        int fila; 

        public frmOPCION_RECETAS()
        {
            InitializeComponent();
        }

        private void frmOPCION_RECETAS_Load(object sender, EventArgs e)
        {
          
            LISTAR_RECETAS_FRM_OPCION listar = new LISTAR_RECETAS_FRM_OPCION();
            dt_Recetas.DataSource = listar.listarRECETAS();
        }

        private void dt_Recetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion=dt_Recetas.CurrentRow.Index;
            fila = e.RowIndex;
            int id = int.Parse(dt_Recetas[0, posicion].Value.ToString());
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECETA_NUEVA.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_RECETA_NUEVA.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECETA_NUEVA.SP_VER_DETALLE_RECETA_MEDICA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DETALLE_RECETA_MEDICATableAdapter.Fill(this.DataSet_RECETA_NUEVA.SP_VER_DETALLE_RECETA_MEDICA, id);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECETA_NUEVA.SP_VER_RECETA_MEDICA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_RECETA_MEDICATableAdapter.Fill(this.DataSet_RECETA_NUEVA.SP_VER_RECETA_MEDICA, id);
            this.reportViewer1.RefreshReport();

        }
    }
}
