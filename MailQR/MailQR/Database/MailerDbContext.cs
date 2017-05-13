using MailQR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MailQR.Database
{
    public class MailerDbContext : DbContext
    {
        public DbSet<ConfirmationEmailViewModel> ConfirmationEmails { get; set; }

        public MailerDbContext() : base("MailerDbContext")
        {
            Database.CreateIfNotExists();
        }

    }
}