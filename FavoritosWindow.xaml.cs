using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AppVinilos
{
    public partial class FavoritosWindow : Window
    {
        public FavoritosWindow()
        {
            InitializeComponent();
            listBoxFavoritos.ItemsSource = DiscosData.Discos.Where(disco => disco.EnFavoritos).ToList();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxFavoritos.SelectedItem is DiscoVinilo selectedDisco)
            {
                MessageBox.Show($"Añadiendo al carrito: {selectedDisco.Titulo}");
                CarritoGlobal.AddToCarrito(selectedDisco);
                CarritoCompra carritoCompra = new CarritoCompra();
                carritoCompra.Show();
            }
        }

        private void MoreDetails_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxFavoritos.SelectedItem is DiscoVinilo discoSeleccionado)
            {
                MasDetalles ventanaDetalles = new MasDetalles(discoSeleccionado);
                ventanaDetalles.ShowDialog();
            }
        }

        private void AddToFavorites_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is DiscoVinilo selectedDisco)
            {
                selectedDisco.EnFavoritos = !selectedDisco.EnFavoritos;
                listBoxFavoritos.ItemsSource = DiscosData.Discos.Where(disco => disco.EnFavoritos).ToList();
                listBoxFavoritos.Items.Refresh(); // Actualiza la lista para reflejar los cambios
            }
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            UserMainWindow userMainWindow = new UserMainWindow();
            WindowManager.UserMainWindowInstance = userMainWindow;
            WindowManager.UserMainWindowInstance.Show();
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
        private void BtnCarrito_Click(object sender, RoutedEventArgs e)
        {
            CarritoCompra carritoCompra = new CarritoCompra();
            WindowManager.CarritoCompraInstance = carritoCompra;
            WindowManager.CarritoCompraInstance.Show();
            this.Hide();
        }
    }
}
