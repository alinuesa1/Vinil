using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
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
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Lógica de autenticación
            bool esAutenticado = Autenticacion.ValidarCredenciales(username, password);

            if (esAutenticado)
            {
                // Autenticación exitosa
                MessageBox.Show("Inicio de sesión exitoso");

                // Verificar si el usuario es administrador
                bool esAdmin = Autenticacion.EsAdmin(username);

                // Abrir la ventana correspondiente
                if (esAdmin)
                {
                    AdminMainWindow adminMainWindow = new AdminMainWindow();
                    adminMainWindow.Show();
                }
                else
                {
                    UserMainWindow userMainWindow = new UserMainWindow();
                    userMainWindow.Show();
                }

                // Cerrar la ventana de inicio de sesión
                this.Close();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
            }
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

        private void LimpiarCampos()
        {
            // Limpiar campos de usuario y contraseña
            txtUsername.Text = "";
            txtPassword.Password = "";
        }

        private bool IsAdmin()
        {
            // Obtener el RadioButton llamado "Administrador" de manera segura
            RadioButton administradorRadioButton = this.FindName("Administrador") as RadioButton;

            // Verificar si se encontró el RadioButton y si está marcado
            if (administradorRadioButton != null && administradorRadioButton.IsChecked.HasValue)
            {
                return administradorRadioButton.IsChecked.Value;
            }

            // Si no se encuentra o no está configurado correctamente, asumir que no es un administrador
            return false;
        }


        private void BtnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de registro
            RegistroWindow registroWindow = new RegistroWindow();
            registroWindow.ShowDialog();
        }

        // Eventos para manejar el Watermark en TextBox y PasswordBox
        private void ClearText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Tag?.ToString())
            {
                textBox.Text = "";
            }
        }

        private void RestoreText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString();
            }
        }

        private void ClearPassword(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            passwordBox.Password = "";
        }

        private void RestorePassword(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (string.IsNullOrEmpty(passwordBox.Password))
            {
                passwordBox.Password = "Contraseña";
            }
        }
    }
}



