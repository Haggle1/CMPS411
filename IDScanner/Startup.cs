using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDScanner.Startup))]
namespace IDScanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
