using System.ComponentModel.DataAnnotations;

namespace ShopOnline.DataAccess.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? UserName { get; set; }
    }
}
