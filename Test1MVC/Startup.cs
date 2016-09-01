using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test1MVC.Startup))]
namespace Test1MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
