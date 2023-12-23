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

namespace AppVinilos
{
    public partial class UserMainWindow : Window
    {
        public UserMainWindow()
        {
            InitializeComponent();
        }
        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Bienvenido a la ayuda!");
            // Aquí puedes agregar la lógica de la ayuda
        }
        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar sesión y redirigir a la MainWindow
            MessageBox.Show("Cerrando sesión...");
            // Puedes agregar aquí la lógica para cerrar sesión y redirigir a la MainWindow si es necesario
        }
        private void BtnCarrito_Click(object sender, RoutedEventArgs e)
        {
            CarritoCompra carritoCompra = new CarritoCompra();
            carritoCompra.Show();
        }
        private void BtnTienda_Click(object sender, RoutedEventArgs e)
        {
            DiscosDisponibles discosDisponibles = new DiscosDisponibles();
            discosDisponibles.Show();
        }
        private void BtnListaDeseos_Click(object sender, RoutedEventArgs e)
        {
            // Llevar la lista de deseos
            MessageBox.Show("Cerrando sesión...");
        }
        private void BtnListaFavoritos_Click(object sender, RoutedEventArgs e)
        {
            // Llevar la lista de favoritos
            MessageBox.Show("Cerrando sesión...");
        }
        private void BtnHistorialCompras_Click(object sender, RoutedEventArgs e)
        {
            // Llevar al historial de compras
            MessageBox.Show("Cerrando sesión...");
        }
    }
}
