using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignOffProject2WebUI.Startup))]
namespace SignOffProject2WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
