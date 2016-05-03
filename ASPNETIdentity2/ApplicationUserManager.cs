using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace ASPNETIdentity2
{
    using ASPNETIdentity2.Models;

    public class ApplicationUserManager : UserManager<ASPNETIdentity2.Models.MyUser, int>
    {
        public ApplicationUserManager(IUserStore<MyUser, int> store)
            : base(store)
        {

        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new MyUserStore(context.Get<MyContext>()));

            manager.UserValidator = new UserValidator<MyUser, int>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 5,
                RequireNonLetterOrDigit = false,     // true
                // RequireDigit = true,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            return (manager);
        }

    }
}