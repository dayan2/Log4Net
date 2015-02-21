using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_log4net.Startup))]
namespace MVC_log4net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
