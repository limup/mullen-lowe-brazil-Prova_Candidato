using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleTestBootstrap.Startup))]
namespace ExampleTestBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
