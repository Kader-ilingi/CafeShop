using HotCatCafe.Model.Enums;
using Microsoft.AspNetCore.Identity;


namespace HotCatCafe.Model.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        
        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }
        public Gender Gender { get; set; }

        //Mapping
        public virtual List<Order> Orders { get; set; } // Kullanıcının verdiği siparişler
        public virtual List<Review> Reviews { get; set; } // Kullanıcının yapmış olduğu review'ler

        
    }
}
