using System;
using System.Collections.Generic;

namespace WebApplication5.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
