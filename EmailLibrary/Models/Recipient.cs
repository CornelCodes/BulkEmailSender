using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailLibrary.Models
{
    public class Recipient
    {
        public string EmailAddress { get; set; }
        public bool Exists { get; set; }

        public Recipient(string emailAddress)
        {
            EmailAddress = emailAddress;
        }
    }
}
