using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using VBV3Project.Interfaces;
using VBV3Project.Models; 

namespace VBV3Project.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public Task SendEmailConfirmationAsync(string email, string link)
        {
            string subject = "Confirm your email";
            string message = $"Please confirm your email by clicking this link: {link}";

            return SendEmailAsync(email, subject, message);
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var smtpClient = new SmtpClient
            {
                Host = _emailSettings.Host,
                Port = _emailSettings.Port,
                EnableSsl = _emailSettings.EnableSSL,
                Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password)
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_emailSettings.FromAddress, _emailSettings.FromName),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };

            mailMessage.To.Add(new MailAddress(email));

            await smtpClient.SendMailAsync(mailMessage);
        }
        public class EmailSenderOptions
        {
            public string SendGridUser { get; set; }
            public string SendGridKey { get; set; }
        }

    }
}

