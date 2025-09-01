using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using ContentDisposition = MimeKit.ContentDisposition;

namespace ProyectoBibliotecaVirtual.Models
{
    public static class Mail
    {

        public static void EnviarCorreoBienvenida(string correoDestino, string nombreUsuario)
        {
            byte[] pdfBytes;

            // --- Modificar PDF base ---
            using (var ms = new MemoryStream())
            {
                string inputPdf = @"C:\Users\ASUS\Desktop\Poo\CertificadoBase.pdf"; // PDF plantilla
                string rutaImagen = @"C:\Users\ASUS\Desktop\Poo\Gengar.png";          // Imagen (logo/foto)

                using (var pdfReader = new PdfReader(inputPdf))
                using (var pdfWriter = new PdfWriter(ms))
                using (var pdfDoc = new PdfDocument(pdfReader, pdfWriter))
                {
                    Document document = new Document(pdfDoc);

                    // Insertar imagen (logo/foto)
                    var imgData = iText.IO.Image.ImageDataFactory.Create(rutaImagen);
                    var img = new iText.Layout.Element.Image(imgData)
                        .SetWidth(150)
                        .SetHeight(150)
                        .SetFixedPosition(1, 300, 700); // Página 1, coordenadas X=450, Y=600
                    document.Add(img);

                    // Insertar nombre del usuario
                    var nombre = new iText.Layout.Element.Paragraph("Damos la bienvenida a : " + nombreUsuario + " gracias por llegar a la biblioteca virtual")
                        .SetFontSize(40)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFixedPosition(1, 200, 400, 400); // Página 1, posición X=100, Y=400, ancho=400
                    document.Add(nombre);

                    document.Close();
                }

                pdfBytes = ms.ToArray(); // Guardamos el PDF en memoria
            }

            // --- Crear el correo ---
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Biblioteca Virtual", "gengarbibliotecauwu@gmail.com"));
            mensaje.To.Add(new MailboxAddress(nombreUsuario, correoDestino));
            mensaje.Subject = "¡Bienvenido a la Biblioteca Virtual!";

            var cuerpo = new TextPart("plain")
            {
                Text = $"Hola {nombreUsuario},\n\n¡Bienvenido a la Biblioteca Virtual!\nAdjunto encontrarás tu certificado de bienvenida.\n\nSaludos,\nEquipo Biblioteca"
            };

            var adjunto = new MimePart("application", "pdf")
            {
                Content = new MimeContent(new MemoryStream(pdfBytes)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = "CertificadoBienvenida.pdf"
            };

            var multipart = new Multipart("mixed");
            multipart.Add(cuerpo);
            multipart.Add(adjunto);

            mensaje.Body = multipart;

            using (var cliente = new MailKit.Net.Smtp.SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                cliente.Authenticate("gengarbibliotecauwu@gmail.com", "mfui hpzc jmxb obja");
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }


    public static void EnviarCorreoPrimerLogro(string correoDestino, string nombreUsuario)
        {
            byte[] pdfBytes;
            // --- Modificar PDF base ---
            using (var ms = new MemoryStream())
            {
                string inputPdf = @"C:\Users\ASUS\Desktop\Poo\CertificadoBase.pdf"; // PDF plantilla
                string rutaImagen = @"C:\Users\ASUS\Desktop\Poo\Gengar.png";          // Imagen (logo/foto)
                using (var pdfReader = new PdfReader(inputPdf))
                using (var pdfWriter = new PdfWriter(ms))
                using (var pdfDoc = new PdfDocument(pdfReader, pdfWriter))
                {
                    Document document = new Document(pdfDoc);
                    // Insertar imagen (logo/foto)
                    var imgData = iText.IO.Image.ImageDataFactory.Create(rutaImagen);
                    var img = new iText.Layout.Element.Image(imgData)
                        .SetWidth(150)
                        .SetHeight(150)
                        .SetFixedPosition(1, 300, 700); // Página 1, coordenadas X=450, Y=600
                    document.Add(img);
                    // Insertar nombre del usuario
                    var nombre = new iText.Layout.Element.Paragraph("Te felicitamos por haber conseguido un logro : "+nombreUsuario+" avanza a por mas.")
                        .SetFontSize(40)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFixedPosition(1, 200, 400, 400); // Página 1, posición X=100, Y=400, ancho=400
                    document.Add(nombre);
                    document.Close();
                }
                pdfBytes = ms.ToArray(); // Guardamos el PDF en memoria
            }
            // --- Crear el correo ---
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Biblioteca Virtual", "gengarbibliotecauwu@gmail.com"));
            mensaje.To.Add(new MailboxAddress(nombreUsuario, correoDestino));
            mensaje.Subject = "¡Bienvenido a la Biblioteca Virtual!";

            var cuerpo = new TextPart("plain")
            {
                Text = $"Hola {nombreUsuario},\n\n¡haz consegido una logro en Biblioteca Virtual!\nAdjunto encontrarás tu certificado.\n\nSaludos,\nEquipo Biblioteca"
            };

            var adjunto = new MimePart("application", "pdf")
            {
                Content = new MimeContent(new MemoryStream(pdfBytes)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = "CertificadoBienvenida.pdf"
            };

            var multipart = new Multipart("mixed");
            multipart.Add(cuerpo);
            multipart.Add(adjunto);

            mensaje.Body = multipart;

            using (var cliente = new MailKit.Net.Smtp.SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                cliente.Authenticate("gengarbibliotecauwu@gmail.com", "mfui hpzc jmxb obja");
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }
    }
}