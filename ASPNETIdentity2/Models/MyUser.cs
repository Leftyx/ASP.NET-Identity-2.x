using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPNETIdentity2.Models
{
    public class MyUser : IdentityUser<int, MyUserLogin, MyUserRole, MyUserClaim>
    {
        public string CompanyName { get; set; }
    }
}