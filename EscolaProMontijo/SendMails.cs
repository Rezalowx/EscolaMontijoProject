using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;
namespace EscolaProMontijo
{
    class SendMails
    {


        /// <summary>
        /// Send an email
        /// </summary>
        /// <param name="message">string message</param>
        /// <param name="emailFrom">string email from</param>
        /// <param name="emailTo">string email to</param>
        /// <param name="subject">string email's subject</param>
        /// <param name="attachment">List<string> of attachments (paths) </param>
        public void sendAMail(string message, string emailFrom, string emailTo, string subject, List<string> attachment)
        {


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            MailMessage MyMsg = new MailMessage();
            MyMsg.Priority = MailPriority.High;
            MyMsg.To.Add(new MailAddress(emailTo));
            client.EnableSsl = true;
            if (attachment[0] != "")
            {
                
                foreach (string attachmentsInList in attachment)
                {
                    
                    MyMsg.Attachments.Add(new Attachment(attachmentsInList));
                }
                
            }
            MyMsg.Subject = subject;
            MyMsg.SubjectEncoding = Encoding.UTF8;
            MyMsg.IsBodyHtml = true;
            MyMsg.From = new MailAddress("gregory.brugnet@gmail.com","TCHOUPINOU'S APPLICATION FAIT DES TESTS SUR TWA");
            MyMsg.BodyEncoding = Encoding.UTF8;
            MyMsg.Body = message;
            client.Credentials = new System.Net.NetworkCredential("gregory.brugnet@gmail.com", "xDkikoolol1");

            
            client.Send(MyMsg);
            

        }

        /// <summary>
        /// Send an email
        /// </summary>
        /// <param name="message">string message</param>
        /// <param name="emailFrom">string email from</param>
        /// <param name="emailTo">string email to</param>
        /// <param name="subject">string email's subject</param>
        /// <param name="signature">string signature</param>
        /// <param name="attachment">List<string> of attachments (paths) </param>
        public void sendAMail(string message, string emailFrom, string emailTo, string subject, string signature, List<string> attachment)
        {


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            MailMessage MyMsg = new MailMessage();
            MyMsg.Priority = MailPriority.High;
            MyMsg.To.Add(new MailAddress(emailTo));
            client.EnableSsl = true;
            if (attachment[0] != "")
            {

                foreach (string attachmentsInList in attachment)
                {

                    MyMsg.Attachments.Add(new Attachment(attachmentsInList));
                }

            }
            MyMsg.Subject = subject;
            MyMsg.SubjectEncoding = Encoding.UTF8;
            MyMsg.IsBodyHtml = true;
            MyMsg.From = new MailAddress("gregory.brugnet@gmail.com", "TCHOUPINOU'S APPLICATION FAIT DES TESTS SUR TWA");
            MyMsg.BodyEncoding = Encoding.UTF8;
            MyMsg.Body = message+ "<br />" + signature;
            client.Credentials = new System.Net.NetworkCredential("gregory.brugnet@gmail.com", "PASSWORDLOL");


            client.Send(MyMsg);


        }

    }
}
