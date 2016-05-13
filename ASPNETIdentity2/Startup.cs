using ASPNETIdentity2.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ASPNETIdentity2.Startup))]

namespace ASPNETIdentity2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(MyContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
        }
    }
}
