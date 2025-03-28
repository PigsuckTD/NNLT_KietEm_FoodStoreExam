using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FoodMonServices
    {
        private FoodMonRepository _repo = new FoodMonRepository();
        public List<Food> GetAllFood()
        {
            return _repo.GetFood();
        }
    }
}
