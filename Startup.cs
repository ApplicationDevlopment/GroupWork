using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCWApplicationDev.Startup))]
namespace GCWApplicationDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
