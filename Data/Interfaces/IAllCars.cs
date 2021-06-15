using System.Collections.Generic;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetObjCar(int carID);


    }
}
