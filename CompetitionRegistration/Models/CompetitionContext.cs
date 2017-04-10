using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.Models
{
    public class CompetitionContext: DbContext
    {
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Competitor> Competitor { get; set; }
        public DbSet<Moderator> Moderator { get; set; }
    }
}