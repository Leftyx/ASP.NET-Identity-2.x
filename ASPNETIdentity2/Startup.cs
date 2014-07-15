using System;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.OAuth;

using ASPNETIdentity2.Models;

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
