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
            client.Credentials = new System.Net.NetworkCredential("gregory.brugnet@gmail.com", "passwordLOL");

            
            client.Send(MyMsg);
            

        }

       
        
    }
}
