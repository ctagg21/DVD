using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car_Mastery.Startup))]
namespace Car_Mastery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
