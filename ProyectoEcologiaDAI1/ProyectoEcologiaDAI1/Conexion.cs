using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoEcologiaDAI1
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection conexion;

            try
            {
                conexion = new SqlConnection("Copy paste");
                conexion.Open();
                MessageBox.Show("Conectado");//Quitar
            }
            catch(Exception e)
            {
                conexion = null;
                MessageBox.Show("no conectado" + e);//Quitar
            }
        }
    }
}
