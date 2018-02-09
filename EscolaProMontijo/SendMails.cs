using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;
using System.ComponentModel;
namespace EscolaProMontijo
{
    class SendMails
    {

        
        

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            ProgressBar token = (ProgressBar)e.UserState;
            
            
            if (e.Error != null)
            {
                MessageBox.Show( e.Error.ToString());
            }
            else
            {

                token.PerformStep();
                   
            }
            
        }
        
       
        /// <summary>
        /// Send async email
        /// </summary>
        /// <param name="message">string message</param>
        /// <param name="emailFrom">string email from</param>
        /// <param name="emailTo">string email to</param>
        /// <param name="subject">string email's subject</param>
        /// <param name="signature">string signature</param>
        /// <param name="attachment">List<string> of attachments (paths) </param>
        public void sendAMail(string message, string emailFrom, string emailTo, string subject, string signature, List<string> attachment, ProgressBar progressBarMail)
        {


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            MailMessage MyMsg = new MailMessage();
            MyMsg.Priority = MailPriority.High;
            MyMsg.To.Add(new MailAddress(emailTo));
            client.EnableSsl = true;
            if (attachment.Count !=0)
            {
                
                foreach (string attachmentsInList in attachment)
                {

                    MyMsg.Attachments.Add(new Attachment(attachmentsInList));
                }

            }
            MyMsg.Subject = subject;
            MyMsg.SubjectEncoding = Encoding.UTF8;
            MyMsg.IsBodyHtml = false;
            MyMsg.From = new MailAddress("gregory.brugnet@gmail.com", "TCHOUPINOU'S APPLICATION FAIT DES TESTS SUR TWA");
            MyMsg.BodyEncoding = Encoding.UTF8;
            MyMsg.Body = message+"\n\n" + signature;
            client.Credentials = new System.Net.NetworkCredential("gregory.brugnet@gmail.com", "passwordlol");

            client.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback  
            // method to identify this send operation. 
            
            
            client.SendAsync(MyMsg, progressBarMail);

            
            
        }

    }
}
