using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EricWoodsPhotography.UI.MVC.Startup))]
namespace EricWoodsPhotography.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
