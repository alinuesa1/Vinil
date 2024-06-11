using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AppVinilos
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Stack<Window> NavigationStack { get; private set; } = new Stack<Window>();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            NavigationStack.Push(new DiscosDisponibles());
        }
        public static ResourceDictionary SelectCulture(string idioma)
        {
            var resourceDictionary = new ResourceDictionary();
            switch (idioma)
            {
                case "en-US":
                    resourceDictionary.Source =
                    new Uri("/Resources/StringResources.en-US.xaml", UriKind.Relative);
                    break;
                case "es-ES":
                    resourceDictionary.Source =
                    new Uri("/Resources/StringResources.es-ES.xaml", UriKind.Relative);
                    break;
                default:
                    resourceDictionary.Source =
                    new Uri("/Resources/StringResources.es-ES.xaml", UriKind.Relative);
                    break;
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(idioma);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            return resourceDictionary;
        }
    }
}
