using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyRazorPage.Startup))]
namespace VidlyRazorPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
