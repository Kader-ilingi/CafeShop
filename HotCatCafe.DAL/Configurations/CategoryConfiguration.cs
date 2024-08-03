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


            // Properties
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.CategoryName).HasMaxLength(255);

            // HasData: Veritabanında kategori tablosu oluşturulurken varsayılan veriler ekler
            builder.HasData(
                new Category { ID = 1, CategoryName = "Coffees", Description = "Various types of coffee." },
                new Category { ID = 2, CategoryName = "Desserts", Description = "Sweet treats and desserts." },
                new Category { ID = 3, CategoryName = "Teas", Description = "Different types of tea." },
                new Category { ID = 4, CategoryName = "Sandwiches", Description = "Assorted sandwiches." },
                new Category { ID = 5, CategoryName = "Salads", Description = "Fresh and healthy salads." },
                new Category { ID = 6, CategoryName = "Snacks", Description = "Light snacks and nibbles." },
                new Category { ID = 7, CategoryName = "Fruit Juices", Description = "Refreshing fruit juices." },
                new Category { ID = 8, CategoryName = "Cakes", Description = "Varieties of cakes." },
                new Category { ID = 9, CategoryName = "Ice Creams", Description = "Various ice cream flavors." },
                new Category { ID = 10, CategoryName = "Chocolates", Description = "Different types of chocolates." }
            );
        }


        //private List<Category> SeedCategoryData()
        //{
        //    var faker = new Faker("en");

        //    // fake category data
        //    var categories = new List<Category>();
        //    string[] categorieNames = new string[]
        //    {
        //        "Coffees",
        //        "Desserts",
        //        "Teas",
        //        "Sandwiches",
        //        "Salads",
        //        "Snacks",
        //        "Fruit Juices",
        //        "Cakes",
        //        "Ice Creams",
        //        "Chocolates"
        //    };
    

        //    for (int i = 1; i <=15; i++)
        //    {
                
        //        Category category = new Category
        //        {
        //            ID = i,
        //            CategoryName = faker.PickRandom(categorieNames),
        //            Description = faker.Lorem.Sentence()
        //        };

        //        categories.Add(category);
        //    }
        //    return categories;
        //}

    }
}
