// CrearArtistaWindow.xaml.cs
using AppVinilos;
using System;
using System.Collections.Generic;
using System.Windows;
using static AppVinilos.DetallesArtistas;

namespace AppVinilos
{
    public partial class CrearArtistas : Window
    {
        public Artista NuevoArtista { get; private set; }

        public CrearArtistas()
        {
            InitializeComponent();
        }

        private void BtnCrearArtista_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validar que se hayan ingresado todos los campos obligatorios
                if (string.IsNullOrEmpty(txtNombreArtistico.Text) || string.IsNullOrEmpty(txtNombreReal.Text) || !dpFechaNacimiento.SelectedDate.HasValue)
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Crear Artista", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Crear un nuevo objeto Artista con la información ingresada
                NuevoArtista = new Artista
                {
                    NombreArtistico = txtNombreArtistico.Text,
                    NombreReal = txtNombreReal.Text,
                    FechaNacimiento = dpFechaNacimiento.SelectedDate.Value,
                    Descripcion = txtDescripcion.Text,
                    GeneroMusical = txtGeneroMusical.Text,
                    RedesSociales = txtRedesSociales.Text,
                    NumeroComponentes = int.Parse(txtNumeroComponentes.Text), // Asume que el usuario ingresará un número válido
                    MeGustas = 0, // Por ejemplo, inicializamos MeGustas en 0
                    GaleriaImagenes = new List<string>(),
                    Discografia = new List<DiscoVinilo>()
                };

                // Cerrar la ventana después de crear el artista
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el artista: {ex.Message}", "Crear Artista", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
