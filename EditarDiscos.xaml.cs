using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace AppVinilos
{
    public partial class EditarDiscos : Window
    {
        public string NuevoTitulo { get; set; }
        public string NuevoAutor { get; set; }
        public DateTime NuevaFecha { get; set; }
        public int NuevoPrecio { get; set; }
        public double NuevaCalificacion { get; set; }
        public int NuevasUnidadesDisponibles { get; set; }
        public List<string> NuevasCanciones { get; set; }
        public BitmapImage NuevaPortada { get; set; }
        public string NuevaPreview { get; set; }

        private DiscoVinilo discoOriginal;

        public EditarDiscos(DiscoVinilo disco)
        {
            InitializeComponent();
            discoOriginal = disco;

            // Inicializar los campos con los valores actuales del disco
            txtNuevoTitulo.Text = disco.Titulo;
            txtNuevoAutor.Text = disco.Autor;
            nuevaFecha.SelectedDate = disco.Fecha;
            nuevoPrecio.Text = disco.Precio.ToString();
            txtCalificacion.Text = disco.Calificacion.ToString();
            txtUnidadesDisponibles.Text = disco.UnidadesDisponibles.ToString();
            txtCanciones.Text = string.Join(Environment.NewLine, disco.Canciones);
            nuevaPortada.Source = disco.Portada;
            txtPreviewFile.Text = disco.Preview;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NuevoTitulo = txtNuevoTitulo.Text;
                NuevoAutor = txtNuevoAutor.Text;
                NuevaFecha = nuevaFecha.SelectedDate ?? DateTime.Now;
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

                NuevaCalificacion = calificacion;
                NuevoPrecio = precio;
                NuevasUnidadesDisponibles = unidadesDisponibles;
                NuevasCanciones = canciones;
                NuevaPortada = (BitmapImage)nuevaPortada.Source;
                NuevaPreview = txtPreviewFile.Text;

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
