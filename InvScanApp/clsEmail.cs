using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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
            /*
             * techbarinventory@gmail.com
             * Technology_Bar2022!
             * 587
             * 
             * smtp.gmail.com - Gmail
             * smtp.live.com - Windows live / Hotmail
             * smtp.mail.yahoo.com - Yahoo
             * smtp.aim.com - AIM
             * my.inbox.com - Inbox
             */

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

            if (strUsername.Length > 0 && strPassword.Length > 0 && strToEmail.Length > 0 && strSMTPPort.Length > 0 && strSMTPClient.Length > 0)
            {
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
                    client.EnableSsl = true;

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
