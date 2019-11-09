using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectDB.Startup))]
namespace ConnectDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
