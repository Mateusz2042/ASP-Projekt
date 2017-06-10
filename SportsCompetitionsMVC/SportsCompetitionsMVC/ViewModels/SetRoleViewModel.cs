using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.ViewModels
{
    public class SetRoleViewModel
    {

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Role")]
        public List<string> Role { get; set; }



    }
}