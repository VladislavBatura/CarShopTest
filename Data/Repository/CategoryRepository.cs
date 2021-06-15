using System.Collections.Generic;
using WebApplication5.Data.Interfaces;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDbContent _appDbContent;

        public CategoryRepository(AppDbContent app)
        {
            _appDbContent = app;
        }

        public IEnumerable<Category> AllCategories => _appDbContent.Category;
    }
}
