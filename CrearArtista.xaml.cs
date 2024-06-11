using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace AppVinilos
{
    public partial class CrearArtista : Window
    {
        public Artista NuevoArtista { get; set; } = new Artista();

        public CrearArtista()
        {
            InitializeComponent();
            lbEnlacesRedesSociales.ItemsSource = NuevoArtista.EnlacesRedesSociales;
            lbGaleriaImagenes.ItemsSource = NuevoArtista.GaleriaImagenes;
            lbDiscografia.ItemsSource = NuevoArtista.Discografia;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            NuevoArtista.NombreArtistico = txtNombreArtistico.Text;
            NuevoArtista.NombreReal = txtNombreReal.Text;
            NuevoArtista.Componentes = txtComponentes.Text;
            NuevoArtista.FechaNacimientoOCreacion = dpFechaNacimientoOCreacion.SelectedDate ?? DateTime.Now;
            NuevoArtista.Descripcion = txtDescripcion.Text;
            NuevoArtista.GeneroMusical = txtGeneroMusical.Text;
            NuevoArtista.NumeroFavoritos = int.Parse(txtNumeroFavoritos.Text);

            DialogResult = true;
            Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void BtnAgregarEnlace_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNuevoEnlace.Text))
            {
                NuevoArtista.EnlacesRedesSociales.Add(txtNuevoEnlace.Text);
                lbEnlacesRedesSociales.Items.Refresh();
                txtNuevoEnlace.Clear();
            }
        }

        private void BtnAgregarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg)|*.png;*.jpg"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(openFileDialog.FileName));
                NuevoArtista.GaleriaImagenes.Add(image);
                lbGaleriaImagenes.Items.Refresh();
            }
        }

        private void BtnAgregarDisco_Click(object sender, RoutedEventArgs e)
        {
            CrearDiscos crearDiscoWindow = new CrearDiscos();
            if (crearDiscoWindow.ShowDialog() == true)
            {
                NuevoArtista.Discografia.Add(crearDiscoWindow.NuevoDisco);
                lbDiscografia.Items.Refresh();
            }
        }
    }
}
