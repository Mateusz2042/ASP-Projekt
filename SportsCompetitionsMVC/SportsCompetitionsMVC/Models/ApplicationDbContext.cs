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
        public DbSet<SingleCompetition> SingleCompetition { get; set; }
        public DbSet<TeamCompetition> TeamCompetition { get; set; }
        public DbSet<Informations> Informations { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
       
    }

}