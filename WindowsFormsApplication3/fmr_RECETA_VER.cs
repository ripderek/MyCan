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
    public partial class fmr_RECETA_VER : Form
    {
        //GLOBAL 
        private int recete_id;
                                //14
        public fmr_RECETA_VER(int id)
        {
            InitializeComponent();
            recete_id = id;
        }

        private void fmr_RECETA_VER_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECETA_NUEVA.SP_VER_DATOS_VETERINARIA_DATASET01' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.Fill(this.DataSet_RECETA_NUEVA.SP_VER_DATOS_VETERINARIA_DATASET01);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECETA_NUEVA.SP_VER_DETALLE_RECETA_MEDICA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DETALLE_RECETA_MEDICATableAdapter.Fill(this.DataSet_RECETA_NUEVA.SP_VER_DETALLE_RECETA_MEDICA,recete_id);
            // TODO: esta línea de código carga datos en la tabla 'DataSet_RECETA_NUEVA.SP_VER_RECETA_MEDICA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_RECETA_MEDICATableAdapter.Fill(this.DataSet_RECETA_NUEVA.SP_VER_RECETA_MEDICA,recete_id);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
