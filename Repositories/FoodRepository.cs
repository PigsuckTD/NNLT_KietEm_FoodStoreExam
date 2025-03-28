using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodRepository
    {
        private FoodManagerDbContext _context;
        public List<UserAccount> GetAccounts()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }
        public List<TableFood> GetFoodTable() 
        {
            _context = new();
            return _context.TableFoods.ToList();
        }
    }
    
}
