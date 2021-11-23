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
using System.IO;

namespace Spotify
{
    /// <summary>
    /// Lógica de interacción para AgregarPlaylist.xaml
    /// </summary>
    public partial class AgregarPlaylist : Window
    {
        //La forma en que pensé la creación de playlists 
        //Es la misma que de spotify 
        //Así que primero se crea una "playlist vacía" (de verdad es el nombre nomás)
        //Y lo guardo a un listado de playlists 

        string strPlaylist; 
        public AgregarPlaylist()
        {
            InitializeComponent();        
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            GrabarPlaylist(strPlaylist);
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            strPlaylist = txtNombre.Text; 
        }

        static void GrabarPlaylist(string strPlaylist)
        {
            FileStream f;
            StreamWriter Wf;

            StringBuilder linea;

            try
            {
                //Acá guardo el nombre de la playlist en el txt. 
                f = new FileStream("listadoPlaylist.txt", FileMode.Append, FileAccess.Write);
                Wf = new StreamWriter(f);

                linea = new StringBuilder();

                linea.Append(strPlaylist);
                


                Wf.WriteLine(linea);

                MessageBox.Show(strPlaylist + " " + "creada");
                Wf.Close();
                f.Close();


            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtNombre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "Mi playlist #1") { txtNombre.Text = ""; }
        }

        private void txtDescripcion_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtDescripcion.Text == "Ponle a tu playlist una descripción pulenta.") { txtDescripcion.Text = ""; }
        }
    }
}
