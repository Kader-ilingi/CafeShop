using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.ID); // Primary key olarak ID alanını belirledik

            builder.Property(r => r.Rating)
                .IsRequired(false); // Rating alanı zorunlu

            builder.Property(r => r.Comment)
                .HasMaxLength(500); // Comment alanının maksimum uzunluğu belirlendi

            builder.Property(r => r.ReviewDate)
                .IsRequired(false)
                .HasColumnType("datetime2"); // ReviewDate alanı zorunlu değil ve veri tipi belirlendi

            // Review ile Product arasında N-1 ilişkisi
            builder.HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Product silinince Review'lerin silinmemesi için Restrict

            // Review ile AppUser arasında N-1 ilişkisi
            builder.HasOne(r => r.AppUser)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.AppUserId)
                .OnDelete(DeleteBehavior.Restrict); // AppUser silinince Review'lerin silinmemesi için Restrict

        }
    }
}
