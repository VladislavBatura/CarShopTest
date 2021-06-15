using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla", 
                        shortDesc = "Экологичный автомобиль", 
                        longDesc = "Лучший экологичный и современный автомобиль", 
                        img = "/img/tesla.jpg", 
                        price = 45000, 
                        isFavorite = true,
                        avaiable = true, 
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Элегантый седан",
                        longDesc = "Самый стильный автомобиль от BMW",
                        img = "/img/bmw-m3.jpg",
                        price = 50000,
                        isFavorite = true,
                        avaiable = false,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "ГАЗ-23",
                        shortDesc = "Настоаящая классика",
                        longDesc = "Знаменитый советский автомобиль, о котором мечтал каждый",
                        img = "/img/gas-23.jpg",
                        price = 10000,
                        isFavorite = false,
                        avaiable = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "Renault",
                        shortDesc = "Хороший семейный выбор",
                        longDesc = "Достаточно места для всей вашей семьи",
                        img = "/img/renault.jpg",
                        price = 27000,
                        isFavorite = false,
                        avaiable = false,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars
        {
            get;
            set;
        }

        public Car GetObjCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
