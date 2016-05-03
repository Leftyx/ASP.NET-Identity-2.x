using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPNETIdentity2.Models
{
    public class MyUserStore:  UserStore<MyUser, MyRole, int, MyUserLogin, MyUserRole, MyUserClaim>
    {
        public MyUserStore(MyContext context)
            : base(context)
        {
        }
    }
}