using HotCatCafe.Model.Entities;

namespace HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices
{
    public interface ICategoryRepository
    {
        //Category ile ilgili işlemler bu interface'te tanımlanacak

        //Listeleme
        IEnumerable<Category> GetAllCategories(); //Bütün categorileri listeleyecektir

        Category GetCategoryById(int id);//id ile kategory çağırmamızı sağlayacaktır

        IEnumerable<Category> GetActiveCategories();
        IEnumerable<Category> GetPassiveCategories();
        Task<string> CreateCategory(Category category);//kullanıcı istekleri async olarak tanımlandı
        Task<string> UpdateCategory(Category category);
        Task<string> DeleteCategory(Category category);



    }
}
