using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChurchRater.Startup))]
namespace ChurchRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
