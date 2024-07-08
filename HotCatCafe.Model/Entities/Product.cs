using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.Model.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }  //stoktaki ürün miktarı
        public string ImagePath { get; set; }   //Burada biz doğrudan görseli değil görselin yolunu vermiş olacağız.
        public double Discount { get; set; }  //indirim oranı-yüzdesini ondalıklı olarak alınacağından dolayı double tip kullanıldı.

        //Mapping
        //Bir ürünün 1 categorisi olabilir.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } //Lazy Loading için virtual anahtar kelimesi kullanılmıştır.Lazy Loading kullanılmasının nedeni Product nesnesinin yüklenmesi  esnasında Category nesnesinin yüklenmesinin engellenmesidir.Böylelikle performanslı bir proje tasarlanmış olacaktır.Aynı zamanda virtual ifadesi, polymorphism (çok biçimlilik) ve inheritance (kalıtım) kavramlarının uygulanmasına olanak tanır.

    }
}
