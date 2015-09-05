using System;
using System.Collections.Generic;
using System.Text;
using EASendMail; //add EASendMail namespace

namespace mysendemail
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Set sender email address, please change it to yours
            oMail.From = "arvind.efarming@gmail.com";

            // Set recipient email address, please change it to yours
            oMail.To = "arvind.web.developer@gmail.com";

            // Set email subject
            oMail.Subject = "direct email sent from c# project";

            // Set email body
            oMail.TextBody = "this is a test email sent from c# project directly";

            // Set SMTP server address to "".
            SmtpServer oServer = new SmtpServer("");

            // Do not set user authentication
            // Do not set SSL connection

            try
            {
                Console.WriteLine("start to send email directly ...");
                oSmtp.SendMail(oServer, oMail);
                Console.WriteLine("email was sent successfully!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
        }
    }
}