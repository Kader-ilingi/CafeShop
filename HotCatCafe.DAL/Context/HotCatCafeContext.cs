using HotCatCafe.DAL.Configurations;
using HotCatCafe.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Runtime.CompilerServices;

namespace HotCatCafe.DAL.Context
{
    public class HotCatCafeContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {
        public HotCatCafeContext(DbContextOptions<HotCatCafeContext> options):base(options) { }
        

        //DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=LAPTOP-7RVI861P\\SQLEXPRESS;Database=HotCatCafeDb;Trusted_Connection=True;TrustServerCertificate=True;");

        //        base.OnConfiguring(optionsBuilder);
        //    }

        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CategoryConfiguration
            builder.ApplyConfiguration(new CategoryConfiguration());

            //ProductConfiguration
            builder.ApplyConfiguration(new ProductConfiguration());

            //AppUserConfiguration
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            //builder.ApplyConfiguration(new OrderDetailConfiguration());
            //builder.ApplyConfiguration(new PaymentConfiguration());
            //builder.ApplyConfiguration(new  ReviewConfiguration());
            //builder.ApplyConfiguration(new DiscountConfiguration());
            //builder.ApplyConfiguration(new ShipmentConfiguration());



            base.OnModelCreating(builder);
        }

        
    }
}
