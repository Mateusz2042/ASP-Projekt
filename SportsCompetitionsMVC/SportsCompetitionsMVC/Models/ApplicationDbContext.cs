using Microsoft.AspNet.Identity.EntityFramework;
using SportsCompetitionsMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsCompetitions.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Competition> Competition { get; set; }
        //public DbSet<Preferences> Preferences { get; set; }
        //public DbSet<Informations> Informations { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }

}