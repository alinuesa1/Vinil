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

using System.Windows;

using System.Windows;
using System.Windows.Controls;

using System.Windows;

namespace AppVinilos
{
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }
        private void DetalleDiscos_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de gestionar discos
            DetallesDiscos detallesDiscos = new DetallesDiscos();
            detallesDiscos.ShowDialog();
        }

        private void GestionarArtistas_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de gestionar artistas
            DetallesArtistas gestionarArtistasWindow = new DetallesArtistas();
            gestionarArtistasWindow.ShowDialog();
        }

        private void GestionarOfertas_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de gestionar ofertas
            GestionarOfertasControl gestionarOfertasWindow = new GestionarOfertasControl();
            gestionarOfertasWindow.ShowDialog();
        }

        private void HistorialPedidos_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de historial de pedidos
            HistorialPedidosControl historialPedidosWindow = new HistorialPedidosControl();
            historialPedidosWindow.ShowDialog();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            // Puedes agregar lógica para cerrar la ventana principal o implementar
            // la navegación entre ventanas según tus necesidades.
            Close();
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
    }
}
