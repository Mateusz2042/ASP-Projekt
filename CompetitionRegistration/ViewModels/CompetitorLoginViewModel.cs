using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.ViewModels
{
    public class CompetitorLoginViewModel
    {

        
        [Required(ErrorMessage = "Please insert  e-mail address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        public string Email { get; set; }
        [Display(Name = "Hasło")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "wpisz haslo dllugosci 5-20 znakow")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}