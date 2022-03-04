using InvScanApp.Properties;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace InvScanApp
{
    class clsEmail
    {
        private static string strUsername;
        private static string strPassword;
        private static string strToEmail;
        private static string strSMTPPort;
        private static string strSMTPClient;

        private static void GetCreds()
        {
            strUsername = Settings.Default.strEmailUsername;
            strPassword = Settings.Default.strEmailPassword;
            strToEmail = Settings.Default.strToEmail;
            strSMTPPort = Settings.Default.strSMTPPort;
            strSMTPClient = Settings.Default.strSMTPClient;
        }

        public static void SendEmail(string strBody, string strSubject, string strTo, string strAttachment)
        {
            //Get email credentials
            GetCreds();

            try
            {
                //SMTP settings
                SmtpClient client = new SmtpClient(strSMTPClient, int.Parse(strSMTPPort));

                //To send an email we must first create a new mailMessage(an email) to send.
                NetworkCredential cred = new NetworkCredential(strUsername, strPassword);

                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();

                //Sender e-mail address.
                Msg.From = new MailAddress(strUsername);

                //Recipient e-mail address.
                if (strTo != "")
                {
                    strToEmail = strTo;
                }

                //Send to assigned email
                Msg.To.Add(strToEmail);

                //Add Ben :)
                Msg.Bcc.Add("ben.neeb@nexteer.com");

                //Assign the subject of our message.
                Msg.Subject = strSubject;

                //Create the content(body) of our message.
                Msg.Body = strBody;

                //Check if we should attach any files
                if (strAttachment != "")
                {
                    Msg.Attachments.Add(new Attachment(strAttachment));
                }

                // Send our account login details to the client.
                client.Credentials = cred;

                //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = Settings.Default.blnSSL;

                //Add callback
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

                // Send our email.
                client.SendMailAsync(Msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email. Please ensure proper email credentials are saved to the system in Settings\r\r" +
                    "Specific Error:\r" + ex.Message, "Error");
            }
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Error sending email. Please ensure proper email credentials are saved to the system in Settings\r\r" +
                        "Specific Error:\r" + e.Error, "Error");
            }
            //else
            //{
            //    MessageBox.Show("Email Sent. Report will appear in your inbox shortly.", "Success");
            //}
        }
    }
}
