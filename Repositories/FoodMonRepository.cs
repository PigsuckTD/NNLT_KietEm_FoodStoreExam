using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodMonRepository
    {
        private FoodManagerDbContext _context;
        public List<Food> GetFood()
        {
            _context = new FoodManagerDbContext();
            return _context.Foods.ToList();
        }
    }
}
