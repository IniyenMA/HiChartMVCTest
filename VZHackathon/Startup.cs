using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VZHackathon.Startup))]
namespace VZHackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
