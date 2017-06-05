using SportsCompetitions.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.ViewModels
{
    public class CompetitonViewModel
    {
        [Required(ErrorMessage = "Please insert title")]
        [Display(Name = "tytuł")]

        public string Title { get; set; }
        public eCategory Category { get; set; }
        public DateTime StartDate { get; set; }
    }
}