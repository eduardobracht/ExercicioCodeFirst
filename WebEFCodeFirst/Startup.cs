using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebEFCodeFirst.Startup))]
namespace WebEFCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
