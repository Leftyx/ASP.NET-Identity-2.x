namespace ASPNETIdentity2.Migrations
{
    using ASPNETIdentity2.Models;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNETIdentity2.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ASPNETIdentity2.Models.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var myAppUser = new MyUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "john",
                PasswordHash = new PasswordHasher().HashPassword("john"),
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "john@xyz.com",
                EmailConfirmed = true,
                PhoneNumber = "XXX-XXX-XXXX",
                PhoneNumberConfirmed = false
            };

            try
            {
                context.Users.AddOrUpdate(user => user.UserName, myAppUser);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
