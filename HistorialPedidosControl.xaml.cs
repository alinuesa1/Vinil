using System;
using System.Collections.Generic;
using System.Windows;

namespace AppVinilos
{
    public partial class HistorialPedidosControl : Window
    {
        private List<PedidoDetalle> pedidos;

        public HistorialPedidosControl()
        {
            InitializeComponent();
            CargarPedidosDeEjemplo();
            listBoxPedidos.ItemsSource = pedidos;
        }

        private void CargarPedidosDeEjemplo()
        {
            // Crear una lista de pedidos de ejemplo
            pedidos = new List<PedidoDetalle>
            {
                new PedidoDetalle { IdPedido = 1, Fecha = new DateTime(2024, 1, 15), Total = 49.99m, Estado = "Completado", Destino = "Madrid", Unidades = 2, Opiniones = "Todo bien." },
                new PedidoDetalle { IdPedido = 2, Fecha = new DateTime(2024, 2, 10), Total = 89.50m, Estado = "En proceso", Destino = "Barcelona", Unidades = 1, Opiniones = "Rápido, por favor." },
                new PedidoDetalle { IdPedido = 3, Fecha = new DateTime(2024, 3, 5), Total = 19.99m, Estado = "Cancelado", Destino = "Valencia", Unidades = 3, Opiniones = "Cancelado, mala atención." },
                new PedidoDetalle { IdPedido = 4, Fecha = new DateTime(2024, 4, 20), Total = 120.75m, Estado = "Completado", Destino = "Sevilla", Unidades = 5, Opiniones = "Excelente servicio." },
                new PedidoDetalle { IdPedido = 5, Fecha = new DateTime(2024, 5, 25), Total = 69.30m, Estado = "En proceso", Destino = "Bilbao", Unidades = 2, Opiniones = "Perfecto." }
            };
        }

        private void ListBoxPedidos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (listBoxPedidos.SelectedItem is PedidoDetalle selectedPedido)
            {
                textBlockDetalles.Text = $"ID Pedido: {selectedPedido.IdPedido}\n" +
                                         $"Fecha: {selectedPedido.Fecha:dd/MM/yyyy}\n" +
                                         $"Total: {selectedPedido.Total:C}\n" +
                                         $"Estado: {selectedPedido.Estado}\n" +
                                         $"Destino: {selectedPedido.Destino}\n" +
                                         $"Unidades: {selectedPedido.Unidades}\n" +
                                         $"Opiniones: {selectedPedido.Opiniones}";
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

    public class PedidoDetalle
    {
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public string Destino { get; set; }
        public int Unidades { get; set; }
        public string Opiniones { get; set; }
    }
}
