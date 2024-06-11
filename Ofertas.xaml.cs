using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public partial class Ofertas : Window
    {
        public ObservableCollection<Oferta> ListaDeOfertas { get; set; }

        public Ofertas()
        {
            InitializeComponent();
            CargarOfertas();
            listBoxOfertas.ItemsSource = ListaDeOfertas;
        }

        private void CargarOfertas()
        {
            // Aquí puedes cargar las ofertas desde una base de datos, servicio web, etc.
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
            }};
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
            // Cerrar sesión y redirigir a la LoginWindow
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
}
