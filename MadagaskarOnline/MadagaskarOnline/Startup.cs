using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadagaskarOnline.Startup))]
namespace MadagaskarOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
