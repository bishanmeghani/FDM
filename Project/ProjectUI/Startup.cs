using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectUI.Startup))]
namespace ProjectUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
