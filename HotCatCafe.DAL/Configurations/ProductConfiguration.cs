using Bogus;
using Bogus.DataSets;
using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;

namespace HotCatCafe.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //bir categorinin n tane ürünü olabilir ->
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            //Properties
            builder.Property(x => x.ProductName).IsRequired(true);
            builder.Property(x => x.ProductName).HasMaxLength(255);
            builder.Property(x => x.ImagePath).IsRequired(false);

            //HasData
            builder.HasData(SeedProductData());
        }

        public List<Product> SeedProductData()
        {
            var faker = new Faker("en");// datalar ingilizce adı ile oluşturulacak
            var products = new List<Product>();


            string[] coffeeNames = new string[]
       {
            "Espresso",
            "Latte",
            "Cappuccino",
            "Macchiato",
            "Mocha",
            "Americano",
            "Flat White",
            "Affogato",
            "Cold Brew",
            "Turkish Coffee",
            "Iced Coffee",
            "Frappé",
            "Coffee Milkshake",
            "Coffee Soda",
            "Coffee Martini",
            "Cold Brew"
        };

            string[] dessertNames = new string[]
        {
            "Cake",
            "Cupcake",
            "Brownie",
            "Cookie",
            "Donut",
            "Cheesecake",
            "Pudding",
            "Tart",
            "Macaron",
            "Pie",
            "Ice Cream",
            "Muffin",
            "Waffle",
            "Pancake",
            "Fruit Salad",
            "Tiramisu",
            "Brownie",
            "Macaron",
            "Panna Cotta",
            "Éclair",
            "Trifle",
            "Profiterole",
            "Chocolate Fondue"
        };

            for (int i = 1; i <= 20; i++)
            {
                string productName = faker.PickRandom(coffeeNames);
                if (faker.Random.Bool())
                {
                    productName = faker.PickRandom(dessertNames);
                }
                Product product = new Product
                {
                    ID = i,
                    ProductName =faker.PickRandom(productName),
                    Price = decimal.Parse(faker.Commerce.Price()),
                    Stock = faker.Random.Short(0, 100),
                    ImagePath = faker.Image.PicsumUrl(),//Lorem PicsumURL den bize fake ımagepathler oluşturacaktır.
                    Discount = Math.Round(faker.Random.Double(0, 0.5), 2),
                    CategoryId = faker.Random.Number(1, 10)
                };

                products.Add(product);
            }
            return products;
        }
    }
}
