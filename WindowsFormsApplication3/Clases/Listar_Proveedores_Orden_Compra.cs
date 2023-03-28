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
    class Listar_Proveedores_Orden_Compra
    {
        cConexion conexion = new cConexion();
        private int ProveedorID;
        private string NombreCompania;
        private string NumeroIdentificacion;
        private int Sucursal;
        public string PalabraClave;

        public int ProveedorID_
        {
            get { return ProveedorID; }
            set { ProveedorID = value; }
        }
        public string NombreCompania_
        {
            get { return NombreCompania; }
            set { NombreCompania = value; }
        }
        public string NumeroIdentificacion_
        {
            get { return NumeroIdentificacion; }
            set { NumeroIdentificacion = value; }
        }
        public int Sucursal1
        {
            get { return Sucursal; }
            set { Sucursal = value; }
        }



      
       
        



        public List<Listar_Proveedores_Orden_Compra> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_PROVEEDORES_BUSCAR_PROD", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@Palabra", PalabraClave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<Listar_Proveedores_Orden_Compra> lstEspe = new List<Listar_Proveedores_Orden_Compra>();
            Listar_Proveedores_Orden_Compra objeraza;
            while (dr.Read())
            {
                objeraza = new Listar_Proveedores_Orden_Compra();
                objeraza.ProveedorID_ = dr.GetInt32(0);
                objeraza.NombreCompania_ = dr.GetString(1);
                objeraza.NumeroIdentificacion_ = dr.GetString(2);
                objeraza.Sucursal1 = dr.GetInt32(3);             
               lstEspe.Add(objeraza);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEspe;
        }

    }
}
