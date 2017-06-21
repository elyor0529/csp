using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSP.UI.Startup))]
namespace OSP.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
