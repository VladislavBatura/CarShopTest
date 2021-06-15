using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication5.Data.Models
{
    public class ShopCart
    {

        private readonly AppDbContent _appDbContent;
        public ShopCart(AppDbContent app)
        {
            _appDbContent = app;
        }

        public string _ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) {_ShopCartId = shopCartId};
        }

        public void AddToCart(Car car)
        {
            _appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = _ShopCartId,
                car = car,
                price = car.price
            });

            _appDbContent.SaveChanges();

        }

        public List<ShopCartItem> GetShopItems()
        {
            return _appDbContent.ShopCartItem
                .Where(c => c.ShopCartId == _ShopCartId)
                .Include(s => s.car)
                .ToList();
        }

    }
}
