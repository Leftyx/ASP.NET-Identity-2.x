namespace RenameTables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    class Program
    {
        static void Main(string[] args)
        {

            var db = new MyContext();

            var myUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "frank",
                PasswordHash = new PasswordHasher().HashPassword("john"),
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "frank@xyz.com",
                EmailConfirmed = true,
                PhoneNumber = "XXX-XXX-XXXX",
                PhoneNumberConfirmed = false
            };

            var myClaim = new IdentityUserClaim()
            {
                Id = 1,
                ClaimType = "Roles",
                ClaimValue = "Guests",
                UserId = myUser.Id
            };

            myUser.Claims.Add(myClaim);

            try
            {
                db.Users.Add(myUser);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            Console.WriteLine("Finished!");
            Console.ReadLine();

        }
    }
}
