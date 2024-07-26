using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService;
using HotCatCafe.Model.Entities;
using System.Reflection.Metadata.Ecma335;

namespace HotCatCafe.BLL.Repositories.Concretes.EntityServices
{
    public class CategoryService : ICategoryRepository
    {
        private readonly IStorageService<Category> _categoryRepository;// bu işlem dependency invertion u uygulamamıza olanak sağlıyor.

        public CategoryService(IStorageService<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<string> CreateCategory(Category category)
        {
            try
            {
                return await _categoryRepository.Create(category);//creta aslında bize ıstorageservice'teki create metodunu al demiş oluyor.
            }
            catch (Exception ex)
            {

                return $"Error creating category: {ex.Message}";
            }

        }

        public async Task<string> DeleteCategory(Category category)
        {
            try
            {
                return await _categoryRepository.Delete(category);
            }
            catch (Exception ex)
            {

                return $"Error deleting category: {ex.Message}";
            }
        }

        public IEnumerable<Category> GetActiveCategories()
        {
            return _categoryRepository.GetActives();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
           
            
        }

        public IEnumerable<Category> GetPassiveCategories()
        {
            return _categoryRepository.GetPassives();
        }

        public async Task<string> UpdateCategory(Category category)
        {
            try
            {
                return await _categoryRepository.Update(category);
            }
            catch (Exception ex)
            {

                return $"Error updating category: {ex.Message}";
            }
        }
    }
}
