using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Draft.Startup))]
namespace Draft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
