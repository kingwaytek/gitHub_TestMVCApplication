using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitHub_TestMVCApplication.Startup))]
namespace gitHub_TestMVCApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
