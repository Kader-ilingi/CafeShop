using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByStatus(ProductStatus status);
        Task<string> UpdateProductStatusById(int productId, ProductStatus newStatus);
        Product GetProductById(int id);
        IEnumerable<Product> GetActiveProducts();
        IEnumerable<Product> GetInactiveProducts();//bu metodunun temel amacı, işletmelerin stoklarında bulunan ve geçici olarak satış dışı bırakılmış ürünleri belirleyerek bu ürünler üzerinde stratejik yönetim ve operasyonel kararlar almalarına yardımcı olmaktır.
        IEnumerable<Product> GetProductsInStock();//stoktaki ürünleri getirir
        IEnumerable<Product> GetProductsOutOfStock();//stoğu biten ürünleri getirir
        IEnumerable<Product> GetDiscontinuedProducts();//satığı durdurulanürünleri getirecek
        Task<string> CreateProductAsync(Product product);
        Task<string> UpdateProductAsync(Product product);
        Task<string> DeleteProductAsync(Product product);
    }
}
