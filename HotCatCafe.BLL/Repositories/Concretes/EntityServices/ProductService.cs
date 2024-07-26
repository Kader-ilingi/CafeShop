using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService;
using HotCatCafe.Model.Entities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.BLL.Repositories.Concretes.EntityServices
{
    public class ProductService : IProductRepository
    {
        private readonly IStorageService<Product> _productStorageService;

        public ProductService(IStorageService<Product> productStorageService)
        {
            _productStorageService = productStorageService;
        }
        public async Task<string> CreateProductAsync(Product product)
        {
           
            try
            {
                return await _productStorageService.Create(product);//ıstorageservice'teki create ile oluşturmamıza olanak sağlıyor.
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
                return await _productStorageService.Delete(product);
            }
            catch (Exception ex)
            {

                return $"Error deleting product:{ex.Message}";
            }
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _productStorageService.GetActives();
        }

        public List<Product> GetAllProducts()
        {
            return  _productStorageService.GetAll().ToList();
        }

        public IEnumerable<Product> GetDiscontinuedProducts()
        {
            return _productStorageService.GetAll().Where(x=>x.IsDiscontinued).ToList();
        }

        public IEnumerable<Product> GetInactiveProducts()
        {
            return _productStorageService.GetAll().Where(x=>!x.IsActive || x.IsDiscontinued).ToList();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _productStorageService.GetAll().Where(x => x.CategoryId == categoryId).ToList();

        }

        public  Product GetProductById(int id)
        {
            var product= _productStorageService.GetById(id);
            if(product == null)
            {
                throw new Exception($"Product with id {id} not found.");
            }
            return product;
        }

        public IEnumerable<Product> GetProductsByStatus(DataStatus status)
        {
            return _productStorageService.GetAll().Where(x=>x.Status == status).ToList();
        }

        public  IEnumerable<Product> GetProductsInStock()
        {
            //Bu metot, stokta olan ve aktif durumda (IsActive == true) olan ürünleri getirecek.
            return _productStorageService.GetAll().Where(x=>x.Stock>0 && x.IsActive).ToList();
        }

        public IEnumerable<Product> GetProductsOutOfStock()
        {
            return _productStorageService.GetAll().Where(x=>x.Stock==0).ToList();//stok'u sıfırlanan ürünleri getirecektir
        }

        public async Task<string> UpdateProductAsync(Product product)
        {
            try
            {
                return await _productStorageService.Update(product);
            }
            catch (Exception ex)
            {

                return $"Error updating product:{ex.Message}";
            }  
        }

        public async Task<string> UpdateProductStatusById(int productId, DataStatus newStatus)
        {
            var product = _productStorageService.GetById(productId);
            if (product != null)
            {
                product.Status = newStatus;
                await _productStorageService.Update(product);
                return "ProductStatus updated";
            }
            else
            {
                return $"Error updating ProductStatus";
            }
        }

        List<Product> IProductRepository.GetProductsByStatus(DataStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
