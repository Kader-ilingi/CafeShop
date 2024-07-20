using HotCatCafe.Model.BaseEntities;
using HotCatCafe.Model.Enums;

namespace HotCatCafe.Model.Entities
{
    public class Discount:BaseEntity
    {
       
        public string DiscountCode { get; set; }
        public DiscountType DiscountType { get; set; } // İndirim türü: yüzde, sabit tutar vb.
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MinimumAmount { get; set; } // Minimum sipariş tutarı

        // Mapping
        public virtual List<Order> Orders { get; set; } // Bir indirimin birden fazla siparişle ilişkilendirilmesi
    }
}
