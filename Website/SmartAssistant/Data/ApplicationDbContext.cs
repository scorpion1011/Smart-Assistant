using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartAssistant.Models;

namespace SmartAssistant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Thing> Things { get; set; }
        public DbSet<CustomerList> CustomerLists { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<UsersThings> UsersThings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ThingAtShop>()
                .HasKey(bc => new { bc.idShop, bc.idThing });
            modelBuilder.Entity<ThingAtShop>()
                .HasOne(bc => bc.shop)
                .WithMany(b => b.thingsAtShop)
                .HasForeignKey(bc => bc.idShop);
            modelBuilder.Entity<ThingAtShop>()
                .HasOne(bc => bc.thing)
                .WithMany(c => c.thingsAtShop)
                .HasForeignKey(bc => bc.idThing);
        }
    }
}
