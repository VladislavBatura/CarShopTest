using System.Collections.Generic;
using WebApplication5.Data.Models;

namespace WebApplication5.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
