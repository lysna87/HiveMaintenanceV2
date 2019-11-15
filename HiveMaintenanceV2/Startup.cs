using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiveMaintenanceV2.Startup))]
namespace HiveMaintenanceV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
