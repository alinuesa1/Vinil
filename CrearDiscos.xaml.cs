// CrearDiscoWindow.xaml.cs
using AppVinilos;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public partial class CrearDiscos : Window
    {
        public DiscoVinilo NuevoDisco { get; private set; }

        public CrearDiscos()
        {
            InitializeComponent();

        }
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validar que se hayan ingresado todos los campos obligatorios
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtAutor.Text) || datePickerFecha.SelectedDate == null || string.IsNullOrEmpty(numCanciones.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Crear Disco", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Crear un nuevo objeto DiscoVinilo con los datos ingresados
                NuevoDisco = new DiscoVinilo
                {
                    Titulo = txtNombre.Text,
                    Autor = txtAutor.Text,
                    Fecha = datePickerFecha.SelectedDate.Value,
                    //Portada = BitmapImage portada,
                    NumeroCanciones = int.Parse(numCanciones.Text),
                    Precio = int.Parse(precio.Text),
                };

                // Cerrar la ventana
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el disco: {ex.Message}", "Crear Disco", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana sin crear el disco
            DialogResult = false;
            Close();
        }
    }
}
