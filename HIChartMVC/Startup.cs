using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HIChartMVC.Startup))]
namespace HIChartMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
