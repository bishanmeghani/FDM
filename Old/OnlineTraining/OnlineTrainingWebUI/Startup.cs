using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineTrainingWebUI.Startup))]
namespace OnlineTrainingWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
