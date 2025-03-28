using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodCategoryRepository
    {
        private FoodManagerDbContext _context;
        public List<FoodCategory> GetFoodCategory()
        {
            _context = new FoodManagerDbContext();
            return _context.FoodCategories.ToList();
        }
    }
}
