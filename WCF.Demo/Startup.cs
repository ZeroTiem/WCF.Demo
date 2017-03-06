using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCF.Demo.Startup))]
namespace WCF.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
