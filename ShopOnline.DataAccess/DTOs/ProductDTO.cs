namespace ShopOnline.DataAccess.DTOs
{
    public record ProductDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? Count { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }

}
