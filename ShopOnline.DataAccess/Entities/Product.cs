using System.ComponentModel.DataAnnotations;

namespace ShopOnline.DataAccess.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? PurshasePrice { get; set; }
        public int? Count { get; set; }
        public string? Article { get; set; }
        public bool? IsInShopping { get; set; }
        public int? CategoryId { get; set; }
    }
}
