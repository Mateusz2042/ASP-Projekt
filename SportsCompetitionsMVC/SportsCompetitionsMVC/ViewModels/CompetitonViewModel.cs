using SportsCompetitions.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsCompetitionsMVC.ViewModels
{
    public class CompetitonViewModel
    {
        [Required(ErrorMessage = "Please insert title")]
        [Display(Name = "tytuł")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Please insert title")]
        [Display(Name = "opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Dodaj zdjęcie")]
        [Display(Name = "Zdjęcie")]
        public HttpPostedFileBase Image { get; set; }

        //public int ModeratorId { get; set; }
        [Required(ErrorMessage = "Wybierz kategorię")]

        public int? Category { get; set; }
        [Required(ErrorMessage = "Podaj kategorie")]
        [Display(Name = "Płeć")]
        public SelectList SelectCategory { get; set; }

        [Required(ErrorMessage = "Uzupełnij datę urodzenia")]
        [Display(Name = "start eventu")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public CompetitonViewModel()
        {
            SelectCategory = new SelectList(
                new List<SelectListItem>

                {
                    new SelectListItem {Text="Lekkoatletyka",Value="0" },
                    new SelectListItem {Text="Gry_komputerowe",Value="1" },
                    new SelectListItem {Text="SportyDrużynowe",Value="2" },
                    new SelectListItem {Text="SportyZimowe",Value="3" },
                    new SelectListItem {Text="SportyRakietkowe",Value="4" },
                    new SelectListItem {Text="KolarstwoGórskie",Value="5" },
                    
                }, "Value", "Text");
        }
    }
}