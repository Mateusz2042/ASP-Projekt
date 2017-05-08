using CompetitionRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.ViewModels
{
    public class UserMenu
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public eSex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}