// CarritoCompraWindow.xaml.cs
using AppVinilos;
using System.Collections.ObjectModel;
using System.Windows;

namespace AppVinilos
{
    public partial class CarritoCompra : Window
    {
        // Colección para almacenar los discos en el carrito
        public ObservableCollection<DiscoVinilo> ListaDiscos { get; set; }

        public CarritoCompra()
        {
            InitializeComponent();

            ListaDiscos = new ObservableCollection<DiscoVinilo>
            {
                 new DiscoVinilo {Titulo = "Thriller", Autor = "Michael Jackson", Cantidad = 1 ,Precio = 24},
                 new DiscoVinilo {Titulo = "YHLQMDLG", Autor = "Bad Bunny", Cantidad = 3 ,Precio = 10},
                 new DiscoVinilo {Titulo = "Thriller", Autor = "Michael Jackson", Cantidad = 1 ,Precio = 24},
                 new DiscoVinilo {Titulo = "Thriller", Autor = "Michael Jackson", Cantidad = 1 ,Precio = 24},

            };
            DataContext = this;
            // Establecer la colección como origen de datos para el ListView
            listViewCarrito.ItemsSource = ListaDiscos;
        }
        private void IrAlPago_Click(object sender, RoutedEventArgs e)
        {
            Pago pago = new Pago();
            pago.Show();
        }

        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para obtener ayuda
            MessageBox.Show("Mostrando ayuda...");
        }
    }
}
