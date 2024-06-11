using System.Windows;

namespace AppVinilos
{
    public partial class MasDetallesArtistas : Window
    {
        public MasDetallesArtistas(Artista artista)
        {
            InitializeComponent();
            DataContext = artista;
        }
    }
}
