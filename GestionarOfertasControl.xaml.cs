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
    public partial class GestionarOfertasControl : Window
    {
        public class Oferta
        {
            public string Producto { get; set; }
            public decimal Descuento { get; set; }
            // Puedes agregar más propiedades según tus necesidades
        }

        public class ViewModel
        {
            public List<Oferta> ListaOfertas { get; set; }

            public ViewModel()
            {
                // Puedes inicializar la lista de ofertas aquí (por ejemplo, obtenerla de una base de datos)
                ListaOfertas = new List<Oferta>
                {
                    new Oferta { Producto = "Producto 1", Descuento = 0.1M },
                    new Oferta { Producto = "Producto 2", Descuento = 0.05M },
                    // Agrega más ofertas según tus necesidades
                };
            }
        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            // Implementa la lógica para volver atrás según tus necesidades
            // Por ejemplo: this.Close();
        }

        public GestionarOfertasControl()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}

