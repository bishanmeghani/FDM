using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CitySearch.WebUI.Startup))]
namespace CitySearch.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
