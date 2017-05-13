using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Postal;

namespace MailQR.Models
{
    public class ConfirmationEmail : Email
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string To { get; set; }
        public string QRCodePath { get; set; }

    }
}
