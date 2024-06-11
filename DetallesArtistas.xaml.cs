using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public partial class DetallesArtistas : Window
    {
        public DetallesArtistas()
        {
            InitializeComponent();
            listBoxArtistas.ItemsSource = ArtistaData.Artistas;
        }

        private void BtnCrearArtista_Click(object sender, RoutedEventArgs e)
        {
            CrearArtista crearArtistaWindow = new CrearArtista();
            if (crearArtistaWindow.ShowDialog() == true)
            {
                ArtistaData.Artistas.Add(crearArtistaWindow.NuevoArtista);
                listBoxArtistas.Items.Refresh();
            }
        }

        private void BtnEditarArtista_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxArtistas.SelectedItem is Artista selectedArtista)
            {
                var editarArtistaWindow = new EditarArtista(selectedArtista);
                if (editarArtistaWindow.ShowDialog() == true)
                {
                    // Actualizar los valores del artista con los valores editados
                    selectedArtista.NombreArtistico = editarArtistaWindow.ArtistaEditado.NombreArtistico;
                    selectedArtista.NombreReal = editarArtistaWindow.ArtistaEditado.NombreReal;
                    selectedArtista.Componentes = editarArtistaWindow.ArtistaEditado.Componentes;
                    selectedArtista.FechaNacimientoOCreacion = editarArtistaWindow.ArtistaEditado.FechaNacimientoOCreacion;
                    selectedArtista.Descripcion = editarArtistaWindow.ArtistaEditado.Descripcion;
                    selectedArtista.GeneroMusical = editarArtistaWindow.ArtistaEditado.GeneroMusical;
                    selectedArtista.EnlacesRedesSociales = new List<string>(editarArtistaWindow.ArtistaEditado.EnlacesRedesSociales);
                    selectedArtista.NumeroFavoritos = editarArtistaWindow.ArtistaEditado.NumeroFavoritos; // Aquí se usa NumeroFavoritos
                    selectedArtista.GaleriaImagenes = new List<BitmapImage>(editarArtistaWindow.ArtistaEditado.GaleriaImagenes);
                    selectedArtista.Discografia = new List<DiscoVinilo>(editarArtistaWindow.ArtistaEditado.Discografia);
                    listBoxArtistas.Items.Refresh();
                }
            }
        }

        private void BtnBorrarArtista_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxArtistas.SelectedItem != null)
            {
                Artista artistaSeleccionado = (Artista)listBoxArtistas.SelectedItem;
                MessageBoxResult result = MessageBox.Show($"¿Estás seguro de borrar al artista '{artistaSeleccionado.NombreArtistico}'?", "Borrar Artista", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    ArtistaData.Artistas.Remove(artistaSeleccionado);
                    listBoxArtistas.Items.Refresh();
                }
                else
                {
                    listBoxArtistas.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artista para borrar.", "Borrar Artista", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            WindowManager.AdminMainWindowInstance = adminMainWindow;
            WindowManager.AdminMainWindowInstance.Show();
            this.Hide();
        }
        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            WindowManager.HelpInstance = help;
            WindowManager.HelpInstance.Show();
            this.Hide();
        }
        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar sesión y redirigir a la MainWindow
            MessageBox.Show("Cerrando sesión...");

            LoginWindow loginWindow = new LoginWindow();
            WindowManager.LoginWindowInstance = loginWindow;
            WindowManager.LoginWindowInstance.Show();
            this.Hide();
        }
    }
}
