using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public List<Competitor> Competitors { get; set; }

    }
}