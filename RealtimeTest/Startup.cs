using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealtimeTest.Startup))]
namespace RealtimeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
