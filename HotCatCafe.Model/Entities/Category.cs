using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.Model.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Mapping
        //Bir categornin n tane ürünü olabilir.
        public virtual List<Product> Products { get; set; }
    }
}
