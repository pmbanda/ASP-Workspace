using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KOKC_Web_Application.Startup))]
namespace KOKC_Web_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
