using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppVinilos
{
    internal class WindowManager
    {
        public static AdminMainWindow AdminMainWindowInstance { get; set; }
        public static CrearArtista CrearArtistasInstance { get; set; }
        public static CrearDiscos CrearDiscosInstance { get; set; }
        public static DetallesArtistas DetallesArtistasInstance { get; set; }
        public static DetallesDiscos DetallesDiscosInstance { get; set; }
        public static DiscosDisponibles DiscosDisponiblesInstance { get; set; }
        public static EditarDiscos EditarDiscosInstance { get; set; }
        public static EditarArtista EditarArtistasInstance { get; set; }
        public static GestionarOfertas GestionarOfertasControlInstance { get; set; }
        public static HistorialPedidosControl HistorialPedidosControlInstance { get; set; }
        public static LoginWindow LoginWindowInstance { get; set; }
        public static Pago PagoInstance { get; set; }
        public static RegistroWindow RegistroWindowInstance { get; set; }
        public static UserMainWindow UserMainWindowInstance { get; set; }
        public static CarritoCompra CarritoCompraInstance { get; set; }
        public static Help HelpInstance { get; set; }
        public static FavoritosWindow FavoritosWindowInstance { get; set; }
        public static Ofertas OfertasWindowInstance { get;  set; }
        public static HistorialPedidos HistorialPedidosInstance { get; set; }
        public static ArtistasDisponibles ArtistasDisponiblesInstance { get; set; }
    }
}
