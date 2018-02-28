using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
namespace EscolaProMontijo
{
    class SendMails
    {

        
        

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            ProgressBar token = (ProgressBar)e.UserState;
            

            if (e.Cancelled)
            {
                MessageBox.Show("[{0}] Send canceled.");
            }
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


            SmtpClient client = new SmtpClient("mail.epmontijo.edu.pt", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            MailMessage MyMsg = new MailMessage();
            MyMsg.Priority = MailPriority.High;
            MyMsg.To.Add(new MailAddress(emailTo));
            client.EnableSsl = true;
            if (attachment.Count != 0)
            {

                foreach (string attachmentsInList in attachment)
                {
                    MyMsg.Attachments.Add(new Attachment(attachmentsInList));
                }

            }

            MyMsg.Subject = subject;
            MyMsg.SubjectEncoding = Encoding.UTF8;
            MyMsg.IsBodyHtml = true;

            MyMsg.From = new MailAddress("bdepm@epmontijo.edu.pt", "Escola profissional do Montijo");
            MyMsg.BodyEncoding = Encoding.UTF8;
            if (File.Exists(@"C:\Users\user\AppData\Roaming\Microsoft\Signatures\" + signature))
            {
                MyMsg.Body = message.Replace(Environment.NewLine, "<br />") + "<br /><br />" + File.ReadAllText(@"C:\Users\user\AppData\Roaming\Microsoft\Signatures\"+signature)+ "<br />" + "<img src='https://image.noelshack.com/fichiers/2018/09/3/1519819796-signaturesample.png' alt ='EPM'>";
            }
            else
            {
                MyMsg.Body = message.Replace(Environment.NewLine, "<br />") + "<br /><br />" + signature.Replace(Environment.NewLine, "<br />") ;
            }
            

            client.Credentials = new System.Net.NetworkCredential("bdepm@epmontijo.edu.pt", "pw");


            client.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback  
            // method to identify this send operation. 
            // For this example, the userToken is a string constant. 

            client.SendAsync(MyMsg, progressBarMail);
            

            
            
        }

    }
}
