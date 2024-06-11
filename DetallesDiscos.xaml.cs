using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AppVinilos
{
    public partial class DetallesDiscos : Window
    {
        public DetallesDiscos()
        {
            InitializeComponent();
            listBoxDiscos.ItemsSource = DiscosData.Discos;
        }

        private void BtnCrearDisco_Click(object sender, RoutedEventArgs e)
        {
            CrearDiscos crearDiscoWindow = new CrearDiscos();
            if (crearDiscoWindow.ShowDialog() == true)
            {
                DiscosData.Discos.Add(crearDiscoWindow.NuevoDisco);
                listBoxDiscos.Items.Refresh();
            }
        }

        private void BtnEditarDisco_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDiscos.SelectedItem != null)
            {
                DiscoVinilo discoSeleccionado = (DiscoVinilo)listBoxDiscos.SelectedItem;
                EditarDiscos editarDiscoWindow = new EditarDiscos(discoSeleccionado);
                if (editarDiscoWindow.ShowDialog() == true)
                {
                    discoSeleccionado.Titulo = editarDiscoWindow.NuevoTitulo;
                    discoSeleccionado.Autor = editarDiscoWindow.NuevoAutor;
                    discoSeleccionado.Fecha = editarDiscoWindow.NuevaFecha;
                    discoSeleccionado.Precio = editarDiscoWindow.NuevoPrecio;
                    discoSeleccionado.Calificacion = editarDiscoWindow.NuevaCalificacion;
                    discoSeleccionado.UnidadesDisponibles = editarDiscoWindow.NuevasUnidadesDisponibles;
                    discoSeleccionado.Canciones = editarDiscoWindow.NuevasCanciones;
                    discoSeleccionado.Portada = editarDiscoWindow.NuevaPortada;
                    discoSeleccionado.Preview = editarDiscoWindow.NuevaPreview;
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
            if (listBoxDiscos.SelectedItem != null)
            {
                DiscoVinilo discoSeleccionado = (DiscoVinilo)listBoxDiscos.SelectedItem;
                MessageBoxResult result = MessageBox.Show($"¿Estás seguro de borrar el disco '{discoSeleccionado.Titulo}'?", "Borrar Disco", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    DiscosData.Discos.Remove(discoSeleccionado);
                    listBoxDiscos.Items.Refresh();
                }
                else
                {
                    listBoxDiscos.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un disco para borrar.", "Borrar Disco", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            WindowManager.AdminMainWindowInstance = adminMainWindow;
            WindowManager.AdminMainWindowInstance.Show();
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
            MessageBox.Show("Cerrando sesión...");
            LoginWindow loginWindow = new LoginWindow();
            WindowManager.LoginWindowInstance = loginWindow;
            WindowManager.LoginWindowInstance.Show();
            this.Hide();
        }
    }
}
