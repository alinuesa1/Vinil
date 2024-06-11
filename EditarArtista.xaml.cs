using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace AppVinilos
{
    public partial class EditarArtista : Window
    {
        public Artista ArtistaEditado { get; set; }

        public EditarArtista(Artista artista)
        {
            InitializeComponent();
            ArtistaEditado = artista;
            txtNombreArtistico.Text = artista.NombreArtistico;
            txtNombreReal.Text = artista.NombreReal;
            txtComponentes.Text = artista.Componentes;
            dpFechaNacimientoOCreacion.SelectedDate = artista.FechaNacimientoOCreacion;
            txtDescripcion.Text = artista.Descripcion;
            txtGeneroMusical.Text = artista.GeneroMusical;
            txtNumeroFavoritos.Text = artista.NumeroFavoritos.ToString();
            lbEnlacesRedesSociales.ItemsSource = artista.EnlacesRedesSociales;
            lbGaleriaImagenes.ItemsSource = artista.GaleriaImagenes;
            lbDiscografia.ItemsSource = artista.Discografia;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            ArtistaEditado.NombreArtistico = txtNombreArtistico.Text;
            ArtistaEditado.NombreReal = txtNombreReal.Text;
            ArtistaEditado.Componentes = txtComponentes.Text;
            ArtistaEditado.FechaNacimientoOCreacion = dpFechaNacimientoOCreacion.SelectedDate ?? DateTime.Now;
            ArtistaEditado.Descripcion = txtDescripcion.Text;
            ArtistaEditado.GeneroMusical = txtGeneroMusical.Text;
            ArtistaEditado.NumeroFavoritos = int.Parse(txtNumeroFavoritos.Text);

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
                ArtistaEditado.EnlacesRedesSociales.Add(txtNuevoEnlace.Text);
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
                ArtistaEditado.GaleriaImagenes.Add(image);
                lbGaleriaImagenes.Items.Refresh();
            }
        }

        private void BtnAgregarDisco_Click(object sender, RoutedEventArgs e)
        {
            CrearDiscos crearDiscoWindow = new CrearDiscos();
            if (crearDiscoWindow.ShowDialog() == true)
            {
                ArtistaEditado.Discografia.Add(crearDiscoWindow.NuevoDisco);
                lbDiscografia.Items.Refresh();
            }
        }
    }
}
