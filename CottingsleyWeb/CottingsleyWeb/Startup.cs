using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CottingsleyWeb.Startup))]
namespace CottingsleyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
