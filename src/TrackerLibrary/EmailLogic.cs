using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;


namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, MimeEntity body)
        {
            //MimeMessage fromMailAddress = new MimeMessage(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));
            //message.From.Add(new MailboxAddress(GlobalConfig.AppKeyLookup("senderDisplayName"), GlobalConfig.AppKeyLookup("senderEmail")));

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Mahmood Seoud", "Matooize@gmail.com"));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;
            message.Body = body;
            string emailAddress = "Matooize@gmail.com";
            string password = "Epe43kms123";

            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465,true);

                client.Authenticate(emailAddress, password);
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }


        }
    }
}
