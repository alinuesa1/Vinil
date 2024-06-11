using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public partial class GestionarOfertas : Window
    {
        public ObservableCollection<Oferta> ListaDeOfertas { get; set; }

        public GestionarOfertas()
        {
            InitializeComponent();
            ListaDeOfertas = new ObservableCollection<Oferta>
        {
            new Oferta
            {
                Titulo = "Black Friday",
                Descripcion = "Descuentos increíbles en todos los vinilos!",
                Descuento = "50%",
                Imagen = new BitmapImage(new Uri("pack://application:,,,/Imagenes/BlackFriday.png")),
                FechaEnvio = DateTime.Now.AddDays(1), // Fecha de ejemplo
                Destinatarios = "Todos los clientes",
            },
            new Oferta
            {
                Titulo = "Oferta Verano",
                Descripcion = "Disfruta del verano con estos descuentos!",
                Descuento = "30%",
                Imagen = new BitmapImage(new Uri("pack://application:,,,/Imagenes/OfertaVerano.png")),
                FechaEnvio = DateTime.Now.AddDays(1), // Fecha de ejemplo
                Destinatarios = "Todos los clientes",
            }
        };

            listBoxGestionOfertas.ItemsSource = ListaDeOfertas;
        }

        private void AgregarNuevaOferta_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar el diálogo para agregar una nueva oferta
            NuevaOfertaDialog dialog = new NuevaOfertaDialog();
            if (dialog.ShowDialog() == true)
            {
                ListaDeOfertas.Add(dialog.NuevaOferta); // Asegúrate de que esta línea esté presente
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
        private void EliminarOferta_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para eliminar una oferta
            Oferta ofertaSeleccionada = (sender as FrameworkElement).DataContext as Oferta;
            if (ofertaSeleccionada != null)
            {
                ListaDeOfertas.Remove(ofertaSeleccionada);
            }
        }
    }

    public class Oferta
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Descuento { get; set; }
        public BitmapImage Imagen { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string HoraEnvio { get; set; }
        public string Destinatarios { get; set; }
    }

}
