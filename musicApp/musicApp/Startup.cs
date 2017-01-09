using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(musicApp.Startup))]
namespace musicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
