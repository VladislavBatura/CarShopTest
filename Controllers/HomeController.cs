using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data.Interfaces;
using WebApplication5.ViewModels;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRepository;

        public HomeController(IAllCars carRepository)
        {
            _carRepository = carRepository;

        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavCars = _carRepository.GetFavCars
            };
            return View(homeCars);
        }
    }
}
