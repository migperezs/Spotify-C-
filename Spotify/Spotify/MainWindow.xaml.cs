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
using System.Media;
using System.IO;

namespace Spotify
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Lamento la demora profesor, tuve problemas con la luz en mi casa 
        //y se murió el hdd de mi pc, menos mal era uno mecánico de 500gb.
        //Pero tuve que empezar de cero desde el miercoles en la tarde cuando llegué a mi casa. 
        //Hubieron cosas que dejé un poco desordenadas para no perder más tiempo (y decimas),
        //de todas formas me esforcé un montón. Espero le guste. 
        //Me basé en usar solamente listview en el ingreso y salida de datos a los .txt (para que se pareciera a spotify¿?)
        //Los chorizos brígidos que me salieron en algunas partes se las comentaré para explicar un poco. 
        public MainWindow()
        { 
            InitializeComponent();
        }

        private void mnuCerrar_Click(object sender, RoutedEventArgs e)
        {
            //Le puse sonido para cuando se cierra pero desde el menu contextual. 
            SoundPlayer salir = new SoundPlayer("cerrar.wav");
            salir.Play();
            System.Threading.Thread.Sleep(1100);
            this.Close(); 
        }

        private void mnuCuenta_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
            Cuenta ventana = new Cuenta();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void btnCanciones_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
            Canciones ventana = new Canciones();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void btnNuevoPlaylist_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
            AgregarPlaylist ventana = new AgregarPlaylist();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void btnPlaylist_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
            Playlist ventana = new Playlist();
            ventana.Owner = this;
            ventana.ShowDialog();
        }



    }
}
