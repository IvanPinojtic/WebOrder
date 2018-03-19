using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebOrder.Startup))]
namespace WebOrder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
