using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignOffProject.DatabaseLayer.Startup))]
namespace SignOffProject.DatabaseLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
