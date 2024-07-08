using HotCatCafe.BLL.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Abstracts.BaseAbstract.BaseRepository;
using HotCatCafe.Model.Entities;
using System.Reflection.Metadata.Ecma335;

namespace HotCatCafe.BLL.Concretes.Services
{
    public class CategoryService : ICategoryRepository
    {
        private readonly IBaseRepository<Category> _baseRepository;

        public CategoryService(IBaseRepository<Category> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<string> CreateCategoryAsync(Category category)
        {
            return await _baseRepository.Create(category);

        }

        public async Task<string> DeleteCategoryAsync(Category category)
        {
            return await _baseRepository.Delete(category);
        }

        public IEnumerable<Category> GetActivesCategories()
        {
            return _baseRepository.GetActives();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _baseRepository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return _baseRepository.GetById(id);
        }

        public IEnumerable<Category> GetPassivesCategories()
        {
            return _baseRepository.GetPassives();
        }

        public async Task<string> UpdateCategoryAsync(Category category)
        {
            return await _baseRepository.Update(category);
        }
    }
}
