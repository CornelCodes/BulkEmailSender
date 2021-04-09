using EmailLibrary.Models;
using EmailLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailLibrary
{
    public class Emailer
    {
        public BindingList<Recipient> recipients;
        public Sender mailSender;
        SmtpClient SmtpServer;

        public Emailer()
        {
            recipients = new BindingList<Recipient>();
            mailSender = new Sender();
        }

        public void AddRecipient(string emailAddress)
        {
            recipients.Add(new Recipient(emailAddress));
            Console.WriteLine($"Added recipient {emailAddress}");
        }

        public void RemoveRecipient(Recipient recipientEmail)
        {
            foreach (var recipient in recipients)
            {
                if(recipientEmail == recipient)
                {
                    recipients.Remove(recipient);
                    Console.WriteLine($"Removed recipient: {recipient.EmailAddress}");
                    break;
                }
            }
        }

        public async void SendEmailToAll(string subject, string body, string senderEmail, string senderName, string senderPassword)
        {
            SmtpServer = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true
            };


            await Task.Run(() =>
            {
                foreach (Recipient recipient in recipients)
                {

                    if (EmailValidator.Validate(recipient.EmailAddress))
                    {
                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(senderEmail);
                        message.To.Add(recipient.EmailAddress);
                        message.Subject = subject;
                        message.Body = body;
                        SmtpServer.Send(message);

                        Console.WriteLine($"Sending email to {message.To}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Email");
                    }

                }
            });

            Console.WriteLine("Email sent");

        }

    }
}
