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
    /// Lógica de interacción para GestionPlaylist.xaml
    /// </summary>
    public partial class GestionPlaylist : Window
    {
        string buscador; 
        public GestionPlaylist()
        {
            //Esta ventana la hice con la intención de borrar canciones del playlist.txt 
            //Ya que en la anterior ventana ya tengo usado el click para agregar canciones 
            //Pude haber puesto algun trucazo con algunos if, pero el chorizo se convertiría en prieta
            InitializeComponent();
            cargarPlaylist();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        public class MusicaPlaylist
        {
            //template playlist
            public string Playlist { get; set; }
            public string ID { get; set; }
            public string Artista { get; set; }
            public string Album { get; set; }
            public string Cancion { get; set; }
            public string Fecha { get; set; }
        }

        public void ColumnasPlaylist()
        {
            var gv = new GridView();
            this.lsvGestion.View = gv;
            gv.Columns.Add(new GridViewColumn { Header = "Playlist", DisplayMemberBinding = new Binding("Playlist") });
            gv.Columns.Add(new GridViewColumn { Header = "ID", DisplayMemberBinding = new Binding("ID") });
            gv.Columns.Add(new GridViewColumn { Header = "Artista", DisplayMemberBinding = new Binding("Artista") });
            gv.Columns.Add(new GridViewColumn { Header = "Album", DisplayMemberBinding = new Binding("Album") });
            gv.Columns.Add(new GridViewColumn { Header = "Cancion", DisplayMemberBinding = new Binding("Cancion") });
            gv.Columns.Add(new GridViewColumn { Header = "Fecha Agregado", DisplayMemberBinding = new Binding("Fecha") });
        }

        private void cargarPlaylist()
        {
            ColumnasPlaylist();
            List<MusicaPlaylist> playlists = new List<MusicaPlaylist>();
            FileStream f;
            StreamReader rf;
            string linea;
            string[] campo;
            int i = 0;

            try
            {
                f = new FileStream("playlist.txt", FileMode.Open, FileAccess.Read);
                rf = new StreamReader(f);

                while (!rf.EndOfStream)
                {
                    linea = rf.ReadLine();
                    campo = linea.Split(';');
                    if (linea != "") //Ya que para borrar canciones del playlist.txt se cambian los valores por espacios vacios "", busco aquellos datos en el txt que no estén vacios. xq de otra forma se pingea...
                    {
                        if (i < campo.Length)
                        {
                            playlists.Add(new MusicaPlaylist() { Playlist = campo[0], ID = campo[1], Artista = campo[2], Album = campo[3], Cancion = campo[4], Fecha = campo[5] });
                        }
                    }
                    
                }
                rf.Close();
                f.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error   :" + ex);
            }
            lsvGestion.ItemsSource = playlists;
            
        }

        private void btnPlaylist_Click(object sender, RoutedEventArgs e)
        {
            if (btnPlaylist.Content as string == "a")
            {
                cargarPlaylist();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Playlist", System.ComponentModel.ListSortDirection.Descending));
                btnPlaylist.Content = "b";
            }
            else
            {
                cargarPlaylist();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Playlist", System.ComponentModel.ListSortDirection.Ascending));
                btnPlaylist.Content = "a";
            }
        }

        private void btnID_Click(object sender, RoutedEventArgs e)
        {
            if (btnID.Content as string == "a")
            {
                cargarPlaylist();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("ID", System.ComponentModel.ListSortDirection.Descending));
                btnID.Content = "b";
            }
            else
            {
                cargarPlaylist();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("ID", System.ComponentModel.ListSortDirection.Ascending));
                btnID.Content = "a";
            }
        }

        private void btnArtista_Click(object sender, RoutedEventArgs e)
        {
            if (btnArtista.Content as string == "a")
            {
                cargarPlaylist();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Artista", System.ComponentModel.ListSortDirection.Descending));
                btnArtista.Content = "b";
            }
            else
            {
                cargarPlaylist();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Artista", System.ComponentModel.ListSortDirection.Ascending));
                btnArtista.Content = "a";
            }
        }

        private void btnAlbum_Click(object sender, RoutedEventArgs e)
        {
            if (btnAlbum.Content as string == "a")
            {
                cargarPlaylist();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Album", System.ComponentModel.ListSortDirection.Descending));
                btnAlbum.Content = "b";
            }
            else
            {
                cargarPlaylist();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Album", System.ComponentModel.ListSortDirection.Ascending));
                btnAlbum.Content = "a";
            }
        }

        private void btnCancion_Click(object sender, RoutedEventArgs e)
        {
            if (btnCancion.Content as string == "a")
            {
                cargarPlaylist();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Cancion", System.ComponentModel.ListSortDirection.Descending));
                btnCancion.Content = "b";
            }
            else
            {
                cargarPlaylist();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Cancion", System.ComponentModel.ListSortDirection.Ascending));
                btnCancion.Content = "a";
            }
        }

        private void btnFecha_Click(object sender, RoutedEventArgs e)
        {
            if (btnFecha.Content as string == "a")
            {
                //No estoy seguro si esta parte con fecha funciona bien 
                //ya que el algoritmo de la función que usé para ordenar no la conozco del todo bien 
                cargarPlaylist();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Fecha", System.ComponentModel.ListSortDirection.Descending));
                btnFecha.Content = "b";
            }
            else
            {
                cargarPlaylist();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvGestion.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Fecha", System.ComponentModel.ListSortDirection.Ascending));
                btnFecha.Content = "a";
            }
        }

        private void txtBuscar_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtBuscar.Text == "Buscar") { txtBuscar.Text = ""; }
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            buscador = txtBuscar.Text;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese Artista/Album/Canción a buscar");
            }
            else
            {
                Buscador(buscador);
            }
        }

        private void Buscador(string buscador)
        {
            ColumnasPlaylist();
            List<MusicaPlaylist> catalogos = new List<MusicaPlaylist>();
            FileStream f;
            StreamReader rf;
            string linea;
            string[] campo;
            int i = 0;

            try
            {
                f = new FileStream("playlist.txt", FileMode.Open, FileAccess.Read);
                rf = new StreamReader(f);

                while (!rf.EndOfStream)
                {
                    linea = rf.ReadLine();
                    campo = linea.Split(';');
                    if (i < campo.Length)
                    {
                        if (linea.Contains(buscador))
                        {
                            catalogos.Add(new MusicaPlaylist() {Playlist = campo[0], ID = campo[1], Artista = campo[2], Album = campo[3], Cancion = campo[4], Fecha = campo[5] });
                        }

                    }
                }
                rf.Close();
                f.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error   :" + ex);
            }
            lsvGestion.ItemsSource = catalogos;
        }

        private void lsvGestion_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Acá se eliminan canciones de la playlist individualmente. 
            //Para eliminar tuve que usar otras funciones que encontré 
            //Porque con el StringBuilder no me resultó (y lo intenté con todo profe se lo juro) 
            ColumnasPlaylist();
            MessageBoxResult resultado = MessageBox.Show("Desea eliminarlo de la playlist?", "", MessageBoxButton.YesNo);
            if (resultado == MessageBoxResult.Yes)
            {
                dynamic seleccion = lsvGestion.SelectedItem;

                List<MusicaPlaylist> musicaPlaylists = new List<MusicaPlaylist>();
                FileStream f;
                StreamReader rf;
                StreamWriter Wf;
                StringBuilder builder;
                string linea;
                string[] campo;
                int i = 0;
                int j = 0; 
                try
                {
                    f = new FileStream("playlist.txt", FileMode.Open, FileAccess.ReadWrite);
                    rf = new StreamReader(f);
                    Wf = new StreamWriter(f);
                    builder = new StringBuilder();
                    while (!rf.EndOfStream)
                    {
                        linea = rf.ReadLine();
                        campo = linea.Split(';');
                        if (j < campo.Length)
                        {
                            if (campo[0].ToString() == seleccion.Playlist)
                            {
                                if (campo[1].ToString() == seleccion.ID)
                                {
                                    //Acá hay algo raro profe, pero en teoría es un problema con los if 
                                    //No lo logré solucionar lo siento):
                                }

                                else
                                {
                                    musicaPlaylists.Add(new MusicaPlaylist() { Playlist = campo[0], ID = campo[1], Artista = campo[2], Album = campo[3], Cancion = campo[4], Fecha = campo[5] });

                                    builder.Append(musicaPlaylists[j].Playlist);
                                    builder.Append(";");
                                    builder.Append(musicaPlaylists[j].ID);
                                    builder.Append(";");
                                    builder.Append(musicaPlaylists[j].Artista);
                                    builder.Append(";");
                                    builder.Append(musicaPlaylists[j].Album);
                                    builder.Append(";");
                                    builder.Append(musicaPlaylists[j].Cancion);
                                    builder.Append(";");
                                    builder.Append(musicaPlaylists[j].Fecha);
                                    builder.Append("\n"); //Esto fue importante porque dejé la cagá sin el salto de línea en un principio.
                                    Wf.WriteLine(builder);

                                }
                            }

                            else 
                            {
                                musicaPlaylists.Add(new MusicaPlaylist() { Playlist = campo[0], ID = campo[1], Artista = campo[2], Album = campo[3], Cancion = campo[4], Fecha = campo[5] });
                                
                                builder.Append(musicaPlaylists[j].Playlist);
                                builder.Append(";");
                                builder.Append(musicaPlaylists[j].ID);
                                builder.Append(";");
                                builder.Append(musicaPlaylists[j].Artista);
                                builder.Append(";");
                                builder.Append(musicaPlaylists[j].Album);
                                builder.Append(";");
                                builder.Append(musicaPlaylists[j].Cancion);
                                builder.Append(";");
                                builder.Append(musicaPlaylists[j].Fecha);
                                builder.Append("\n"); //Esto fue importante porque dejé la cagá sin el salto de línea en un principio.
                                Wf.WriteLine(builder);
                           
                            }
                             
                                                   
                        }
                        j++;
                    }
                    rf.Close();
                    f.Close();
                    System.IO.File.WriteAllText("playlist.txt", builder.ToString());
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error   :" + ex);
                }
            }
            ColumnasPlaylist();
            cargarPlaylist();        
        }
    
    }
}
