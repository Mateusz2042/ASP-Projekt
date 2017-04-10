using CompetitionRegistration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.ViewModels
{
    public class CompetitorRegistrationViewModel
    {
        [Required(ErrorMessage = "Please insert First Name")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        public string Email { get; set; }
       

    }
}