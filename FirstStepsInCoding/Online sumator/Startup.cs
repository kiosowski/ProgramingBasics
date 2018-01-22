using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_sumator.Startup))]
namespace Online_sumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
