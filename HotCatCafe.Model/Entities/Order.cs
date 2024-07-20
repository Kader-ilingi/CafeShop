using HotCatCafe.Model.BaseEntities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.Model.Entities
{
    public class Order:BaseEntity
    {
        //Lazy Loading (Tembel Yükleme) ile ilişkili nesnelerin gerektiği zaman yüklenmesini sağlar.
       
        public DateTime? OrderDate { get; set; }=DateTime.Now;//Buradaki işlem bize orderdate oluşturulurken şuanki tarihi almaını koşul olarak tanımlandırmıştır
        public decimal? TotalAmount { get; set; }
        public OrderStatus? Status { get; set; } // Örneğin: "Bekleyen", "Gönderildi" gibi durumlar

        // Navigation properties
        //public Guid? AppUserId { get; set; }
        //public virtual AppUser AppUser { get; set; } // Müşteriye ait bilgiler

        //public virtual List<OrderDetail> OrderDetails { get; set; } // Sipariş detayları
        //public virtual List<Payment> Payments { get; set; } // Ödemeler
        //public int? DiscountId { get; set; }
        //public virtual Discount Discount { get; set; } // Siparişe uygulanan indirim
        //public int? ShipmentId { get; set; }
        //public virtual Shipment Shipment { get; set; } // Bir siparişin gönderimi

    }
}
