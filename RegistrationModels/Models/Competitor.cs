using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.Models
{
    public enum eSex
    {
        Male,
        Famale
    }
    public class Competitor
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public eSex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public List<Competition> Competitions { get; set; }

    }
}