using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace RenameTables
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new MyContext())
            {
                var myUser = new IdentityUser
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

                var myClaim = new IdentityUserClaim
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
                    throw new Exception("some reason to rethrow", ex);
                }

                Console.WriteLine("Finished!");
                Console.ReadLine();
            }

        }
    }
}
