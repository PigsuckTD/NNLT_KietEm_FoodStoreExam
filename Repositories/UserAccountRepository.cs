using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private FoodManagerDbContext _context;
        public UserAccount GetAccount(string User, string Pass)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(x => x.UserName == User && x.Password == Pass);
        }
    }
}
