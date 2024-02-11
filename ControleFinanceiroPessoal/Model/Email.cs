using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Model
{
    internal class Email
    {
        static string GerarCodigo()
        {
            return new Random().Next(1000, 9999).ToString();
        }

        static void EnviarEmail(string servidorSmtp, int portaSmtp, string usuarioSmtp, string senhaSmtp, string destinatario, string assunto, string corpo)
        {
            SmtpClient clienteSmtp = new SmtpClient(servidorSmtp)
            {
                Port = portaSmtp,
                Credentials = new NetworkCredential(usuarioSmtp, senhaSmtp),
                EnableSsl = true,
            };

            // Configuração da mensagem
            MailMessage mensagem = new MailMessage
            {
                From = new MailAddress(usuarioSmtp),
                Subject = assunto,
                Body = corpo,
                IsBodyHtml = false,
            };

            mensagem.To.Add(destinatario);

            // Envio da mensagem
            clienteSmtp.Send(mensagem);
        }
    }
}
