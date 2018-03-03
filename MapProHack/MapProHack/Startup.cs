using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapProHack.Startup))]
namespace MapProHack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
