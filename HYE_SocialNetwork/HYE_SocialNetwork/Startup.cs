using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HYE_SocialNetwork.Startup))]
namespace HYE_SocialNetwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
