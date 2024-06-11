using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppVinilos
{
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }
        private void DetalleDiscos_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de gestionar discos
            DetallesDiscos detallesDiscos = new DetallesDiscos();
            WindowManager.DetallesDiscosInstance = detallesDiscos;
            WindowManager.DetallesDiscosInstance.Show();
            this.Hide();
        }

        private void GestionarArtistas_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de gestionar artistas
            DetallesArtistas gestionarArtistasWindow = new DetallesArtistas();
            WindowManager.DetallesArtistasInstance = gestionarArtistasWindow;
            WindowManager.DetallesArtistasInstance.Show();
            this.Hide();
        }

        private void GestionarOfertas_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de gestionar ofertas
            GestionarOfertas gestionarOfertasWindow = new GestionarOfertas();
            WindowManager.GestionarOfertasControlInstance = gestionarOfertasWindow;
            WindowManager.GestionarOfertasControlInstance.Show();
            this.Hide();
        }

        private void HistorialPedidos_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de historial de pedidos
            HistorialPedidosControl historialPedidosWindow = new HistorialPedidosControl();
            WindowManager.HistorialPedidosControlInstance = historialPedidosWindow;
            WindowManager.HistorialPedidosControlInstance.Show();
            this.Hide();
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
        private void combobox_language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)combobox_language.SelectedItem; string selectedText = cbi.Content.ToString();
            if ((selectedText.Equals("ES") || selectedText.Equals("SP")) && !CultureInfo.CurrentCulture.Name.Equals("es-ES"))
            {
                Resources.MergedDictionaries.Add(App.SelectCulture("es-ES"));
            }
            else if (selectedText.Equals("EN")
            && !CultureInfo.CurrentCulture.Name.Equals("en-US"))
            {
                Resources.MergedDictionaries.Add(App.SelectCulture("en-US"));
            }
        }
    }
}
