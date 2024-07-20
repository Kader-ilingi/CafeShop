

using Bogus;
using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Primary key
            builder.HasKey(x => x.ID);

            // Relationships
            //builder.HasOne(o => o.AppUser)
            //       .WithMany(u => u.Orders)
            //       .HasForeignKey(o => o.AppUserId)
            //       .IsRequired()
            //       .OnDelete(DeleteBehavior.Restrict); // Kullanıcı silinirse siparişi silme

            

            // OrderDate alanı için varsayılan değer ve adını belirleme
            builder.Property(o => o.OrderDate)
                   .HasColumnName("OrderDate")
                   .HasDefaultValueSql("GETDATE()");

            // TotalAmount alanı için gereksinimler
            builder.Property(o => o.TotalAmount)
                   .HasColumnType("decimal(18,2)")  // Decimal alan türü ve hassasiyeti
                   .IsRequired();  // Zorunlu alan

            // Status alanı için gereksinimler
            builder.Property(o => o.Status)
                   .IsRequired()
                   .HasMaxLength(50);  // Durumun maksimum uzunluğu


           

            //builder.HasMany(o => o.OrderDetails)
            //       .WithOne(od => od.Order)
            //       .HasForeignKey(od => od.OrderId)
            //       .OnDelete(DeleteBehavior.Cascade);  // Sipariş silinirse detayları da sil

            //builder.HasMany(o => o.Payments)
            //       .WithOne(p => p.Order)
            //       .HasForeignKey(p => p.OrderId)
            //       .OnDelete(DeleteBehavior.Cascade);  // Sipariş silinirse ödemeleri de sil

            
            //builder.HasOne(o => o.Shipment)
            //       .WithOne(s => s.Order)
            //       .HasForeignKey<Shipment>(s => s.OrderId)
            //       .OnDelete(DeleteBehavior.Cascade);  // Sipariş silinirse gönderimi de sil

            // HasData ile başlangıç verilerini eklemek
            builder.HasData(
                new Order
                {
                    ID = 1,
                    OrderDate = DateTime.Now,
                    TotalAmount = 100.00m,
                    Status = OrderStatus.Pending,
                    //AppUserId = Guid.NewGuid(), // Buraya gerçek bir kullanıcı ID'si eklenecek
                    //DiscountId = 12, // İndirim yoksa null
                }
            );































            // AppUser ile ilişkiyi tanımlama
            //builder.HasOne(o => o.AppUser)
            //       .WithMany(u => u.Orders)
            //       .HasForeignKey(o => o.AppUserId)
            //       .OnDelete(DeleteBehavior.Restrict); // Kullanıcı silindiğinde bu siparişleri silme.

            ////
            //// Payments ile ilişkiyi tanımlama
            //builder.HasMany(o => o.Payments)
            //       .WithOne(p => p.Order)
            //       .HasForeignKey(p => p.OrderId)
            //       .OnDelete(DeleteBehavior.Cascade); // Sipariş silindiğinde ilişkili ödemeleri de sil


            //// Order ile OrderDetails arasında birçok ilişki olabilir
            //builder.HasMany(o => o.OrderDetails)
            //       .WithOne(od => od.Order)
            //       .HasForeignKey(od => od.OrderId);

            // HasData kullanarak sahte verileri yükleme
            //builder.HasData(SeedOrderData());
            //}
            //private List<Order> SeedOrderData()
            //{
            //    var faker = new Faker("en");
            //    var orders = new List<Order>();
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        var order = new Order
            //        {
            //            ID = i,
            //            OrderDate = faker.Date.Past(),//geçen 1 yıla kadar olan sipariş tarihini getirir
            //            TotalAmount = decimal.Parse(faker.Commerce.Price()),
            //            Status = faker.Random.Enum<OrderStatus>(),

            //            // Diğer özellikler burada tanımlanabilir
            //        };

            //        orders.Add(order);
            //    }

            //    return orders;
        }
    }
}
