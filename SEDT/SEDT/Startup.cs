using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEDT.Startup))]
namespace SEDT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
