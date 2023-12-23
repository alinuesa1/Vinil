using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace AppVinilos
{
    public partial class DetallesDiscos : Window

    {
        List<DiscoVinilo> discos = new List<DiscoVinilo>();


        // Establecer la colección como origen de datos para el ListBoxs
        public DetallesDiscos()
        {
            InitializeComponent();
            BitmapImage Thriller = new BitmapImage(new Uri("/Imagenes/Thriller"));
            BitmapImage YHLQMDLG = new BitmapImage(new Uri("/Imagenes/YHLQMDLG"));

            discos.Add(new DiscoVinilo { Titulo = "Thriller", Autor = "Michael Jackson", Fecha = DateTime.Now, Portada = Thriller, NumeroCanciones = 10, Precio = 20 });
            discos.Add(new DiscoVinilo { Titulo = "YHLQMDLG", Autor = "Bad Bunny", Fecha = DateTime.Now, Portada = YHLQMDLG, NumeroCanciones = 12, Precio = 15 });
            discos.Add(new DiscoVinilo { Titulo = "Libre", Autor = "Nino Bravo", Fecha = DateTime.Now, Portada = YHLQMDLG, NumeroCanciones = 1, Precio = 30 });
            discos.Add(new DiscoVinilo { Titulo = "Cien gaviotas", Autor = "Duncan Dhu", Fecha = DateTime.Now, Portada = YHLQMDLG, NumeroCanciones = 22, Precio = 50 });

            listBoxDiscos.ItemsSource = discos;
        }

        private void BtnCrearDisco_Click(object sender, RoutedEventArgs e)
        {
            CrearDiscos crearDiscoWindow = new CrearDiscos();
            if (crearDiscoWindow.ShowDialog() == true)
            {
                // Si el usuario hizo clic en "Guardar" en la ventana de creación
                discos.Add(crearDiscoWindow.NuevoDisco);

                // Actualizar la vista del ListBox
                listBoxDiscos.Items.Refresh();
            }
        }

        private void BtnEditarDisco_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si hay un disco seleccionado en la lista
            if (listBoxDiscos.SelectedItem != null)
            {
                // Obtener el disco seleccionado
                DiscoVinilo discoSeleccionado = (DiscoVinilo)listBoxDiscos.SelectedItem;

                // Mostrar una ventana de edición de discos (puedes crear esta ventana)
                EditarDiscos editarDiscoWindow = new EditarDiscos(discoSeleccionado);
                if (editarDiscoWindow.ShowDialog() == true)
                {
                    // Si el usuario hizo clic en "Guardar" en la ventana de edición
                    // Actualizar la información del disco en la colección y en la lista
                    discoSeleccionado.Titulo = editarDiscoWindow.NuevoTitulo;
                    discoSeleccionado.Autor = editarDiscoWindow.NuevoAutor;
                    discoSeleccionado.Fecha = editarDiscoWindow.NuevaFecha;
                    discoSeleccionado.Portada = editarDiscoWindow.NuevaPortada;
                    discoSeleccionado.NumeroCanciones = editarDiscoWindow.NuevoNumCanciones;

                    // Actualizar la visualización en el ListBox
                    listBoxDiscos.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un disco para editar.", "Editar Disco", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnBorrarDisco_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si hay un disco seleccionado en la lista
            if (listBoxDiscos.SelectedItem != null)
            {
                // Obtener el disco seleccionado
                DiscoVinilo discoSeleccionado = (DiscoVinilo)listBoxDiscos.SelectedItem;

                // Mostrar un mensaje de confirmación antes de borrar
                MessageBoxResult result = MessageBox.Show($"¿Estás seguro de borrar el disco '{discoSeleccionado.Titulo}'?", "Borrar Disco", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    // Borrar el disco de la colección y de la lista
                    discos.Remove(discoSeleccionado);
                    listBoxDiscos.Items.Remove(discoSeleccionado);
                }
                else
                {
                    // Si el usuario cancela, deseleccionar el disco en la lista
                    listBoxDiscos.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un disco para borrar.", "Borrar Disco", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }

    public class DiscoVinilo
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public BitmapImage Portada { get; set; }
        public int NumeroCanciones { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public DiscoVinilo()
        {
        }
        
        // Constructor para utilizar un objeto de imagen
        public DiscoVinilo(string titulo, string autor, DateTime fecha, BitmapImage portada, int numeroCanciones, int precio)
        {
            Titulo = titulo;
            Autor = autor;
            Fecha = fecha;
            Portada = portada;
            NumeroCanciones = numeroCanciones;
            Precio = precio;
        }
        // Constructor para la colección de discos en el carrito de compra
        public DiscoVinilo(string titulo, string autor, int precio, int cantidad)
        {
            Titulo = titulo;
            Autor = autor;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}

