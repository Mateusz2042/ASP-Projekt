using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.ViewModels
{
    public class SetRoleViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public List<string> Role { get; set; }



    }
}