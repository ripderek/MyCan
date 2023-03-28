using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class csValidarCampos
    {
        public int comprobartamaño = 0;
        public int comprobar = 0;
        public int comprobarprecio = 0;

        public void TextBoxVacios(TextBox text, string otro)
        {
            /*if (string.IsNullOrWhiteSpace(Nombre de la variable a evaluar)
                   ese es */
            try
            {
                if (string.IsNullOrWhiteSpace(text.Text) || text.Text == otro)
                { throw new Exception("CAMPO VACIO   "+otro); }
                else
                { comprobar = 1; }
            }
            catch(Exception n )
            {
                string mensaje = "Mensaje Error = " + n.Message;
                //MessageBox.Show(mensaje,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }
        public void TextBoxPrecio(TextBox precio,string errorx = "PRECIO NO VALIDO")
        {
            try
            {
                ulong Iprecio = ulong.Parse(precio.Text);

                if (string.IsNullOrWhiteSpace(precio.Text)) { throw new Exception("CAMPO(S) VACIO "); }
                else
                { comprobarprecio = 1; }
            }
            catch (Exception n)
            {
                string mensaje =  errorx + "  "+"( EVITE USAR : , . - / + `Ç ) = " + n.Message;
                //MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comprobarprecio = 0;
            }
        }


        public void tamaño(TextBox txt, int cantidad)
        {
            var cadena = txt.Text;
            try
            {
                if (cadena.Length < cantidad)
                { throw new Exception("VALOR MINIMO ACEPTADO ES DE " + cantidad + " CARACTERES"); }
                else
                {
                    comprobartamaño = 1;
                }
            }

            catch (Exception Ca)
            {
                MessageBox.Show(Ca.Message);
            }
        }

    }
 
}
