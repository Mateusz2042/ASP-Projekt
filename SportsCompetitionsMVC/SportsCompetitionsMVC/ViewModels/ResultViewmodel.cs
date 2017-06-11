using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.ViewModels
{
    public class ResultViewmodel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Numer miejsca")]
        public int PlaceNo { get; set; }
        [Required]
        [Display(Name = "Miejsce dla")]
        public string PlaceFor { get; set; }

    }
}