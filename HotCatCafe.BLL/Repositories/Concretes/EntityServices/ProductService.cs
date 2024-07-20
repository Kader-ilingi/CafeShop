using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService;
using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.BLL.Repositories.Concretes.EntityServices
{
    public class ProductService : IProductRepository
    {
        private readonly IStorageService<Product> _storageService;

        public ProductService(IStorageService<Product> storageService)
        {
            _storageService = storageService;
        }
        public async Task<string> CreateProductAsync(Product product)
        {
           
            try
            {
                return await _storageService.Create(product);//ıstorageservice'teki create ile oluşturmamıza olanak sağlıyor.
            }
            catch (Exception ex)
            {

                return $"Error creating product: {ex.Message}";
            }
        }

        public async Task<string> DeleteProductAsync(Product product)
        {
            try
            {
                return await _storageService.Delete(product);
            }
            catch (Exception ex)
            {

                return $"Error deleting product:{ex.Message}";
            }
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _storageService.GetActives();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _storageService.GetPassives();
        }

        public IEnumerable<Product> GetDiscontinuedProducts()
        {
            return _storageService.GetAll().Where(x=>x.IsDiscontinued).ToList();
        }

        public IEnumerable<Product> GetInactiveProducts()
        {
            return _storageService.GetAll().Where(x=>!x.IsActive || x.IsDiscontinued).ToList();
        }

        public  Product GetProductById(int id)
        {
            var product=_storageService.GetById(id);
            if(product == null)
            {
                throw new Exception($"Product with id {id} not found.");
            }
            return product;
        }

        public IEnumerable<Product> GetProductsByStatus(ProductStatus status)
        {
            return _storageService.GetAll().Where(x=>x.Status == status);
        }

        public  IEnumerable<Product> GetProductsInStock()
        {
            //Bu metot, stokta olan ve aktif durumda (IsActive == true) olan ürünleri getirecek.
            return _storageService.GetAll().Where(x=>x.Stock>0 && x.IsActive).ToList();
        }

        public IEnumerable<Product> GetProductsOutOfStock()
        {
            return _storageService.GetAll().Where(x=>x.Stock==0).ToList();//stok'u sıfırlanan ürünleri getirecektir
        }

        public async Task<string> UpdateProductAsync(Product product)
        {
            try
            {
                return await _storageService.Update(product);
            }
            catch (Exception ex)
            {

                return $"Error updating product:{ex.Message}";
            }  
        }

        public async Task<string> UpdateProductStatusById(int productId, ProductStatus newStatus)
        {
            var product=_storageService.GetById(productId);
            if(product != null)
            {
                product.Status = newStatus;
                await _storageService.Update(product);
                return "ProductStatus updated";
            }
            else
            {
                return $"Error updating ProductStatus";
            }
        }
    }
}
