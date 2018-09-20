using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2ndPracChallenge.Startup))]
namespace _2ndPracChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
