using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mollans.Startup))]
namespace Mollans
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
