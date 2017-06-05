using SportsCompetitions.Enums;
using SportsCompetitions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.Models
{
    public class TeamCompetition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public eCategory Category { get; set; }
        public DateTime StartDate { get; set; }
        public List<Team> Teams { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
    }
}