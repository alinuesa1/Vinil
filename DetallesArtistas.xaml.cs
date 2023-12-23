using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace AppVinilos
{
    public partial class DetallesArtistas : Window
    {
        public List<Artista> Artistas { get; set; }

        public DetallesArtistas()
        {
            InitializeComponent();

            // Inicializar la colección de artistas (puedes cargarla desde tu fuente de datos)
            Artistas = new List<Artista>
            {
                // Agregar algunos artistas de ejemplo
                new Artista
                {
                    NombreArtistico = "Artista1",
                    NombreReal = "NombreReal1",
                    NumeroComponentes = 2,
                    FechaNacimiento = new DateTime(1990, 1, 1),
                    Descripcion = "Descripción del Artista1",
                    GeneroMusical = "Pop",
                    RedesSociales = "Enlace1, Enlace2",
                    MeGustas = 1000,
                    GaleriaImagenes = new List<string> { "Imagen1.jpg", "Imagen2.jpg" },
                    Discografia = new List<DiscoVinilo>
                    {
                        new DiscoVinilo { Titulo = "Disco1", /* Otras propiedades del disco */ },
                        new DiscoVinilo { Titulo = "Disco2", /* Otras propiedades del disco */ }
                    }
                },
                // Agregar más artistas según sea necesario
            };

            listBoxArtistas.ItemsSource = Artistas;
        }
        private void BtnCrearArtista_Click(object sender, RoutedEventArgs e)
        {
            // Crear y mostrar la ventana para crear un artista
            CrearArtistas crearArtistaWindow = new CrearArtistas();
            if (crearArtistaWindow.ShowDialog() == true)
            {
                // Obtener el nuevo artista creado
                Artista nuevoArtista = crearArtistaWindow.NuevoArtista;

                // Agregar el nuevo artista a la colección
                Artistas.Add(nuevoArtista);

                MessageBox.Show("Artista creado exitosamente.", "Crear Artista", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void BtnEditarArtista_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si hay un artista seleccionado en la lista
            if (listBoxArtistas.SelectedItem != null)
            {
                // Obtener el artista seleccionado
                Artista artistaSeleccionado = (Artista)listBoxArtistas.SelectedItem;

                // Crear y mostrar la ventana para editar el artista
                EditarArtistas editarArtistaWindow = new EditarArtistas(artistaSeleccionado);
                if (editarArtistaWindow.ShowDialog() == true)
                {
                    // Obtener el artista editado
                    Artista artistaEditado = editarArtistaWindow.ArtistaEditado;

                    // Actualizar el artista en la colección
                    int indice = Artistas.IndexOf(artistaSeleccionado);
                    Artistas[indice] = artistaEditado;

                    MessageBox.Show("Cambios guardados exitosamente.", "Editar Artista", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artista para editar.", "Editar Artista", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BtnEliminarArtista_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si hay un artista seleccionado en la lista
            if (listBoxArtistas.SelectedItem != null)
            {
                // Obtener el artista seleccionado
                Artista artistaSeleccionado = (Artista)listBoxArtistas.SelectedItem;

                // Confirmar con el usuario antes de eliminar
                MessageBoxResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {artistaSeleccionado.NombreArtistico}?", "Eliminar Artista", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    // Eliminar el artista de la colección
                    Artistas.Remove(artistaSeleccionado);

                    MessageBox.Show("Artista eliminado exitosamente.", "Eliminar Artista", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artista para eliminar.", "Eliminar Artista", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana
            Close();
        }
        public class Artista
        {
            public string NombreArtistico { get; set; }
            public string NombreReal { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Descripcion { get; set; }
            public string GeneroMusical { get; set; }
            public string RedesSociales { get; set; }
            public int MeGustas { get; set; }
            public List<string> GaleriaImagenes { get; set; }
            public List<DiscoVinilo> Discografia { get; set; }
            public int NumeroComponentes { get; set; }
            /* private bool esSolista { get; set; }
             private bool tieneComponentes { get; set; }
             public int NumeroComponentes
             {
                 get { return numeroComponentes; }
                 set
                 {
                     // Asegurarse de que el número de componentes sea válido (puede ser positivo o cero)
                     if (value > 0)
                     {
                         numeroComponentes = value;
                     }
                     else
                     {
                         numeroComponentes = 0;
                     }

                     // Actualizar la propiedad TieneComponentes dependiendo del número de componentes
                     TieneComponentes = (numeroComponentes > 0);
                 }
             }
             public bool EsSolista
                 {
                     get { return esSolista; }
                     set
                     {
                         esSolista = value;

                         // Actualizar el valor de TieneComponentes dependiendo de EsSolista
                         if (value == true)
                         {
                             tieneComponentes = false; // Si es solista, no tiene componentes
                         }
                     }
                 }
             public bool TieneComponentes
                 {
                     get { return tieneComponentes; }
                     set
                     {
                         // Si se establece que tiene componentes, cambiar EsSolista a false
                         if (value == true)
                         {
                             esSolista = false;
                         }

                         tieneComponentes = value;
                     }
                 }*/
        }

    }
}

