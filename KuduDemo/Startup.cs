using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KuduDemo.Startup))]
namespace KuduDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
