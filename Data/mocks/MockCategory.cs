using System.Collections.Generic;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", description = "Современный и экологичный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", description = "Бензиновые двигатели"}
                };
            }
        }
    }
}
