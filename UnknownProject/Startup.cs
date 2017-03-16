using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnknownProject.Startup))]
namespace UnknownProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
