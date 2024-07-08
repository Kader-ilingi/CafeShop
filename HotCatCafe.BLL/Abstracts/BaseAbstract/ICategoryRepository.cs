using HotCatCafe.Model.Entities;

namespace HotCatCafe.BLL.Abstracts.BaseAbstract
{
    public interface ICategoryRepository
    {
        //Category ile ilgili işlemler bu interface'te tanımlanacak

        //Listeleme
        IEnumerable<Category> GetAllCategories(); //Bütün categorileri listeleyecektir

        Category GetCategory(int id);//id ile kategory çağırmamızı sağlayacaktır

        IEnumerable<Category> GetActivesCategories();
        IEnumerable<Category> GetPassivesCategories();
        Task<string> CreateCategoryAsync(Category category);//kullanıcı istekleri async olarak tanımlandı
        Task<string> UpdateCategoryAsync(Category category);
        Task<string> DeleteCategoryAsync(Category category);



    }
}
