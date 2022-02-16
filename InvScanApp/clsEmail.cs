using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

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
             * smtp.gmail.com
             */

            strUsername = Settings.Default.strEmailUsername;
            strPassword = Settings.Default.strEmailPassword;
            strToEmail = Settings.Default.strToEmail;
            strSMTPPort = Settings.Default.strSMTPPort;
            strSMTPClient = Settings.Default.strSMTPClient;
        }

        public static bool SendEmail(string strBody, string strSubject, bool blnAttachments)
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
                    Msg.To.Add(strToEmail);

                    //Assign the subject of our message.
                    Msg.Subject = strSubject;

                    //Create the content(body) of our message.
                    Msg.Body = strBody;

                    //Check if we should attach any files
                    if (blnAttachments)
                    {

                    }

                    // Send our account login details to the client.
                    client.Credentials = cred;

                    //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                    client.EnableSsl = true;

                    // Send our email.
                    client.SendMailAsync(Msg);

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }   
            }

            return false;
        }
    }
}
