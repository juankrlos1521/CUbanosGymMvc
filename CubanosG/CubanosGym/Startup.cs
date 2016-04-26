using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CubanosGym.Startup))]
namespace CubanosGym
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
