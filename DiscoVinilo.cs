using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AppVinilos
{
    public class DiscoVinilo : INotifyPropertyChanged
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private int _cantidad;
        private bool _enFavoritos;

        public DiscoVinilo()
        {
            PlayPreviewCommand = new RelayCommand(PlayPreview);
            
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string SelloDiscografico { get; set; }
        public string Formato { get; set; }
        public string Pais { get; set; }
        public DateTime Fecha { get; set; }
        public string Genero { get; set; }
        public int MeGustas { get; set; }
        public double Calificacion { get; set; }
        public int Precio { get; set; }
        public int UnidadesDisponibles { get; set; }
        public List<string> Canciones { get; set; }
        public BitmapImage Portada { get; set; }
        public string Preview { get; set; }

        public int Cantidad
        {
            get => _cantidad;
            set
            {
                if (_cantidad != value)
                {
                    _cantidad = value;
                    OnPropertyChanged(nameof(Cantidad));
                    OnPropertyChanged(nameof(TotalPrecio));
                }
            }
        }

        public bool EnFavoritos
        {
            get => _enFavoritos;
            set
            {
                if (_enFavoritos != value)
                {
                    _enFavoritos = value;
                    OnPropertyChanged(nameof(EnFavoritos));
                }
            }
        }

        public ICommand PlayPreviewCommand { get; }

        private void PlayPreview()
        {
            try
            {
                string previewFilePath = "";  // Ruta relativa al archivo de vista previa

                if (!string.IsNullOrEmpty(previewFilePath))
                {
                    // Usa un Uri absoluto que apunta a la ubicación del archivo en el sistema de archivos
                    string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, previewFilePath);
                    Uri previewUri = new Uri(absolutePath, UriKind.Absolute);

                    mediaPlayer.Open(previewUri);
                    mediaPlayer.Play();
                }
                else
                {
                    MessageBox.Show("No se ha proporcionado un URI de vista previa.", "Error de reproducción", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reproducir la vista previa: {ex.Message}", "Error de reproducción", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int TotalPrecio => Precio * Cantidad;
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
