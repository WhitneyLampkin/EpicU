using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LimitedKicksStore.Startup))]
namespace LimitedKicksStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
