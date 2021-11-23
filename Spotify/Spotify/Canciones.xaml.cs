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
    /// Lógica de interacción para Canciones.xaml
    /// </summary>
    public partial class Canciones : Window
    {
        //Con la lupa se busca, es un botón...
        //Lo iba a hacer de alguna otra forma más intuitiva pero preferí diseño sobre función.
        string buscador; 
        public Canciones()
        {
            InitializeComponent();
            cargarCatalogo();
            btnId.Click += btnIdClick; //Acá probé otra forma de llamar a un click. 
            btnArtista.Click += btnArtistaClick;
            btnAlbum.Click += btnAlbumClick;
            btnCancion.Click += btnCancionClick;
        }
        public class Musica
        {
            //Las clases no las logré llamar dentro de las ventanas 
            //por eso están creadas acá 
            public string ID { get; set; }
            public string Artista { get; set; }
            public string Album { get; set; }
            public string Cancion { get; set; }
        }
        public void Columnas()
        {
            //acá se crean las columnas del listview
            var gv = new GridView();
            this.lsvCanciones.View = gv;
            gv.Columns.Add(new GridViewColumn { Header = "ID", DisplayMemberBinding = new Binding("ID") });
            gv.Columns.Add(new GridViewColumn { Header = "Artista", DisplayMemberBinding = new Binding("Artista") });
            gv.Columns.Add(new GridViewColumn { Header = "Album", DisplayMemberBinding = new Binding("Album") });
            gv.Columns.Add(new GridViewColumn { Header = "Cancion", DisplayMemberBinding = new Binding("Cancion") });
        }

        private void cargarCatalogo()
        {
            //Se carga el catálogo en el listview 
            Columnas();
            List<Musica> catalogos = new List<Musica>(); //Se guardan en una lista para poder vincularlas con las columnas.
            FileStream f;
            StreamReader rf;
            string linea;
            string[] campo;
            int i = 0; 
            
            try
            {
                f = new FileStream("catalogo.txt", FileMode.Open, FileAccess.Read);
                rf = new StreamReader(f);

                while (!rf.EndOfStream)
                {
                    linea = rf.ReadLine();
                    campo = linea.Split(';');
                    if (i<campo.Length)
                    {
                        catalogos.Add(new Musica() { ID = campo[0], Artista = campo[1], Album = campo[2], Cancion = campo[3] });
                    }
                }
                rf.Close();
                f.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error   :" + ex);
            }
            lsvCanciones.ItemsSource = catalogos; //Acá lleno la listview con el catálogo de canciones.           
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            buscador = txtBuscar.Text;
        }

        private void txtBuscar_GotFocus(object sender, RoutedEventArgs e)
        {
            //watermark
            if (txtBuscar.Text == "Buscar") { txtBuscar.Text = ""; }
        }
          
        private void btnIdClick(object sender, RoutedEventArgs e)
        {
            if (btnId.Content as string == "a")
            {
                //Acá para ordenar me aproveché de las funciones existenes para listview
                cargarCatalogo(); //Pero se tiene que recargar la listview cada vez que se utiliza 
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("ID", System.ComponentModel.ListSortDirection.Descending));
                btnId.Content = "b"; 
            }
            else
            {
                cargarCatalogo();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("ID", System.ComponentModel.ListSortDirection.Ascending));
                btnId.Content = "a";
            }                    
        }

        private void btnArtistaClick(object sender, RoutedEventArgs e)
        {
            if (btnId.Content as string == "a")
            {
                cargarCatalogo();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Artista", System.ComponentModel.ListSortDirection.Descending));
                btnId.Content = "b";
            }
            else
            {
                cargarCatalogo();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Artista", System.ComponentModel.ListSortDirection.Ascending));
                btnId.Content = "a";
            }

        }

        private void btnAlbumClick(object sender, RoutedEventArgs e)
        {
            if (btnId.Content as string == "a")
            {
                cargarCatalogo();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Album", System.ComponentModel.ListSortDirection.Descending));
                btnId.Content = "b";
            }
            else
            {
                cargarCatalogo();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Album", System.ComponentModel.ListSortDirection.Ascending));
                btnId.Content = "a";
            }

        }

        private void btnCancionClick(object sender, RoutedEventArgs e)
        {
            if (btnId.Content as string == "a")
            {
                cargarCatalogo();
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Cancion", System.ComponentModel.ListSortDirection.Descending));
                btnId.Content = "b";
            }
            else
            {
                cargarCatalogo();
                CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(lsvCanciones.ItemsSource);
                collection.SortDescriptions.Add(new System.ComponentModel.SortDescription("Cancion", System.ComponentModel.ListSortDirection.Ascending));
                btnId.Content = "a";
            }

        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                //Una pequeña ayuda que dejé. 
                MessageBox.Show("Ingrese Artista/Album/Canción a buscar"); 
            }
            else
            {
                Buscador(buscador);
            }
        }

        private void Buscador(string buscador)
        {
            Columnas();
            List<Musica> catalogos = new List<Musica>();
            FileStream f;
            StreamReader rf;
            string linea;
            string[] campo;
            int i = 0;

            try
            {
                f = new FileStream("catalogo.txt", FileMode.Open, FileAccess.Read);
                rf = new StreamReader(f);

                while (!rf.EndOfStream)
                {
                    linea = rf.ReadLine();
                    campo = linea.Split(';');
                    if (i < campo.Length)
                    {
                        if (linea.Contains(buscador)) //Acá utilizo el texto ingresado en el buscador para comparar en el *.txt
                        {
                            catalogos.Add(new Musica() { ID = campo[0], Artista = campo[1], Album = campo[2], Cancion = campo[3] });
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
            //Se carga el catálogo con los datos buscados. 
            lsvCanciones.ItemsSource = catalogos;

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
