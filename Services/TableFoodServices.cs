using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  class TableFoodServices
    {
        private  TableFoodRepository _repo = new TableFoodRepository();
        public List<TableFood> LoadTableFood(int ID, string Name, string Status)
        {
            return _repo.GetTableFood(ID, Name, Status) ?? new List<TableFood>(); // Trả về danh sách rỗng nếu null
        }
        public TableFood GetTableById(int tableId)
        {
            using (var context = new FoodManagerDbContext())
            {
                return context.TableFoods.FirstOrDefault(t => t.Id == tableId);
            }
        }
        public void UpdateTableStatus(int tableId, string status)
        {
            using (var context = new FoodManagerDbContext())
            {
                var table = context.TableFoods.Find(tableId);
                if (table != null)
                {
                    table.Status = status;
                    context.SaveChanges();
                }
            }
        }

    }
}
