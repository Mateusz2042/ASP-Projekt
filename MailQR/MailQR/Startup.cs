using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.SqlServer;
using MailQR.Database;

[assembly: OwinStartup(typeof(MailQR.Startup))]

namespace MailQR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            MailerDbContext db = new MailerDbContext();
            
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(
                    "MailerDbContext",
                    new SqlServerStorageOptions { QueuePollInterval = TimeSpan.FromSeconds(1) });

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
