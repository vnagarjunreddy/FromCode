using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitSample.Startup))]
namespace gitSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
