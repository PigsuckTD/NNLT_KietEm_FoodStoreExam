using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BillInfoRepository
    {
        private FoodManagerDbContext _context;
        public List<BillInfo> GetBillInfo()
        {
            _context = new FoodManagerDbContext();
            return _context.BillInfos.ToList();
        }
    }
}
