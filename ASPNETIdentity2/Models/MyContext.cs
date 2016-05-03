﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ASPNETIdentity2.Models
{
    public class MyContext : IdentityDbContext<MyUser, MyRole, int, MyUserLogin, MyUserRole, MyUserClaim>
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
                .Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<MyRole>()
                .Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<MyUserRole>()
                .Property(p => p.RoleId)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<MyUserRole>()
                .Property(p => p.UserId)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<MyUserClaim>()
                .Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<MyUserClaim>()
                .Property(p => p.UserId)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<MyUserLogin>()
                .Property(p => p.UserId)
                .HasColumnType("int")
                .IsRequired();

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