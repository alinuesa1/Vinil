using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace AppVinilos
{
    public partial class NuevaOfertaDialog : Window
    {
        private string selectedImagePath;
        private BitmapImage selectedBitmapImage;
        private string selectedDocumentPath;

        public Oferta NuevaOferta { get; private set; }

        public NuevaOfertaDialog()
        {
            InitializeComponent();
        }

        private void SeleccionarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                selectedImagePath = openFileDialog.FileName;
                selectedBitmapImage = new BitmapImage(new Uri(selectedImagePath));
                MessageBox.Show($"Imagen seleccionada: {selectedImagePath}");
            }
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            NuevaOferta = new Oferta
            {
                Titulo = txtTitulo.Text,
                Descripcion = txtDescripcion.Text,
                Descuento = txtDescuento.Text,
                Imagen = selectedBitmapImage,
                FechaEnvio = (DateTime)dpFechaEnvio.SelectedDate,
                Destinatarios = txtDestinatarios.Text,
            };

            DialogResult = true;
            Close();
        }

        private async Task ProgramarEnvioCorreo(Oferta oferta)
        {
            TimeSpan delay = oferta.FechaEnvio - DateTime.Now;
            if (delay.TotalMilliseconds <= 0)
            {
                MessageBox.Show("La fecha y hora de envío deben ser futuras.");
                return;
            }

            await Task.Delay(delay);
            EnviarCorreo(oferta);
        }

        private void EnviarCorreo(Oferta oferta)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.tuservidor.com");

                foreach (var destinatario in oferta.Destinatarios.Split(','))
                {
                    mail.To.Add(destinatario.Trim());
                }

                mail.Subject = $"Oferta: {oferta.Titulo}";
                mail.Body = $"Descripción: {oferta.Descripcion}\nDescuento: {oferta.Descuento}";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("tuEmail@tuservidor.com", "tuContraseña");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
