using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todolist_demo.Startup))]
namespace todolist_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
