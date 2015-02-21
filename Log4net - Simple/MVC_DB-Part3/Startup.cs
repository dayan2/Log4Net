using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_DB_Part3.Startup))]
namespace MVC_DB_Part3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
