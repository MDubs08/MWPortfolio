using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MWPortfolio.Startup))]
namespace MWPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
