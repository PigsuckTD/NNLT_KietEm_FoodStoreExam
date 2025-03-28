using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TableFoodRepository
    {
        private FoodManagerDbContext _context;

        public List<TableFood> GetTableFood(int id, string name, string status)
        {
            _context = new();
            return _context.TableFoods
                .Where(x => (id == 0 || x.Id == id) &&
                            (string.IsNullOrEmpty(name) || x.Name.Contains(name)) &&
                            (string.IsNullOrEmpty(status) || x.Status.Contains(status)))
                .ToList();
        }

    }
}
