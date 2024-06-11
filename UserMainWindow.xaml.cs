using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace AppVinilos
{
    public partial class UserMainWindow : Window
    {
        public UserMainWindow()
        {
            InitializeComponent();
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
        private void BtnTienda_Click(object sender, RoutedEventArgs e)
        {
            DiscosDisponibles discosDisponibles = new DiscosDisponibles();
            WindowManager.DiscosDisponiblesInstance = discosDisponibles;
            WindowManager.DiscosDisponiblesInstance.Show();
            this.Hide();
        }
        private void BtnArtistas_Click(object sender, RoutedEventArgs e)
        {
            ArtistasDisponibles artistasDisponibles = new ArtistasDisponibles();
            WindowManager.ArtistasDisponiblesInstance = artistasDisponibles;
            WindowManager.ArtistasDisponiblesInstance.Show();
            this.Hide();
        }
        private void BtnListaFavoritos_Click(object sender, RoutedEventArgs e)
        {
            FavoritosWindow favoritos = new FavoritosWindow();
            WindowManager.FavoritosWindowInstance = favoritos;
            WindowManager.FavoritosWindowInstance.Show();
            this.Hide();
        }
        private void BtnOfertas_Click(object sender, RoutedEventArgs e)
        {
            Ofertas ofertas = new Ofertas();
            WindowManager.OfertasWindowInstance = ofertas;
            WindowManager.OfertasWindowInstance.Show();
            this.Hide();
        }
        private void BtnHistorialCompras_Click(object sender, RoutedEventArgs e)
        {
            HistorialPedidos historial = new HistorialPedidos();
            WindowManager.HistorialPedidosInstance = historial;
            WindowManager.HistorialPedidosInstance.Show();
            this.Hide();
        }
        private void combobox_language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)combobox_language.SelectedItem; string selectedText = cbi.Content.ToString();
            if ((selectedText.Equals("ES") || selectedText.Equals("SP")) && !CultureInfo.CurrentCulture.Name.Equals("es-ES"))
            {
                Resources.MergedDictionaries.Add(App.SelectCulture("es-ES"));
            }
            else if (selectedText.Equals("EN")
            && !CultureInfo.CurrentCulture.Name.Equals("en-US"))
            {
                Resources.MergedDictionaries.Add(App.SelectCulture("en-US"));
            }
        }
    }
}
