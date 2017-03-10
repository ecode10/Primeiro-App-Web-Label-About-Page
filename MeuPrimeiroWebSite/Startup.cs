using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeuPrimeiroWebSite.Startup))]
namespace MeuPrimeiroWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
