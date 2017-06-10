using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SportsCompetitionsMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsCompetitions.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<SingleCompetition> SingleCompetition { get; set; }
        public DbSet<TeamCompetition> TeamCompetition { get; set; }
        public DbSet<Informations> Informations { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            //Database.SetInitializer(new ApplicationDbInitializer());
        }

        public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                base.Seed(context);
                InitDatabase(context);
            }

            public void InitDatabase(ApplicationDbContext context)
            {
                //var roleManager
                //    = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(
                //        new RoleStore<IdentityRole>(new ApplicationDbContext()));

                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                UserManager<ApplicationUser> manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                var user = new ApplicationUser
                {
                    Email = "pplowucha2@gmail.com",
                    UserName = "admin",
                    ConfirmedEmail = true
                };
                manager.Create(user, "pawelp");


                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();

                role.Name = "User";
                roleManager.CreateAsync(role);
                role.Name = "Admin";
                roleManager.CreateAsync(role);
                role.Name = "Moderator";
                roleManager.CreateAsync(role);

                manager.AddToRole(user.Id, "Admin");


                //var user = new ApplicationUser() { UserName = "admin" };
                //user.Email = "pplowucha2@gmail.com";
                //user.ConfirmedEmail = true;



                //var roleresult = UserManager.AddToRole(user.Id, "User");



                //var result = await UserManager.CreateAsync(user, "pawelp");


            }
        }
    }

}