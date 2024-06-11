using System.Windows;

namespace AppVinilos
{
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();
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

        private void BtnEnviarPregunta_Click(object sender, RoutedEventArgs e)
        {
            string pregunta = txtPregunta.Text;

            if (string.IsNullOrWhiteSpace(pregunta))
            {
                MessageBox.Show("Por favor, escribe una pregunta antes de enviar.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Lógica para enviar la pregunta a soporte (puede ser una llamada a un servicio web, guardarla en una base de datos, etc.)
            MessageBox.Show("Tu pregunta ha sido enviada con éxito. Nos pondremos en contacto contigo pronto.", "Pregunta Enviada", MessageBoxButton.OK, MessageBoxImage.Information);

            // Limpiar el TextBox después de enviar la pregunta
            txtPregunta.Clear();
        }
    }
}
