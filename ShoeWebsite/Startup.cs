using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoeWebsite.Startup))]
namespace ShoeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
