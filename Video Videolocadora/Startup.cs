using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Video_Videolocadora.Startup))]
namespace Video_Videolocadora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
