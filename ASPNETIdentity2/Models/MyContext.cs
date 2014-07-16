namespace ASPNETIdentity2.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public class MyContext : IdentityDbContext<MyUser, MyRole, string, MyUserLogin, MyUserRole, MyUserClaim>
    {
        public MyContext(): base("OwinWebApiSecurity")
        {

        }

        public static MyContext Create()
        {
            return new MyContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyUser>()
                .ToTable("Users");

            modelBuilder.Entity<MyRole>()
                .ToTable("Roles");

            modelBuilder.Entity<MyUserRole>()
                .ToTable("UserRoles");

            modelBuilder.Entity<MyUserClaim>()
                .ToTable("UserClaims");

            modelBuilder.Entity<MyUserLogin>()
                .ToTable("UserLogins");
        }
    }
}