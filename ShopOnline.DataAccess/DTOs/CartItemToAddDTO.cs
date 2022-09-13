namespace ShopOnline.DataAccess.DTOs
{
    public record CartItemToAddDTO
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int? Count { get; set; }
    }

}
