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
    class Personalizacion
    {
        public Personalizacion(Form nuevoFormulario)
        {


            Form Fondo = new Form();

            using (nuevoFormulario)
            {
                Fondo.StartPosition = FormStartPosition.CenterScreen;
                Fondo.FormBorderStyle = FormBorderStyle.None;
                Fondo.Opacity = .70d;
                Fondo.BackColor = Color.Black;

                Fondo.Left = 0;
                Fondo.Top = 0;
                Fondo.Width = Screen.PrimaryScreen.WorkingArea.Width;
                Fondo.Height = Screen.PrimaryScreen.WorkingArea.Height;

                //Fondo.WindowState = FormWindowState.Maximized;
                //Fondo.TopMost = true;
                Fondo.ShowInTaskbar = false; //para que no se muestre en la barra de tareas 
                Fondo.Show();
               // nuevoFormulario.ShowInTaskbar = false;
                nuevoFormulario.Owner = Fondo;
                nuevoFormulario.ShowDialog();

                Fondo.Dispose();

            }
 
            }

        }
    }

