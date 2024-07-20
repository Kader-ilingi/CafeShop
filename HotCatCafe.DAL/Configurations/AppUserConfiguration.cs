using Bogus;
using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            //builder.HasMany(u => u.Orders)
            //   .WithOne(o => o.AppUser)
            //   .HasForeignKey(o => o.AppUserId)
            //   .IsRequired()
            //   .OnDelete(DeleteBehavior.Restrict); // Kullanıcı silinirse siparişi silme

            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.BirthDate).IsRequired(false);
            builder.HasKey(u => u.Id); // AppUser'ın anahtarını Guid olarak belirt
            builder.HasMany(u => u.Reviews) // Bir AppUser'ın birden çok Review'i olabilir
                   .WithOne(r => r.AppUser) // Bir Review'ın bir AppUser'a ait olması gerekiyor
                   .HasForeignKey(r => r.AppUserId) // Foreign key'i AppUserId olarak belirt (int türünde)
                   .IsRequired(); // Zorunlu ilişki olduğunu belirt




            // Seed data using HasData method
            builder.HasData(SeedAppUserData());
        }

        public List<AppUser> SeedAppUserData()
        {
            var faker = new Faker("en");// datalar ingilizce adı ile oluşturulacak
            var Users = new List<AppUser>();

            for (int i = 0; i <= 15; i++)
            {
                AppUser user = new AppUser()
                {
                    Id=faker.Random.Guid(),
                    BirthDate=faker.Date.Past(30, DateTime.Now.AddYears(-18)),//18 yaşından büyük olmalı
                    UserName =faker.Internet.UserName(),
                    Email=faker.Internet.Email(faker.Internet.UserName()).ToLower(),
                    PasswordHash=faker.Internet.Password(8),
                    Address=faker.Address.FullAddress(),
                    Gender=faker.PickRandom<Gender>(),
                    PhoneNumber=faker.Phone.PhoneNumber(),
                    
                };
                Users.Add(user);
            };
            return Users;
        }
    }
}
