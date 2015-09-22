using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LarryTasks.Startup))]
namespace LarryTasks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
