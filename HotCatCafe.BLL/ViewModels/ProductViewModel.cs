using HotCatCafe.BLL.ViewModels.CategoryViewModels;
using HotCatCafe.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotCatCafe.BLL.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Ürün Ad")]
        [Required(ErrorMessage = "Ürün ad boş geçilemez!")]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        [Display(Name = "Ürün Fiyat")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Ürün Stok")]
        public int UnitsInStock { get; set; }

        [Display(Name = "Ürün Görsel")]
        public string? ImagePath { get; set; }

        [Display(Name = "Aktif")]

        public bool IsActive { get; set; }

        [Display(Name = "Durum")]
        public DataStatus Status { get; set; }

        [Display(Name = "Boyut")]
        public DataSize Size { get; set; }

        public List<CategoryViewModel>? Categories { get; set; }
    }
}
