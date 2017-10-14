using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleAuthDemo.Website.Startup))]
namespace GoogleAuthDemo.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
