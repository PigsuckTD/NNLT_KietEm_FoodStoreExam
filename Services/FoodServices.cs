using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FoodServices
    {
        private FoodRepository _repo = new FoodRepository();
        public List<UserAccount> GetAllUserAccount()
        {
            return _repo.GetAccounts();
        }
    }
}
