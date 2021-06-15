using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent _appDbContent;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDbContent appDbContent, ShopCart shopCart)
        {
            _appDbContent = appDbContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDbContent.Order.Add(order);
            _appDbContent.SaveChanges();

            var items = _shopCart.ListShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = el.car.id,
                    OrderId = order.Id,
                    Price = el.car.price
                };
                order.OrderDetails.Add(orderDetail);
                _appDbContent.OrderDetail.Add(orderDetail);
            }
            

            _appDbContent.SaveChanges();
        }
    }
}
