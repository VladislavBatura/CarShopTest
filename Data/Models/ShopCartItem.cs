
namespace WebApplication5.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Car car { get; set; }
        public decimal price { get; set; }
        public string ShopCartId { get; set; }
    }
}
