using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;

namespace HotCatCafe.DAL.Configurations
{
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ShippingAddress)
               .IsRequired()
               .HasMaxLength(100);
            builder.Property(s => s.ShippingDate)
               .IsRequired();
            builder.Property(s => s.OrderId)
               .IsRequired();
            //builder.HasOne(s => s.Order)
            //   .WithOne(o => o.Shipment)
            //   .HasForeignKey<Shipment>(s => s.OrderId)
            //   .OnDelete(DeleteBehavior.Cascade);  // Sipariş silinirse gönderimi de sil
            builder.HasData(SeedShipmentData());
        }

        private List<Shipment> SeedShipmentData()
            {
                List<Shipment> shipments = new List<Shipment>();
                shipments.Add(new Shipment
                {
                    ID = 1,
                    ShippingAddress = "123 Elm St, Springfield, IL",
                    ShippingDate = DateTime.Now.AddDays(1),
                    OrderId = 1, // Örnek OrderId değeri
                });
                shipments.Add(new Shipment
                {
                    ID = 2,
                    ShippingAddress = "1235 Elm St, Springfield, IL",
                    ShippingDate = DateTime.Now.AddDays(1),
                    OrderId = 2, // Örnek OrderId değeri
                });
                return shipments;

            }
    }
}
