using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using static AppVinilos.HistorialPedidosControl;

namespace AppVinilos
{
    public partial class HistorialPedidos : Window
    {
        public HistorialPedidos()
        {
            InitializeComponent();
            List<Pedido> pedidos = new List<Pedido>
            {
                new Pedido { IdPedido = 1, Fecha = new DateTime(2024, 1, 15), Total = 49.99m, Estado = "Completado" },
                new Pedido { IdPedido = 2, Fecha = new DateTime(2024, 2, 10), Total = 89.50m, Estado = "En proceso" },
                new Pedido { IdPedido = 3, Fecha = new DateTime(2024, 3, 5), Total = 19.99m, Estado = "Cancelado" },
                new Pedido { IdPedido = 4, Fecha = new DateTime(2024, 4, 20), Total = 120.75m, Estado = "Completado" },
                new Pedido { IdPedido = 5, Fecha = new DateTime(2024, 5, 25), Total = 69.30m, Estado = "En proceso" }
            };
            listBoxPedidos.ItemsSource = pedidos;
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
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}
