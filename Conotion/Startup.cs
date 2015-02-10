using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conotion.Startup))]
namespace Conotion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
