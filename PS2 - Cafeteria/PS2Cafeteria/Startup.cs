using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS2Cafeteria.Startup))]
namespace PS2Cafeteria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
