using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    class csRecintos
    {
        cConexion conexion = new cConexion();
        private string recinto_name;
        private int especie_id;
        private string descripcion;
        private int estado;

        public string Recinto_name_
        {
            get { return recinto_name; }
            set { recinto_name = value; }
        }
        public int Especie_id_
        {
            get { return especie_id; }
            set { especie_id = value; }
        }
        public string Descripcion_
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Estado_
        {
            get { return estado; }
            set { estado = value; }
        }
        //CONSTRUCTOR PARA REALIZAR EL REGISTRO DEL RECINTO
        public csRecintos()
        {
            REGISTRAR_RECINTOS();
        }
        private void REGISTRAR_RECINTOS()
        {
        }
    }
}
