using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.Models
{
    public enum eCategory
    {
        Athletic,
        TeamGame,
        ChildrenPlays,
        IndividualGame


    }
    public class Competition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public eCategory Category { get; set; }
        public DateTime StartDate { get; set; }

    }
}