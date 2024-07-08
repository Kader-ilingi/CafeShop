

using HotCatCafe.Model.Enums;
using System.Net.Sockets;

namespace HotCatCafe.Model.Interfaces
{
    //Bu Intercafe bütün entitlere, içerisinde barındırdığı property'leri OOP'nin Inheritance(Miras) yöntemi ile aktaracaktır. Aynı zamanda tek sorumluluk prensibi(SOLID-Single Responsibility Principle)'ne sahip bir yapı olarak kodun daha esnek bir yapıda olmasına olanak sağlamış olacaktır.Ve generic yapı olarak dışarıdan alacağı <T> ye bağlı olarak Id'nin tipini belirleyebilecektir.
    public interface IEntity<T>
    {
        public int ID { get; set; } //Id: Verinin veritabanında PK olarak tanımlanmasını temsil edecek.
        public T MasterId { get; set; } //MasterId:Verinin UI'da benzersiz bir Id ile görünmesi için tanımlanacak.API isteklerinde daha güvenli bir yapıda olması için kullanıldı

        
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }

        public AddressFamily CreatedIpAddress { get; set; }
        public DateTime UpdatedDate { get; set;}
        public string UpdatedComputerName { get;set; }
        public string UpdatedIpAddress { get; set;}

        public bool IsActive { get; set; }  
        public DataStatus   Status { get; set; }
    }
}
