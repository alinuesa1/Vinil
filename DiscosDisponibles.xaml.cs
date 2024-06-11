using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    
    public partial class DiscosDisponibles : Window
    {
        public DiscosDisponibles()
        {
            InitializeComponent();
            listBoxDiscos.ItemsSource = DiscosData.Discos;
        }
        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDiscos.SelectedItem is DiscoVinilo selectedDisco)
            {
                MessageBox.Show($"Añadiendo al carrito: {selectedDisco.Titulo}");
                CarritoGlobal.AddToCarrito(selectedDisco);
                CarritoCompra carritoCompra = new CarritoCompra();
                carritoCompra.Show();
            }
        }
        private void MoreDetails_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDiscos.SelectedItem is DiscoVinilo discoSeleccionado)
            {
                MasDetalles ventanaDetalles = new MasDetalles(discoSeleccionado);
                ventanaDetalles.ShowDialog();
            }
        }
        private void AddToFavorites_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as FrameworkElement)?.DataContext is DiscoVinilo selectedDisco)
            {
                selectedDisco.EnFavoritos = !selectedDisco.EnFavoritos;
                if (selectedDisco.EnFavoritos)
                {
                    MessageBox.Show($"Disco añadido a favoritos: {selectedDisco.Titulo}");
                    FavoritosGlobal.AddToFavoritos(selectedDisco);
                }
                else
                {
                    MessageBox.Show($"Disco eliminando de favoritos: {selectedDisco.Titulo}");
                    FavoritosGlobal.RemoveFromFavoritos(selectedDisco);
                }
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
    public static class FavoritosGlobal
    {
        public static List<DiscoVinilo> Favoritos { get; } = new List<DiscoVinilo>();
        public static void AddToFavoritos(DiscoVinilo disco)
        {
            if (!Favoritos.Contains(disco))
            {
                Favoritos.Add(disco);
            }
        }
        public static void RemoveFromFavoritos(DiscoVinilo disco)
        {
            if (Favoritos.Contains(disco))
            {
                Favoritos.Remove(disco);
            }
        }
    }
    public class FavoritoToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool enFavoritos && enFavoritos)
            {
                return new BitmapImage(new Uri("pack://application:,,,/Imagenes/corazon2.png"));
            }
            return new BitmapImage(new Uri("pack://application:,,,/Imagenes/corazon.png"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
