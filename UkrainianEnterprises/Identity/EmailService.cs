using Microsoft.AspNet.Identity;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace UkrainianEnterprises.Identity
{
    public class EmailService : IIdentityMessageService
    {
        private int smtpPort = 587;

        public Task SendAsync(IdentityMessage message)
        {
            MailMessage email = new MailMessage("valeriiakuznetsova@hotmail.com", message.Destination);

            email.Subject = message.Subject;

            email.Body = message.Body;

            email.IsBodyHtml = true;

            var mailClient = new SmtpClient("smtp.live.com", smtpPort)
            {
                Credentials = new NetworkCredential("valeriiakuznetsova@hotmail.com", "atussin111LIVE"),
                EnableSsl = true
            };

            return mailClient.SendMailAsync(email);
        }
    }
}