using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApplication3
{
    public partial class frmNOVEDADES_DEL_DIA : Form
    {
        SpeechSynthesizer syn = new SpeechSynthesizer();
        List<VoiceInfo> vocesInfo = new List<VoiceInfo>();
        //PARA LAS VOCES XD

        public frmNOVEDADES_DEL_DIA()
        {
            InitializeComponent();
            cs_Novedades_Para_el_dia nove = new cs_Novedades_Para_el_dia();
            txtStock.Text =  nove.Productos_stock.ToString() + " Producto(s) sin Stock";
            txtCitas.Text =  nove.Numero_citas_.ToString() + " Cita(s) para hoy";
            txtOfertas.Text =  nove.Numero_ofertas.ToString() + " Oferta(s) programadas";
            //VOCES
            foreach (InstalledVoice voice in syn.GetInstalledVoices())
            {
                vocesInfo.Add(voice.VoiceInfo);

            }
            string nombre = vocesInfo.ElementAt(0).Name;
            syn.SelectVoice(nombre);
            syn.Volume = 100;
            syn.Rate = -1;
            syn.Speak("Estas son las novedades del dia");

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOfertas_Enter(object sender, EventArgs e)
        {

        }
    }
}
