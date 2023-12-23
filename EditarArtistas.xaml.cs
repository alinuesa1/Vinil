// EditarArtistaWindow.xaml.cs
using System;
using System.Windows;
using static AppVinilos.DetallesArtistas;

namespace AppVinilos
{
    public partial class EditarArtistas : Window
    {
        public Artista ArtistaEditado { get; private set; }

        public EditarArtistas(Artista artista)
        {
            InitializeComponent();

            // Inicializar los campos de la ventana con la información del artista existente
            txtNombreArtistico.Text = artista.NombreArtistico;
            txtNombreReal.Text = artista.NombreReal;
            // Inicializar más campos según sea necesario
        }

        private void BtnGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validar que se hayan ingresado todos los campos obligatorios
                if (string.IsNullOrEmpty(txtNombreArtistico.Text) || string.IsNullOrEmpty(txtNombreReal.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Editar Artista", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Crear un nuevo objeto Artista con la información editada
                ArtistaEditado = new Artista
                {
                    NombreArtistico = txtNombreArtistico.Text,
                    NombreReal = txtNombreReal.Text,
                    // Asignar más propiedades según sea necesario
                };

                // Cerrar la ventana después de editar el artista
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Editar Artista", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
