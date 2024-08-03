using HotCatCafe.Model.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotCatCafe.Model.Entities
{
    public class Category:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Mapping
        //Bir categornin n tane ürünü olabilir.
        public virtual List<Product> Products { get; set; }
    }
}
