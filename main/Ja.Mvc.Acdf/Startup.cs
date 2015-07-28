using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ja.Mvc.Acdf.Startup))]
namespace Ja.Mvc.Acdf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
