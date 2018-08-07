using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eivom.Startup))]
namespace Eivom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
