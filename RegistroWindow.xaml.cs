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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace AppVinilos
{
    public partial class RegistroWindow : Window
    {
        public RegistroWindow()
        {
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            string nuevoUsuario = txtNuevoUsuario.Text;
            string nuevaContraseña = txtNuevaContraseña.Password;

            // Lógica de registro
            if (Registro.NuevoUsuarioValido(nuevoUsuario, nuevaContraseña))
            {
                // Registro exitoso
                lblRegistroMensaje.Text = "Registro exitoso. Ahora puedes iniciar sesión.";

                // No cierres la ventana de registro, permitiendo al usuario realizar más acciones si es necesario
            }
            else
            {
                // Mostrar mensaje de error
                lblRegistroMensaje.Text = "Error al registrar. Inténtalo de nuevo.";
            }
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
            if (string.IsNullOrWhiteSpace(textBox.Text))
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
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = "Contraseña";
            }
        }
    }
}

