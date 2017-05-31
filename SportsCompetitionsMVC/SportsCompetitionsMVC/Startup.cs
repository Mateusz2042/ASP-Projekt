using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsCompetitionsMVC.Startup))]
namespace SportsCompetitionsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
