﻿
using HotCatCafe.Model.BaseEntities;

namespace HotCatCafe.Model.Entities
{
    public class Review:BaseEntity
    {
        public int ReviewId { get; set; }
        public int? Rating { get; set; }
        public string Comment { get; set; }
        public DateTime? ReviewDate { get; set; }

        // 
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } // Hangi ürün hakkında olduğu
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; } // Kimin tarafından yapıldığı
    }
}