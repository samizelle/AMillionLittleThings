using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMillionLittleThings.Startup))]
namespace AMillionLittleThings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
