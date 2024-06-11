using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public static class ArtistaData
    {
        public static List<Artista> Artistas { get; set; }

        static ArtistaData()
        {
            Artistas = new List<Artista>
            {
                new Artista
                {
                    NombreArtistico = "The Beatles",
                    NombreReal = "John, Paul, George, Ringo",
                    Componentes = "John Lennon, Paul McCartney, George Harrison, Ringo Starr",
                    FechaNacimientoOCreacion = new DateTime(1960, 1, 1),
                    Descripcion = "Legendary rock band from Liverpool, England.",
                    GeneroMusical = "Rock",
                    EnlacesRedesSociales = new List<string> { "https://facebook.com/thebeatles", "https://twitter.com/thebeatles" },
                    NumeroFavoritos = 5000000,
                    GaleriaImagenes = new List<BitmapImage>
                    {
                        new BitmapImage(new Uri("pack://application:,,,/Imagenes/beatles1.jpg")),
                        new BitmapImage(new Uri("pack://application:,,,/Imagenes/beatles2.jpg"))
                    },
                    Discografia = new List<DiscoVinilo>
                    {
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
                Preview = "pack://application:,,,/Music/HereComesTheSun.mp3",
                Cantidad = 1
            },
                                    new DiscoVinilo
            {
                Titulo = "Sgt. Pepper's Lonely Hearts Club Band",
                Autor = "The Beatles",
                Fecha = new DateTime(1967, 5, 26),
                Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/sgtpepper.jpg")),
                SelloDiscografico = "Parlophone",
                Formato = "Vinilo",
                Pais = "Reino Unido",
                Genero = "Rock",
                MeGustas = 3500000,
                Calificacion = 4.8,
                Precio = 27,
                UnidadesDisponibles = 15,
                Cantidad = 1,
                Canciones = new List<string> { "Sgt. Pepper's Lonely Hearts Club Band", "With a Little Help from My Friends", "Lucy in the Sky with Diamonds", "Getting Better", "Fixing a Hole", "She's Leaving Home", "Being for the Benefit of Mr. Kite!", "Within You Without You", "When I'm Sixty-Four", "Lovely Rita", "Good Morning Good Morning", "Sgt. Pepper's Lonely Hearts Club Band (Reprise)", "A Day in the Life" },
            },
                    }
                },
                new Artista
                {
                    NombreArtistico = "Queen",
                    NombreReal = "Freddie Mercury, Brian May, Roger Taylor, John Deacon",
                    Componentes = "Freddie Mercury, Brian May, Roger Taylor, John Deacon",
                    FechaNacimientoOCreacion = new DateTime(1970, 1, 1),
                    Descripcion = "Iconic British rock band known for their elaborate stage performances.",
                    GeneroMusical = "Rock",
                    EnlacesRedesSociales = new List<string> { "https://facebook.com/queen", "https://twitter.com/queen" },
                    NumeroFavoritos = 4000000,
                    GaleriaImagenes = new List<BitmapImage>
                    {
                        new BitmapImage(new Uri("pack://application:,,,/Imagenes/queen.jpg")),
                        new BitmapImage(new Uri("pack://application:,,,/Imagenes/queen2.jpg"))
                    },
                    Discografia = new List<DiscoVinilo>
                    {
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
                            Preview = "Music/bohemian_rhapsody.mp3",
                            Cantidad = 1
                        },
                        new DiscoVinilo
                        {
                            Titulo = "The Game",
                            Autor = "Queen",
                            Fecha = new DateTime(1980, 6, 30),
                            Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/thegame.png")),
                            SelloDiscografico = "EMI",
                            Formato = "Vinilo",
                            Pais = "Reino Unido",
                            Genero = "Rock",
                            MeGustas = 2000000,
                            Calificacion = 4.7,
                            Precio = 22,
                            UnidadesDisponibles = 12,
                            Cantidad = 1,
                            Canciones = new List<string> { "Play the Game", "Dragon Attack", "Another One Bites the Dust", "Need Your Loving Tonight", "Crazy Little Thing Called Love" },
                        },
                    }
                },
                new Artista
                {
                    NombreArtistico = "Pink Floyd",
                    NombreReal = "Syd Barrett, Roger Waters, David Gilmour, Richard Wright, Nick Mason",
                    Componentes = "Syd Barrett, Roger Waters, David Gilmour, Richard Wright, Nick Mason",
                    FechaNacimientoOCreacion = new DateTime(1965, 1, 1),
                    Descripcion = "English rock band known for their progressive and psychedelic music.",
                    GeneroMusical = "Progressive Rock",
                    EnlacesRedesSociales = new List<string> { "https://facebook.com/pinkfloyd", "https://twitter.com/pinkfloyd" },
                    NumeroFavoritos = 3500000,
                    GaleriaImagenes = new List<BitmapImage>
                    {
                        new BitmapImage(new Uri("pack://application:,,,/Imagenes/pinkfloyd1.jpg")),
                        new BitmapImage(new Uri("pack://application:,,,/Imagenes/pinkfloyd2.jpg"))
                    },
                    Discografia = new List<DiscoVinilo>
                    {
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
                Preview = "pack://application:,,,/Music/dark_side_of_the_moon.mp3",
                Cantidad = 1
            },
                        new DiscoVinilo
                        {
                            Titulo = "Wish You Were Here",
                            Autor = "Pink Floyd",
                            Fecha = new DateTime(1975, 9, 12),
                            Portada = new BitmapImage(new Uri("pack://application:,,,/Imagenes/wishyouwerehere.jpg")),
                            Precio = 29,
                            Cantidad = 850
                        }
                    }
                }
            };
        }
    }
}
