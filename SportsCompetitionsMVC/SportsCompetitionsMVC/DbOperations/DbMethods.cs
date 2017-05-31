using SportsCompetitions.Enums;
using SportsCompetitions.Models;
using SportsCompetitionsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsCompetitionsMVC.DbOperations
{
    public static class DbMethods
    {
        public static void RegisterUser(ApplicationUser model)
        {
            ApplicationUser _dbUser;

           

            using (var db = new ApplicationDbContext())
            {
                _dbUser = db.Users.Where(x => x.UserName == model.UserName).FirstOrDefault();
                _dbUser.Informations = new Informations();
                _dbUser.Informations = model.Informations;
                //_dbUser.Informations.FirstName = model.Informations.FirstName;
                //_dbUser.Informations.BirthDate = model.Informations.BirthDate;
                //_dbUser.Informations.LastName = model.Informations.LastName;
                //_dbUser.Informations.Avatar = model.Informations.a
                //_dbUser.Informations.Sex = (Enums.eSex)model.Sex;
                db.SaveChanges();
            }
        }
    }
}