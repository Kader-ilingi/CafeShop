using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(d => d.ID);

            // DiscountType alanı için enum dönüşümü kullanıldı
            builder.Property(d => d.DiscountType)
                .IsRequired()
                .HasConversion<string>();

            // örnek data ekleme
            builder.HasData(
                new Discount { ID = 1, DiscountCode = "DISC10", DiscountType = DiscountType.Percentage, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), MinimumAmount = 100.00m },
                new Discount { ID = 2, DiscountCode = "FIXED20", DiscountType = DiscountType.FixedAmount, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2), MinimumAmount = 200.00m }
            // Diğer örnek veriler buraya eklenebilir
            );
        }
    }
}
