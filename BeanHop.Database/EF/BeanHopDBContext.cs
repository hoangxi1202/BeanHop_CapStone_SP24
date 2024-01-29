using BeanHop.Database.Extensions;
using BeanHop.Model.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Database.EF
{
    public class BeanHopDBContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaulConnection"),
                b => b.MigrationsAssembly("BeanHop.Database"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BeanProduct>()
                .HasKey(sc => new { sc.BeanID, sc.ProductID });
            modelBuilder.Entity<FavoriteProduct>()
                .HasKey(sc => new { sc.ProductID, sc.FavouriteID });
            modelBuilder.Entity<OrderDetail>()
                .HasKey(sc => new { sc.OrderID, sc.ProductID });
            modelBuilder.Entity<AppUser>()
            .HasOne(u => u.Favourite)
            .WithOne(f => f.Customer)
            .HasForeignKey<Favorite>(f => f.CustomerID);

            modelBuilder.Entity<Order>()
            .HasOne(u => u.Payment)
            .WithOne(f => f.Order)
            .HasForeignKey<Payment>(f => f.OrderID);

            modelBuilder.Entity<Payment>()
            .HasOne(u => u.Transport)
            .WithOne(f => f.Payment)
            .HasForeignKey<Transport>(f => f.PaymentID);

            modelBuilder.Seed();
        }

        public DbSet<AppRole> AppRole { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Bean> Bean { get; set; }
        public DbSet<BeanProduct> BeanProduct { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<FavoriteProduct> FavoriteProduct { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Import> Import { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<RoastLevel> RoastLevel { get; set; }
        public DbSet<Transport> Transport { get; set; }
    }
}

