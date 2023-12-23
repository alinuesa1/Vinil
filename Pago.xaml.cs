using System.Windows;

namespace AppVinilos
{
    public partial class Pago : Window
    {
        public Pago()
        {
            InitializeComponent();

            // Ejemplo de cómo llenar la lista de resumen del pedido (puedes adaptar esto según tu lógica)
            listBoxResumen.ItemsSource = new[]
            {
                new DiscoVinilo {Titulo = "Thriller", Autor = "Michael Jackson", Precio = 24},
                new DiscoVinilo {Titulo = "YHLQMDLG", Autor = "Bad Bunny", Precio = 10},
                // Agrega más discos según tu lógica
            };
        }
    }
}
