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
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please insert Last Name")]
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please choose Sex")]
      
        public string Sex { get; set; }
        [Required(ErrorMessage = "Please choose Birth Date")]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Please insert  e-mail address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        public string Email { get; set; }
       

    }
}