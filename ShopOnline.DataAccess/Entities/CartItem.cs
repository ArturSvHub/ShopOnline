using System.ComponentModel.DataAnnotations;

namespace ShopOnline.DataAccess.Entities
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public int? Count { get; set; }
    }
}
