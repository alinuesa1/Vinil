using System;
using System.Windows;
using System.Windows.Media;

namespace AppVinilos
{
    public partial class MasDetalles : Window
    {
        public MasDetalles(DiscoVinilo disco)
        {
            InitializeComponent();
            DataContext = disco;
        }
    }
}

