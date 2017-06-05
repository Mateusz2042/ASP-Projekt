using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.Models
{
    public class Team
    {
        public int Id { get; set; }
        public List<int> CompetitorsId { get; set; }

    }
}