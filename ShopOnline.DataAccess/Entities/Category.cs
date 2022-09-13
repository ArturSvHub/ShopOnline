using System.ComponentModel.DataAnnotations;

namespace ShopOnline.DataAccess.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? IconCSS { get; set; }
    }
}
