using System.Collections.Generic;
using WebApplication5.Data.Models;

namespace WebApplication5.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
