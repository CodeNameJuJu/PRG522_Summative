using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522Summative.Startup))]
namespace PRG522Summative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
