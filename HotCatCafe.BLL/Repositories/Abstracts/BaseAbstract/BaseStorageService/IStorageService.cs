using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.BaseStorageService
{
    public interface IStorageService<T> where T : BaseEntity
    {
        //Listeleme işlemi için IEnumarable tanımlandı . Bu bize döngüye ihtiyaç duymadan liste elemanının döndürülmesine olanak sağlar.Veri koleksiyonları üzerinde sıralı döngü işlemleri yapmayı ve LINQ sorgularıyla veri manipülasyonunu sağlayan bir arayüzdür.T ye uygun olması için yani t ye gönderdiğimiz değeri karşılayabilmesi adına IEnumerable tanımlandı.iç içe listelemeleri bulundurur.Döngüye ihtiyaç dymadan iç içe listelemeyi bulundurduğu için isteklemizi karşılar.N category(Kategory içinde kateori) leri tanımlamamız açısından daha uygun olacaktır. List<> ise tekil listelemyi temsil ettiği için döngüye ihtiyaç duyar.
        IEnumerable<T> GetAll();

        //Get işlemleri
        T GetByIdAsync(int id);//Bu bize id ile isteklerimizi çağırmamıza olanak sağlar

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
