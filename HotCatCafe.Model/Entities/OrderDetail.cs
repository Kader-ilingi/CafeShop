using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.Model.Entities
{
    public class OrderDetail:BaseEntity
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public double Discount { get; set; }

        //Mapping
        public int OrderId { get; set; }
        public virtual Order Order { get; set; } // Hangi siparişe ait olduğu
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } // Sipariş edilen ürün bilgisi

    }
}
