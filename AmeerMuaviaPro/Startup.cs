using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmeerMuaviaPro.Startup))]
namespace AmeerMuaviaPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
