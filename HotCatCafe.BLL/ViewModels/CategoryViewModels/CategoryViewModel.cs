using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCatCafe.BLL.ViewModels.CategoryViewModels
{
    public class CategoryViewModel
    {
        [Display(Name ="Kategori Ad")]
        public string CategoryName { get; set; }
        [Display(Name ="Açıklama")]
        public string Description { get; set; }
    }
}
