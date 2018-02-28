using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlphaDemo.Startup))]
namespace AlphaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
