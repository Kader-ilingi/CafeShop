using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.BLL.Abstracts.BaseAbstract.BaseRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        //Listeleme işlemi için IEnumarable tanımlandı . bu bize döngüye ihtiyaç duymadan liste elemanının döndürülmesine olanak sağlar.
        IEnumerable<T> GetAll();

        //Get işlemleri
        T GetById(int id);//Bu bize id ile isteklerimizi çağırmamıza olanak sağlar

        //GetActives
        IEnumerable<T> GetActives();
        //GetPassives
        IEnumerable<T> GetPassives();

        //Kullanıcı bazlı-istekleri
        //Create İşlemleri
        Task<string> Create(T entity);
        //Update 
        Task<string> Update(T entity);
        //Delete işlemleri
        Task<string> Delete(T entity);
    }
}
