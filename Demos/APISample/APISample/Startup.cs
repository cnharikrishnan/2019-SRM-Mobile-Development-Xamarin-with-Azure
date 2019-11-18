using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(APISample.Startup))]

namespace APISample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}