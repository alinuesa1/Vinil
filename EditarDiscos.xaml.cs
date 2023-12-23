// EditarDiscoWindow.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public partial class EditarDiscos : Window
    {
        public string NuevoTitulo { get; private set; }
        public string NuevoAutor { get; private set; }
        public DateTime NuevaFecha { get; private set; }
        public BitmapImage NuevaPortada { get; private set; }
        public int NuevoNumCanciones { get; private set; }
        public int NuevoPrecio { get; private set; }

        public EditarDiscos(DiscoVinilo disco)
        {
            InitializeComponent();
            // Inicializa los campos de edición con los valores actuales del disco
            txtNuevoTitulo.Text = disco.Titulo;
            txtNuevoAutor.Text = disco.Autor;
            nuevaFecha.DataContext = disco.Fecha;
            txtnuevoNumCanciones.Text = disco.NumeroCanciones.ToString();
            nuevoPrecio.Text = disco.Precio.ToString();
            nuevaPortada.DataContext = disco.Portada;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validar que se hayan ingresado todos los campos obligatorios
                if (string.IsNullOrEmpty(txtNuevoTitulo.Text) || string.IsNullOrEmpty(txtNuevoAutor.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Editar Disco", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Asignar los nuevos valores a las propiedades
                NuevoTitulo = txtNuevoTitulo.Text;
                NuevoAutor = txtNuevoAutor.Text;
                NuevaFecha = (DateTime)nuevaFecha.DataContext;
                NuevoNumCanciones = int.Parse(txtnuevoNumCanciones.Text);
                NuevoPrecio = int.Parse(nuevoPrecio.Text);
                NuevaPortada = (BitmapImage)nuevaPortada.DataContext;

                // Cerrar la ventana
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Editar Disco", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana sin guardar los cambios
            DialogResult = false;
            Close();
        }
    }
}

