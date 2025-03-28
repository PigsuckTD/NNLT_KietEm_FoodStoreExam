using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FoodCategoryServices
    {
        private FoodCategoryRepository _repo = new();
        public List<FoodCategory> GetAllCatrgory()
        {
            return _repo.GetFoodCategory();
        }
    }
}
