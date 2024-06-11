using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

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
                string titulo = txtNuevoTitulo.Text;
                string autor = txtNuevoAutor.Text;
                DateTime? fecha = nuevaFecha.SelectedDate;
                if (!int.TryParse(nuevoPrecio.Text, out int precio))
                {
                    MessageBox.Show("El precio no es válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (!double.TryParse(txtCalificacion.Text, out double calificacion))
                {
                    MessageBox.Show("La calificación no es válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (!int.TryParse(txtUnidadesDisponibles.Text, out int unidadesDisponibles))
                {
                    MessageBox.Show("El número de unidades disponibles no es válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                List<string> canciones = new List<string>(txtCanciones.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None));
                BitmapImage portada = (BitmapImage)nuevaPortada.Source;
                string preview = txtPreviewFile.Text;

                NuevoDisco = new DiscoVinilo
                {
                    Titulo = titulo,
                    Autor = autor,
                    Fecha = fecha ?? DateTime.Now,
                    Precio = precio,
                    Calificacion = calificacion,
                    UnidadesDisponibles = unidadesDisponibles,
                    Canciones = canciones,
                    Portada = portada,
                    Preview = preview
                };

                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el disco: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSeleccionarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.png)|*.jpg;*.png"
            };
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(filename, UriKind.Absolute);
                bitmap.EndInit();
                nuevaPortada.Source = bitmap;
            }
        }

        private void BtnSeleccionarPreview_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Audio files (*.mp3)|*.mp3",
                InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music")
            };
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                txtPreviewFile.Text = dlg.FileName;
            }
        }
        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
