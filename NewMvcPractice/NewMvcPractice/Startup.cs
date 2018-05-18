using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewMvcPractice.Startup))]
namespace NewMvcPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
