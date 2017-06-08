using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.ViewModels
{
    public class DisplayEventViewModel
    {
        
        public string Title { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public string ModeratorName { get; set; }
        public int CompetitorsCount { get; set; }
    }
}