using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(goAirport.Startup))]
namespace goAirport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
