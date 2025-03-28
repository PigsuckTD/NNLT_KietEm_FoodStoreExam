using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BillRepository
    {
        private FoodManagerDbContext _context;
        public List<Bill> GetBill()
        {
            _context = new FoodManagerDbContext();
            return _context.Bills.ToList();
        }
    }
}
