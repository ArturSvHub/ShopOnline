namespace ShopOnline.DataAccess.DTOs
{
    public record CartItemCountUpdateDTO
    {
        public int CartItemId { get; set; }
        public int? Count { get; set; }
    }

}
