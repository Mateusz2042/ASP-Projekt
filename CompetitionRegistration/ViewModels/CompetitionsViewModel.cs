using CompetitionRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.ViewModels
{
    public class CompetitionsViewModel
    {
        public string Title { get; set; }
        public eCategory Category { get; set; }
        public DateTime StartDate { get; set; }
    }
}