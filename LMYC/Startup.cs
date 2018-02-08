using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMYC.Startup))]
namespace LMYC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
