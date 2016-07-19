using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstASpNet.Startup))]
namespace MyFirstASpNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
