using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountServices
    {
        private UserAccountRepository _repo = new();
        public UserAccount CheckLogin(string User, string Pass)
        {
            return _repo.GetAccount(User, Pass);
        }
    }
}
