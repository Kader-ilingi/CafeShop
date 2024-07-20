using Bogus;
using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {

            // Primary key
            builder.HasKey(p => p.ID);

            // Property configurations
            builder.Property(p => p.PaymentDate).IsRequired();
            builder.Property(p => p.Amount).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.PaymentMethod).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Status).IsRequired();

            //// Relationships
            //builder.HasOne(p => p.Order)
            //       .WithMany(o => o.Payments)
            //       .HasForeignKey(p => p.OrderId)
            //       .OnDelete(DeleteBehavior.Cascade); // Sipariş silinirse ödemeleri de sil


            // Örnek verilerin eklenmesi (opsiyonel)
            builder.HasData(SeedPaymentData());


        }

        private List<Payment> SeedPaymentData()
        {
            var faker = new Faker("en");
            var payments = new List<Payment>();

            for (int i = 1; i <= 10; i++)
            {
                var payment = new Payment
                {
                    ID = i,
                    Amount = decimal.Parse(faker.Commerce.Price()),
                    PaymentDate = faker.Date.Past(),
                    PaymentMethod = faker.Finance.CreditCardNumber(),
                    Status = faker.PickRandom<PaymentStatus>(), // Rastgele PaymentStatus seçimi
                    //OrderId = faker.Random.Int(1, 20) // Örnek olarak 1-20 arası rastgele sipariş id'si
                };

                payments.Add(payment);
            }

            return payments;
        }
    }
}
