using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.Repository
{
    public class CarRepository : IAllCars
    {

        private readonly AppDbContent _appDbContent;

        public CarRepository(AppDbContent app)
        {
            _appDbContent = app;
        }

        public IEnumerable<Car> Cars => _appDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => _appDbContent.Car
            .Where(p => p.isFavorite)
            .Include(c => c.Category);

        public Car GetObjCar(int carID) => _appDbContent.Car.FirstOrDefault(p => p.id == carID);

    }
}
