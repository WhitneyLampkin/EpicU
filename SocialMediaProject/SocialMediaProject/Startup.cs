using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialMediaProject.Startup))]
namespace SocialMediaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
