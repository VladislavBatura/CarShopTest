using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;
using WebApplication5.ViewModels;

namespace WebApplication5.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAll, ICarsCategory ICat)
        {
            _allCars = iAll;
            _allCategories = ICat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currentCategory = "";
            if (string.IsNullOrEmpty(_category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars
                        .Where(i => i.Category.categoryName
                            .Equals("Электромобили"))
                        .OrderBy(i => i.id);
                    currentCategory = "Электромобили";
                }
                else if (string.Equals("fuel", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars
                        .Where(i => i.Category.categoryName
                            .Equals("Классические автомобили"))
                        .OrderBy(i => i.id);
                    currentCategory = "Классические автомобили";
                }

                
            }

            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrentCategory = currentCategory
            };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }
    }
}
