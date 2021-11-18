using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsommiTounsiFront.Startup))]
namespace ConsommiTounsiFront
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
