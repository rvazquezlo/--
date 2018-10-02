using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoEcologiaDAI1
{
    /// <summary>
    /// Lógica de interacción para Ingresar.xaml
    /// </summary>
    public partial class Ingresar : Window
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        /*
         * Cuando se presione el btOlvideContrasena, manda a ventana de CambiarContrasena
        */
        private void btOlvideContrasena_Click(object sender, RoutedEventArgs e)
        {
            CambiarContrasena ventana;

            ventana = new CambiarContrasena();
            this.Close();
            ventana.Show();
        }

        /*
         * Cuando se presione el btAceptar, comprueba
         * contrasena y usuario. De ser correctos, los manda  manda a ventana de Inicio.
         * Si estos son incorrectos, aparece un mensaje
        */
        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader lector;
            SqlConnection conexion;

            try
            {
                conexion = Conexion.agregarConexion();
                SqlCommand comando = new SqlCommand(
                    String.Format("select contrasena from usuarios where nombreUsuario = '{0}'", tbUsuario.Text), conexion);
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    if (lector.GetString(0).Equals(pboxContrasena.Password.ToString()))
                    {
                        Inicio window = new Inicio();//Abro ventana de inicio
                        this.Close();
                        window.Show();
                    }
                    else
                        MessageBox.Show("Contrasena Inocrrecta. Intente de nuevo por favor.");
                }
                else
                    MessageBox.Show("Usuario incorrecto. Intente de nuevo por favor.");
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);//Quitar
            }

        }
    }
}
