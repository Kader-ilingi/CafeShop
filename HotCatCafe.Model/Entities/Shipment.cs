using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.Model.Entities
{
    public class Shipment:BaseEntity
    {
        public DateTime ShippingDate { get; set; }
        //public string ShippingCompany { get; set; }    burası ve bunun gibi birçok detay oluşturulabilir ilerleyen süreçlerde
        public string? TrackingNumber { get; set; }
        public string ShippingAddress  { get; set; }

        // 
        public int OrderId { get; set; }
        public virtual Order Order { get; set; } // Hangi siparişe ait olduğu
    }
}
