using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iRR.Startup))]
namespace iRR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
