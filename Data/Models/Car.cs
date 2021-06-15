
namespace WebApplication5.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public decimal price { get; set; }
        public bool isFavorite { get; set; }
        public bool avaiable { get; set; }
        public int categoryID { get; set; }
        public Category Category { get; set; }
    }
}
