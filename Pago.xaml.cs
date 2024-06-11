using System.Collections.Generic;
using System.Windows;

namespace AppVinilos
{
    public partial class Pago : Window
    {
        public Pago()
        {
            InitializeComponent();
            listBoxDiscos.ItemsSource = CarritoGlobal.Carrito;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
