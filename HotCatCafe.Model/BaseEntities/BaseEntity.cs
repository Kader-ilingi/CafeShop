using HotCatCafe.Model.Enums;
using HotCatCafe.Model.Interfaces;
using System.Net.Sockets;

namespace HotCatCafe.Model.BaseEntities
{

    public abstract class BaseEntity : IEntity<Guid>
    {
        //Baseentity'nin miras olarak bırakıldığı enititylerin instance'ı alındığı anda constructer'ın içerisindeki verilerle oluşturulacaktır.
        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;//Verinin oluşturulma tarihini verir.
            CreatedComputerName = Environment.MachineName;//Verinin oluşturulduğu bilgissayarın adını verir.
            CreatedIpAddress = AddressFamily.InterNetwork;//Bu bize IP4 versiyonunun adresini verir..NET Framework ve .NET Core gibi platformlarda TCP/IP protokol ailesindeki adres türlerini temsil etmek için kullanılan bir enum değeridir. Bu değer, System.Net.Sockets namespace'i altında bulunur.IPv6 adreslerini temsil etmek için InterNetworkV6 kullanılır.
            IsActive = true;
            MasterId = Guid.NewGuid();

        }
        public int ID { get; set; }
        public Guid MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public AddressFamily CreatedIpAddress { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
