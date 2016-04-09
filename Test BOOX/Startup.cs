using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_BOOX.Startup))]
namespace Test_BOOX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
