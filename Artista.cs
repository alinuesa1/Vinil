using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public class Artista : INotifyPropertyChanged
    {
        private int _numeroFavoritos;

        public string NombreArtistico { get; set; }
        public string NombreReal { get; set; }
        public string Componentes { get; set; }
        public DateTime FechaNacimientoOCreacion { get; set; }
        public string Descripcion { get; set; }
        public string GeneroMusical { get; set; }
        public List<string> EnlacesRedesSociales { get; set; }
        public int NumeroFavoritos
        {
            get => _numeroFavoritos;
            set
            {
                if (_numeroFavoritos != value)
                {
                    _numeroFavoritos = value;
                    OnPropertyChanged(nameof(NumeroFavoritos));
                }
            }
        }
        public List<BitmapImage> GaleriaImagenes { get; set; }
        public List<DiscoVinilo> Discografia { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Artista()
        {
            EnlacesRedesSociales = new List<string>();
            GaleriaImagenes = new List<BitmapImage>();
            Discografia = new List<DiscoVinilo>();
        }
    }
}
