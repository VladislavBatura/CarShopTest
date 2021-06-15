using System.Collections.Generic;
using WebApplication5.Data.Models;

namespace WebApplication5.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
