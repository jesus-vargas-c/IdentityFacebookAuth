using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityFacebookAuth.Startup))]
namespace IdentityFacebookAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
