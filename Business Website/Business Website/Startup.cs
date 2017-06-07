using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Business_Website.Startup))]
namespace Business_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
