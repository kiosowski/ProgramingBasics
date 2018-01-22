using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FruitsWebGame.Startup))]
namespace FruitsWebGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
