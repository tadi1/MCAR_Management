using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicCityAnimalRescueManagement.Startup))]
namespace MusicCityAnimalRescueManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
