using AppVinilos;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public static class DiscosData
    {
        public static List<DiscoVinilo> Discos { get; } = new List<DiscoVinilo>
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
                EnFavoritos = true,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/thriller.jpg")),
                Canciones = new List<string> { "Wanna Be Startin' Somethin'", "Baby Be Mine", "The Girl Is Mine", "Thriller", "Beat It", "Billie Jean", "Human Nature", "P.Y.T. (Pretty Young Thing)", "The Lady in My Life" },
                Preview = "Music/thriller.mp3",
                Cantidad = 1
            },
            new DiscoVinilo
            {
                Titulo = "YHLQMDLG",
                Autor = "Bad Bunny",
                SelloDiscografico = "Rimas",
                Formato = "Vinilo",
                Pais = "Puerto Rico",
                Fecha = new DateTime(2020, 2, 29),
                Genero = "Reggaeton",
                MeGustas = 750000,
                Calificacion = 4.7,
                Precio = 10,
                UnidadesDisponibles = 30,
                EnFavoritos = true,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/yhlqmdlg.jpg")),
                Canciones = new List<string> { "Si Veo a Tu Mamá", "La Difícil", "Pero Ya No", "La Santa", "Yo Perreo Sola", "Bichiyal", "Soliá", "La Zona", "Que Malo", "Vete" },
                Preview = "Music/yhlqmdlg.mp3",
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
                Titulo = "The Dark Side of the Moon",
                Autor = "Pink Floyd",
                SelloDiscografico = "Harvest",
                Formato = "Vinilo",
                Pais = "Reino Unido",
                Fecha = new DateTime(1973, 3, 1),
                Genero = "Rock Progresivo",
                MeGustas = 900000,
                Calificacion = 4.9,
                Precio = 28,
                UnidadesDisponibles = 45,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/dark_side_of_the_moon.jpg")),
                Canciones = new List<string> { "Speak to Me", "Breathe", "On the Run", "Time", "The Great Gig in the Sky", "Money", "Us and Them", "Any Colour You Like", "Brain Damage", "Eclipse" },
                Preview = "Music/dark_side_of_the_moon.mp3",
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
            new DiscoVinilo
            {
                Titulo = "Bohemian Rhapsody",
                Autor = "Queen",
                SelloDiscografico = "EMI",
                Formato = "Vinilo",
                Pais = "Reino Unido",
                Fecha = new DateTime(1975, 10, 31),
                Genero = "Rock",
                MeGustas = 950000,
                Calificacion = 4.9,
                Precio = 29,
                UnidadesDisponibles = 30,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/Queen.jpg")),
                Canciones = new List<string> { "Bohemian Rhapsody", "Somebody to Love", "Killer Queen", "Don't Stop Me Now", "We Will Rock You", "We Are the Champions" },
                Preview = "pack://application:,,,/Music/bohemian_rhapsody.mp3",
                Cantidad = 1
            },
            new DiscoVinilo
            {
                Titulo = "Rammstein",
                Autor = "Rammstein",
                SelloDiscografico = "Motor Music",
                Formato = "Vinilo",
                Pais = "Alemania",
                Fecha = new DateTime(1995, 9, 25),
                Genero = "Industrial Metal",
                MeGustas = 800000,
                Calificacion = 4.6,
                Precio = 26,
                UnidadesDisponibles = 40,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/Rammstein.jpg")),
                Canciones = new List<string> { "Du Hast", "Engel", "Sehnsucht", "Rammstein", "Wollt ihr das Bett in Flammen sehen?", "Asche zu Asche" },
                Preview = "pack://application:,,,/Music/rammstein.mp3",
                Cantidad = 1
            },
            new DiscoVinilo
            {
                Titulo = "Tim",
                Autor = "Avicii",
                SelloDiscografico = "Universal",
                Formato = "Vinilo",
                Pais = "Suecia",
                Fecha = new DateTime(2019, 6, 6),
                Genero = "EDM",
                MeGustas = 700000,
                Calificacion = 4.7,
                Precio = 21,
                UnidadesDisponibles = 20,
                EnFavoritos = true,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/Tim.jpg")),
                Canciones = new List<string> { "SOS", "Tough Love", "Heaven", "Bad Reputation", "Ain't a Thing", "Hold the Line" },
                Preview = "pack://application:,,,/Music/tim.mp3",
                Cantidad = 1
            },
            new DiscoVinilo
            {
                Titulo = "24K Magic",
                Autor = "Bruno Mars",
                SelloDiscografico = "Atlantic",
                Formato = "Vinilo",
                Pais = "EE.UU.",
                Fecha = new DateTime(2016, 11, 18),
                Genero = "Funk",
                MeGustas = 750000,
                Calificacion = 4.8,
                Precio = 25,
                UnidadesDisponibles = 30,
                EnFavoritos = true,
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/24K.jpg")),
                Canciones = new List<string> { "24K Magic", "Chunky", "Perm", "That's What I Like", "Versace on the Floor", "Finesse" },
                Preview = "pack://application:,,,/Music/24k_magic.mp3",
                Cantidad = 1
            }
        };
    }
}
