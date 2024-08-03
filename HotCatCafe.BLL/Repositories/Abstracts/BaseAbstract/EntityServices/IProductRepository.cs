using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductByCategoryId(int categoryId);
        Task<Product> GetProductByIdAsync(int productId);
        List<Product> GetProductsByStatus(DataStatus status);
        IEnumerable<Product> GetActiveProducts();
        IEnumerable<Product> GetInactiveProducts();//bu metodunun temel amacı, işletmelerin stoklarında bulunan ve geçici olarak satış dışı bırakılmış ürünleri belirleyerek bu ürünler üzerinde stratejik yönetim ve operasyonel kararlar almalarına yardımcı olmaktır.
        //IEnumerable<Product> GetProductsInStock();//stoktaki ürünleri getirir
        //IEnumerable<Product> GetProductsOutOfStock();//stoğu biten ürünleri getirir
        //IEnumerable<Product> GetDiscontinuedProducts();//satışı durdurulanürünleri getirecek
        Task<string> CreateProductAsync(Product product);
        Task<string> UpdateProductAsync(Product product);
        Task<string> DeleteProductAsync(Product product);

        // E-posta gönderimi için metod
    }
}
