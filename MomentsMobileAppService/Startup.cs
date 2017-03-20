using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MomentsMobileAppService.Startup))]

namespace MomentsMobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}