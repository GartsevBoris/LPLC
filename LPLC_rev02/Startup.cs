using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LPLC_rev02.Startup))]
namespace LPLC_rev02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
