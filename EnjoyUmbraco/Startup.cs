using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnjoyUmbraco.Startup))]
namespace EnjoyUmbraco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
