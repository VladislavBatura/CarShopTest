using System.Collections.Generic;
using System.Linq;
using WebApplication5.Data.Models;

namespace WebApplication5.Data
{
    public class DbObject
    {
        public static void Initial(AppDbContent content)
        {
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Car.Any())
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Экологичный автомобиль",
                        longDesc = "Лучший экологичный и современный автомобиль",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavorite = true,
                        avaiable = true,
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
                    });

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category
                            {categoryName = "Электромобили", description = "Современный и экологичный вид транспорта"},
                        new Category {categoryName = "Классические автомобили", description = "Бензиновые двигатели"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category e in list)
                        category.Add(e.categoryName, e);
                }

                return category;
            }
        }
    }
}
