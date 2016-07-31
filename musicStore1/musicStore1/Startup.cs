using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(musicStore1.Startup))]
namespace musicStore1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
