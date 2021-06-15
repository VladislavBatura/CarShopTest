using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;

namespace WebApplication5.Controllers
{
    public class OrderController : Controller
    {

        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }

        public IActionResult Checkout()
        {

            return View();
        }
    }
}
