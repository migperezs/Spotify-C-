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
using System.Windows.Shapes;
using System.Media;


namespace Spotify
{
    /// <summary>
    /// Lógica de interacción para Cuenta.xaml
    /// </summary>
    public partial class Cuenta : Window
    {
        public Cuenta()
        {
            //No me baje nota por esto porfa se lo ruego 
            //Hay un MediaElement con chayan sonando de fondo 
            //Lo puede quitar con el LoadedBehavior
            //Aveces no suena, así que lo dejé como easter egg
            InitializeComponent();
        }

        private void btnKill_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
