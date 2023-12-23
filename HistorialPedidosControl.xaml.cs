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

namespace AppVinilos
{
    public partial class HistorialPedidosControl : Window
    {
        public class Pedido
        {
            public DateTime Fecha { get; set; }
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            // Puedes agregar más propiedades según tus necesidades
        }

        public class ViewModel
        {
            public List<Pedido> ListaPedidos { get; set; }

            public ViewModel()
            {
                // Puedes inicializar la lista de pedidos aquí (por ejemplo, obtenerla de una base de datos)
                ListaPedidos = new List<Pedido>
                {
                    new Pedido { Fecha = DateTime.Now, Producto = "Producto 1", Cantidad = 2 },
                    new Pedido { Fecha = DateTime.Now.AddDays(-3), Producto = "Producto 2", Cantidad = 1 },
                    // Agrega más pedidos según tus necesidades
                };
            }
        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            // Implementa la lógica para volver atrás según tus necesidades
            // Por ejemplo: this.Close();
        }

        public HistorialPedidosControl()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
