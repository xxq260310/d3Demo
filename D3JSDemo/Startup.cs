using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D3JSDemo.Startup))]
namespace D3JSDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
