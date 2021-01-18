using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wingtip_Toys.Startup))]
namespace Wingtip_Toys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
     //       ConfigureAuth(app);
        }
    }
}
