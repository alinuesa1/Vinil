// CarritoCompraWindow.xaml.cs
using AppVinilos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public partial class CarritoCompra : Window
    {
        // Colección para almacenar los discos en el carrito
        public List<DiscoVinilo> carrito = new List<DiscoVinilo>();

        public CarritoCompra()
        {
            InitializeComponent();
            listBoxCarrito.ItemsSource = CarritoGlobal.Carrito;
            UpdateTotalPrice();
            foreach (var disco in CarritoGlobal.Carrito)
            {
                disco.PropertyChanged += Disco_PropertyChanged;
            }
        }
        private void RemoveFromCart_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.Tag is DiscoVinilo disco)
            {
                CarritoGlobal.Carrito.Remove(disco);
                listBoxCarrito.ItemsSource = null;
                listBoxCarrito.ItemsSource = CarritoGlobal.Carrito;
                UpdateTotalPrice();

                disco.PropertyChanged -= Disco_PropertyChanged;
            }
        }
        private void UpdateTotalPrice()
        {
            int totalPrecio = CarritoGlobal.Carrito.Sum(disco => disco.Precio * disco.Cantidad);
            totalPrecioTextBlock.Text = $"Total: ${totalPrecio}";
        }
        private void Disco_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(DiscoVinilo.Cantidad))
            {
                UpdateTotalPrice();
            }
        }
        private void IrAlPago_Click(object sender, RoutedEventArgs e)
        {
            Pago pago = new Pago();
            pago.Show();
        }
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            UserMainWindow userMainWindow = new UserMainWindow();
            WindowManager.UserMainWindowInstance = userMainWindow;
            WindowManager.UserMainWindowInstance.Show();
            this.Hide();
        }
        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            WindowManager.HelpInstance = help;
            WindowManager.HelpInstance.Show();
            this.Hide();
        }
        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar sesión y redirigir a la MainWindow
            MessageBox.Show("Cerrando sesión...");
            LoginWindow loginWindow = new LoginWindow();
            WindowManager.LoginWindowInstance = loginWindow;
            WindowManager.LoginWindowInstance.Show();
            this.Hide();
        }
        private void BtnCarrito_Click(object sender, RoutedEventArgs e)
        {
            CarritoCompra carritoCompra = new CarritoCompra();
            WindowManager.CarritoCompraInstance = carritoCompra;
            WindowManager.CarritoCompraInstance.Show();
            this.Hide();
        }
    }
    public static class CarritoGlobal
    {
        public static List<DiscoVinilo> Carrito { get; } = new List<DiscoVinilo>()
        {
            new DiscoVinilo
            {
                Titulo = "Thriller",
                Autor = "Michael Jackson",
                SelloDiscografico = "Epic",
                Formato = "Vinilo",
                Pais = "EE.UU.",
                Fecha = new DateTime(1982, 11, 30),
                Genero = "Pop",
                MeGustas = 1000000,
                Calificacion = 4.9,
                Precio = 24,
                UnidadesDisponibles = 50,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/thriller.jpg")),
                Canciones = new List<string> { "Wanna Be Startin' Somethin'", "Baby Be Mine", "The Girl Is Mine", "Thriller", "Beat It", "Billie Jean", "Human Nature", "P.Y.T. (Pretty Young Thing)", "The Lady in My Life" },
                Preview = "Music/thriller.mp3",
                Cantidad = 1
            },
                        new DiscoVinilo
            {
                Titulo = "Abbey Road",
                Autor = "The Beatles",
                SelloDiscografico = "Apple",
                Formato = "Vinilo",
                Pais = "Reino Unido",
                Fecha = new DateTime(1969, 9, 26),
                Genero = "Rock",
                MeGustas = 950000,
                Calificacion = 5.0,
                Precio = 30,
                UnidadesDisponibles = 40,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/abbey_road.jpg")),
                Canciones = new List<string> { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden", "I Want You (She's So Heavy)", "Here Comes the Sun", "Because", "You Never Give Me Your Money", "Sun King", "Mean Mr. Mustard", "Polythene Pam", "She Came in Through the Bathroom Window", "Golden Slumbers", "Carry That Weight", "The End", "Her Majesty" },
                Preview = "Music/HereComesTheSun.mp3",
                Cantidad = 1
            },
            new DiscoVinilo
            {
                Titulo = "Back in Black",
                Autor = "AC/DC",
                SelloDiscografico = "Atlantic",
                Formato = "Vinilo",
                Pais = "Australia",
                Fecha = new DateTime(1980, 7, 25),
                Genero = "Hard Rock",
                MeGustas = 800000,
                Calificacion = 4.8,
                Precio = 22,
                UnidadesDisponibles = 35,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/back_in_black.jpg")),
                Canciones = new List<string> { "Hells Bells", "Shoot to Thrill", "What Do You Do for Money Honey", "Given the Dog a Bone", "Let Me Put My Love into You", "Back in Black", "You Shook Me All Night Long", "Have a Drink on Me", "Shake a Leg", "Rock and Roll Ain't Noise Pollution" },
                Preview = "Music/back_in_black.mp3",
                Cantidad = 1
            },
                        new DiscoVinilo
            {
                Titulo = "Hotel California",
                Autor = "Eagles",
                SelloDiscografico = "Asylum",
                Formato = "Vinilo",
                Pais = "EE.UU.",
                Fecha = new DateTime(1976, 12, 8),
                Genero = "Rock",
                MeGustas = 850000,
                Calificacion = 4.8,
                Precio = 25,
                UnidadesDisponibles = 50,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/hotel_california.jpg")),
                Canciones = new List<string> { "Hotel California", "New Kid in Town", "Life in the Fast Lane", "Wasted Time", "Wasted Time (Reprise)", "Victim of Love", "Pretty Maids All in a Row", "Try and Love Again", "The Last Resort" },
                Preview = "pack://application:,,,/Music/hotel_california.mp3",
                Cantidad = 1
            },
        };

        public static void AddToCarrito(DiscoVinilo disco)
        {
            Carrito.Add(disco);
        }
    }
}
