using HotCatCafe.Model.BaseEntities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.Model.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }  //stoktaki ürün miktarı
        public string ImagePath { get; set; }   //Burada biz doğrudan görseli değil görselin yolunu vermiş olacağız.
        public double Discount { get; set; }  //indirim oranı-yüzdesini ondalıklı olarak alınacağından dolayı double tip kullanıldı.
        public bool IsDiscontinued { get; set; }
        public ProductStatus Status { get; set; }
        public DateTime? Discontinued { get; set; }  // Ürünün satışı durdurulma tarihi (opsiyonel)
        public ProductStatus ProductStatus { get; set; }//instock outofstok --iş mantığı kuralları için -kod bakımı anlaşılabilirlik için tanımlandı
        public DataSize DataSize { get; set; }// ürün boyutu--Kodun okunabilirliği için

        //Mapping
        //Bir ürünün 1 categorisi olabilir.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } //Lazy Loading için virtual anahtar kelimesi kullanılmıştır.Lazy Loading kullanılmasının nedeni Product nesnesinin yüklenmesi  esnasında Category nesnesinin yüklenmesinin engellenmesidir.Böylelikle performanslı bir proje tasarlanmış olacaktır.Aynı zamanda virtual ifadesi, polymorphism (çok biçimlilik) ve inheritance (kalıtım) kavramlarının uygulanmasına olanak tanır.

        public virtual List<Review> Reviews { get; set; } // Ürünün aldığı review'ler





        //burası email gönderimi için productrepository:IroductService içerisine yapılacak.



        //        //todo:public class ProductRepository : IProductRepository
        //{
        //    private readonly YourDbContext _dbContext;
        //        private readonly EmailService _emailService; // E-posta servisi enjekte edildiği varsayıldı

        //        public ProductRepository(YourDbContext dbContext, EmailService emailService)
        //        {
        //            _dbContext = dbContext;
        //            _emailService = emailService;
        //        }

        //        // Diğer metotlar burada...

        //        public async Task<string> UpdateProductAsync(Product product)
        //        {
        //            // Önce stok güncellemesi yapılır
        //            _dbContext.Products.Update(product);
        //            await _dbContext.SaveChangesAsync();

        //            // Stok sıfırlandıysa ve ürün stokta ise e-posta gönderilir
        //            if (product.StockQuantity == 0 && product.Status == ProductStatus.InStock)
        //            {
        //                string toEmail = "recipient@example.com"; // Alıcı e-posta adresi
        //                string subject = "Stok Uyarısı: Ürün Stokta Yok";
        //                string body = $"Ürün '{product.ProductName}' stokta bulunmamaktadır.";

        //                await _emailService.SendEmailAsync(toEmail, subject, body);
        //            }

        //            return "Product updated successfully.";
        //        }

        //        // Diğer metotlar burada...
        //    }


    }
}
