using ASPNETIdentity2.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETIdentity2
{
    public class MyUserStore: UserStore<MyUser, MyRole, string, MyUserLogin, MyUserRole, MyUserClaim>
    {
        public MyUserStore(MyContext context)
            : base(context)
        {
        }
    }
}