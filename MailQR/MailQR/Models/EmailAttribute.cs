using System;

namespace MailQR.Models
{
    internal class EmailAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}