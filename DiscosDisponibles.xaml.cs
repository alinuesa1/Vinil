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
    
    public partial class DiscosDisponibles : Window
    {
        List<DiscoVinilo> discos = new List<DiscoVinilo>();
        public List<DiscoVinilo> carrito = new List<DiscoVinilo>();

        // Establecer la colección como origen de datos para el ListBoxs
        public DiscosDisponibles()
        {
            InitializeComponent();
            BitmapImage Thriller = new BitmapImage(new Uri("pack://application:,,,/Imagenes/Thriller.jpg"));
            BitmapImage YHLQMDLG = new BitmapImage(new Uri("pack://application:,,,/Imagenes/YHLQMDLG.jpg"));

            discos.Add(new DiscoVinilo { Titulo = "Thriller", Autor = "Michael Jackson", Fecha = DateTime.Now, Portada = Thriller, NumeroCanciones = 10, Precio = 20 });
            discos.Add(new DiscoVinilo { Titulo = "YHLQMDLG", Autor = "Bad Bunny", Fecha = DateTime.Now, Portada = YHLQMDLG, NumeroCanciones = 12, Precio = 15 });
            discos.Add(new DiscoVinilo { Titulo = "Libre", Autor = "Nino Bravo", Fecha = DateTime.Now, Portada = YHLQMDLG, NumeroCanciones = 1, Precio = 30 });
            discos.Add(new DiscoVinilo { Titulo = "Cien gaviotas", Autor = "Duncan Dhu", Fecha = DateTime.Now, Portada = YHLQMDLG, NumeroCanciones = 22, Precio = 50 });
            listBoxDiscos.ItemsSource = discos;
        }
        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            // Obtén el elemento seleccionado del ListBox y realiza la acción correspondiente
            if (listBoxDiscos.SelectedItem is DiscoVinilo selectedDisco)
            {
                // Agregar al carrito aquí (puedes implementar tu lógica específica)
                MessageBox.Show($"Añadiendo al carrito: {selectedDisco.Titulo}");
                carrito.Add( selectedDisco );
            }
        }

        private void MoreDetails_Click(object sender, RoutedEventArgs e)
        {
            // Obtén el elemento seleccionado del ListBox y muestra más detalles
            if (listBoxDiscos.SelectedItem is DiscoVinilo selectedDisco)
            {
                MessageBox.Show("Ventana de mas detalles aun no implementada");
            }
        }

    }
}
