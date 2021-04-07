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
        SmtpClient smtpClient;

        public Emailer()
        {
            recipients = new BindingList<Recipient>();
            mailSender = new Sender();
        }

        public void AddSender(string emailAddress, string name, string password)
        {
            if (EmailValidator.Validate(emailAddress))
            {
                mailSender.EmailAddress = emailAddress;
                mailSender.Name = name;
                mailSender.Password = password;
            }
            else
            {
                mailSender = null;
            }
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

        public async void SendEmailToAll(string subject, string body)
        {
            smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(mailSender.EmailAddress, mailSender.Password),
                EnableSsl = true
            };

            await Task.Run(() =>
            {
                foreach (Recipient recipient in recipients)
                {
                    if (EmailValidator.Validate(recipient.EmailAddress))
                    {
                        smtpClient.Send(mailSender.EmailAddress, recipient.EmailAddress, subject, body);
                    }
                }
            });

            Console.WriteLine("Sent emails");
        }
    }
}
