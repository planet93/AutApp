using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutApp.Startup))]
namespace AutApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
