using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace MvcPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
