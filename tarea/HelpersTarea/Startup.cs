using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelpersTarea.Startup))]
namespace HelpersTarea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
