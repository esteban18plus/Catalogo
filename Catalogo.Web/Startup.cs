using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Catalogo.Web.Startup))]
namespace Catalogo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
