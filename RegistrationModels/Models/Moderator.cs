using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompetitionRegistration.Models
{

    public class Moderator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public eCategory Specialization { get; set; }

    }
}