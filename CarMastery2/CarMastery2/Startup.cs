using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarMastery2.Startup))]
namespace CarMastery2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
