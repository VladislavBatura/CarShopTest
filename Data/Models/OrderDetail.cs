

namespace WebApplication5.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public decimal Price { get; set; }
        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }
        
    }
}
