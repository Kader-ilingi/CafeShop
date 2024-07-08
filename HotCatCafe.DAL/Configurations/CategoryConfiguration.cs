using Bogus;
using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Properties
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.CategoryName).HasMaxLength(255);


            //HasData: veritabanında category tablosu oluşturulurken beraberinde varsayılan datalar ile birlikte oluşturulmasını sağlar.
            builder.HasData(SeedCategoryData());


        }
        private List<Category> SeedCategoryData()
        {
            var faker = new Faker("en");

            // fake category data
            var categories = new List<Category>();
            string[] categorieNames = new string[]
            {
                "Coffees",
                "Desserts",
                "Teas",
                "Sandwiches",
                "Salads",
                "Snacks",
                "Fruit Juices",
                "Cakes",
                "Ice Creams",
                "Chocolates"
            };
    

            for (int i = 1; i <=15; i++)
            {
                
                Category category = new Category
                {
                    ID = i,
                    CategoryName = faker.PickRandom(categorieNames),
                    Description = faker.Lorem.Sentence()
                };

                categories.Add(category);
            }
            return categories;
        }

    }
}
