using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoSQLSERVER.Startup))]
namespace DemoSQLSERVER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
