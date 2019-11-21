using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuelInfo.Startup))]
namespace FuelInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
