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
            //bir categorinin n tane ürünü olabilir ->//  // // Category ile ilişkileri tanımlar
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            // Properties
            builder.Property(x => x.ProductName).IsRequired(true);
            builder.Property(x => x.ProductName).HasMaxLength(255);
            builder.Property(x => x.ImagePath).IsRequired(false);

            // HasData: Veritabanında ürün tablosu oluşturulurken varsayılan veriler ekler
            builder.HasData(
                // Coffees
                new Product { ID = 1, ProductName = "Espresso", Price = 2.49m, Stock = 50, ImagePath = "espresso.jpg", Discount = 0.1m, CategoryId = 1 },
                new Product { ID = 2, ProductName = "Latte", Price = 3.49m, Stock = 30, ImagePath = "latte.jpg", Discount = 0.15m, CategoryId = 1 },

                // Desserts
                new Product { ID = 3, ProductName = "Cheesecake", Price = 4.99m, Stock = 20, ImagePath = "cheesecake.jpg", Discount = 0.2m, CategoryId = 2 },
                new Product { ID = 4, ProductName = "Brownie", Price = 3.99m, Stock = 25, ImagePath = "brownie.jpg", Discount = 0.1m, CategoryId = 2 },

                // Teas
                new Product { ID = 5, ProductName = "Green Tea", Price = 2.99m, Stock = 40, ImagePath = "greentea.jpg", Discount = 0.05m, CategoryId = 3 },
                new Product { ID = 6, ProductName = "Black Tea", Price = 2.49m, Stock = 45, ImagePath = "blacktea.jpg", Discount = 0.1m, CategoryId = 3 },

                // Sandwiches
                new Product { ID = 7, ProductName = "Turkey Sandwich", Price = 5.49m, Stock = 35, ImagePath = "turkeysandwich.jpg", Discount = 0.1m, CategoryId = 4 },
                new Product { ID = 8, ProductName = "Veggie Sandwich", Price = 4.99m, Stock = 50, ImagePath = "veggiesandwich.jpg", Discount = 0.2m, CategoryId = 4 },

                // Salads
                new Product { ID = 9, ProductName = "Caesar Salad", Price = 6.99m, Stock = 15, ImagePath = "caesarsalad.jpg", Discount = 0.15m, CategoryId = 5 },
                new Product { ID = 10, ProductName = "Greek Salad", Price = 5.99m, Stock = 20, ImagePath = "greeksalad.jpg", Discount = 0.1m, CategoryId = 5 },

                // Snacks
                new Product { ID = 11, ProductName = "Chips", Price = 1.99m, Stock = 60, ImagePath = "chips.jpg", Discount = 0.05m, CategoryId = 6 },
                new Product { ID = 12, ProductName = "Pretzels", Price = 2.49m, Stock = 70, ImagePath = "pretzels.jpg", Discount =  0.1m, CategoryId = 6 },

                // Fruit Juices
                new Product { ID = 13, ProductName = "Orange Juice", Price = 3.29m, Stock = 50, ImagePath = "orangejuice.jpg", Discount = 0.1m, CategoryId = 7 },
                new Product { ID = 14, ProductName = "Apple Juice", Price = 2.99m, Stock = 45, ImagePath = "applejuice.jpg", Discount = 0.05m, CategoryId = 7 },

                // Cakes
                new Product { ID = 15, ProductName = "Chocolate Cake", Price = 6.49m, Stock = 10, ImagePath = "chocolatecake.jpg", Discount = 0.2m, CategoryId = 8 },
                new Product { ID = 16, ProductName = "Vanilla Cake", Price = 5.99m, Stock = 15, ImagePath = "vanillacake.jpg", Discount = 0.15m, CategoryId = 8 },

                // Ice Creams
                new Product { ID = 17, ProductName = "Vanilla Ice Cream", Price = 4.49m, Stock = 25, ImagePath = "vanillaicecream.jpg", Discount = 0.1m, CategoryId = 9 },
                new Product { ID = 18, ProductName = "Chocolate Ice Cream", Price = 4.99m, Stock = 20, ImagePath = "chocolateicecream.jpg", Discount =  0.1m, CategoryId = 9 },

                // Chocolates
                new Product { ID = 19, ProductName = "Dark Chocolate", Price = 2.99m, Stock = 30, ImagePath = "darkchocolate.jpg", Discount = 0.05m, CategoryId = 10 },
                new Product { ID = 20, ProductName = "Milk Chocolate", Price = 2.49m, Stock = 40, ImagePath = "milkchocolate.jpg", Discount = 0.1m, CategoryId = 10 }
            );

        }

       // public List<Product> SeedProductData()
       // {
       //     var faker = new Faker("en");// datalar ingilizce adı ile oluşturulacak
       //     var products = new List<Product>();


       //     string[] coffeeNames = new string[]
       //{
       //     "Espresso",
       //     "Latte",
       //     "Cappuccino",
       //     "Macchiato",
       //     "Mocha",
       //     "Americano",
       //     "Flat White",
       //     "Affogato",
       //     "Cold Brew",
       //     "Turkish Coffee",
       //     "Iced Coffee",
       //     "Frappé",
       //     "Coffee Milkshake",
       //     "Coffee Soda",
       //     "Coffee Martini",
       //     "Cold Brew"
       // };

       //     string[] dessertNames = new string[]
       // {
       //     "Cake",
       //     "Cupcake",
       //     "Brownie",
       //     "Cookie",
       //     "Donut",
       //     "Cheesecake",
       //     "Pudding",
       //     "Tart",
       //     "Macaron",
       //     "Pie",
       //     "Ice Cream",
       //     "Muffin",
       //     "Waffle",
       //     "Pancake",
       //     "Fruit Salad",
       //     "Tiramisu",
       //     "Brownie",
       //     "Macaron",
       //     "Panna Cotta",
       //     "Éclair",
       //     "Trifle",
       //     "Profiterole",
       //     "Chocolate Fondue"
       // };

       //     for (int i = 1; i <= 20; i++)
       //     {
       //         string productName = faker.PickRandom(coffeeNames);
       //         if (faker.Random.Bool())
       //         {
       //             productName = faker.PickRandom(dessertNames);
       //         }
       //         Product product = new Product
       //         {
       //             ID = i,
       //             ProductName =faker.PickRandom(productName),
       //             Price = decimal.Parse(faker.Commerce.Price()),
       //             Stock = faker.Random.Short(0, 100),
       //             ImagePath = faker.Image.PicsumUrl(),//Lorem PicsumURL den bize fake ımagepathler oluşturacaktır.
       //             Discount = Math.Round(faker.Random.Double(0, 0.5), 2),
       //             CategoryId = faker.Random.Number(1, 10)
       //         };

       //         products.Add(product);
       //     }
       //     return products;
       // }
    }
}
