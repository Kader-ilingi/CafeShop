using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;

namespace HotCatCafe.DAL.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.OrderId);
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(od => od.UnitPrice)
            .HasColumnType("decimal(18,2)"); // UnitPrice alanı için veri tipi ve uzunluk belirlendi

            builder.Property(od => od.Discount)
            .HasColumnType("float"); // Discount alanı için veri tipi belirlendi

            // OrderDetail ile Order arasında 1-N ilişkisi
            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade ile Order silindiğinde OrderDetail'lar da silinir

            //OrderDetail ile Product arasında 1 - N ilişkisi
            builder.HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict ile Product silindiğinde OrderDetail'lar silinmez
            

          
        }
    }
}
