using Microsoft.AspNet.Identity.EntityFramework;
using SportsCompetitionsMVC.Models;
using System;
using static SportsCompetitions.Enums.Enums;

namespace SportsCompetitions.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {


        
        
        public string Email { get; set; }
        public bool ConfirmedEmail { get; set; }

        


        public virtual Competition Competition { get; set; }
        public virtual Informations Informations { get; set; }
    }

    
}