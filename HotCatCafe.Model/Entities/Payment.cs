using HotCatCafe.Model.BaseEntities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.Model.Entities
{
    public class Payment:BaseEntity
    {
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public PaymentStatus Status { get; set; } // Ödeme durumu: "Tamamlandı", "Başarısız" gibi

        // Navigation properties
        //public int OrderId { get; set; }
        //public virtual Order Order { get; set; } // Hangi siparişe ait olduğu
    }
}
