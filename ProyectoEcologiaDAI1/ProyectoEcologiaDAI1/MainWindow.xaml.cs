using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoEcologiaDAI1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Cuando se presione el btIngresar, manda a ventana Ingresar
        */
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ingresar window = new Ingresar();
            this.Close();
            window.Show(); //Sale la pantalla de Ingresar 
        }

        /*
         * Cuando se presione el btIngresar, manda a ventana de NuevoUsuario
        */
        private void btNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            NuevoUsuario window = new NuevoUsuario();
            this.Close();
            window.Show();//Sale pantalla de NuevoUsuario
        }
    }
}
