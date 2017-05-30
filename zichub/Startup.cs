using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zichub.Startup))]
namespace zichub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
