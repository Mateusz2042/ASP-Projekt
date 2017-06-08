using SportsCompetitions.Enums;
using SportsCompetitions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.Models
{
    public class SingleCompetition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public eCategory Category { get; set; }
        public DateTime StartDate { get; set; }
        public string ModeratorId { get; set; }
        public List<string> CompetitorsId { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
        //public  virtual List<string> 
    }
}