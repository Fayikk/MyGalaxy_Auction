using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Core.MailHelper
{
    public class MailService : IMailService
    {
        public void SendEmail(string subject, string body, string email)
        {
			try
			{
				var emailToSend = new MimeMessage();
				emailToSend.From.Add(MailboxAddress.Parse("YourGalaxyAuction@gmail.com"));
				emailToSend.To.Add(MailboxAddress.Parse(email));
				emailToSend.Subject = subject;
				emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

				//send mail

				using var emailClient = new SmtpClient();
				emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
				emailClient.Authenticate("veznedaroglufayik2@gmail.com", "fiabsqvdltozvtom");
				emailClient.Send(emailToSend);
				emailClient.Disconnect(true);



			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
