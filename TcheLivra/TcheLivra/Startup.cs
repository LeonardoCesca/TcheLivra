using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TcheLivra.Startup))]
namespace TcheLivra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
