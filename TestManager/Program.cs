using Services;
using Repositories;
using Repositories.Entities;

namespace TestManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FoodManagerDbContext context = new FoodManagerDbContext();
            //List<UserAccount> arr = context.UserAccounts.ToList();
            //arr.ForEach(x =>
            //{
            //    Console.WriteLine(x.UserName + "|" + x.DisplayName + "|" + x.Password + "|" + x.Type);
            //});

            FoodServices services = new FoodServices();
            var user = services.GetAllUserAccount();
            user.ForEach(y =>
            {
                Console.WriteLine(y.UserName + "|" + y.DisplayName + "|" + y.Password + "|" + y.Type);
            });

            TableFoodServices tableFood = new TableFoodServices();
            var table = tableFood.LoadTableFood(0, "", "");
            table.ForEach(y =>
            {
                Console.WriteLine(y.Id + "|" + y.Name + "|" + y.Status);
            });

            FoodManagerDbContext context = new();

            List<Bill> arr = context.Bills.ToList();
            arr.ForEach(y => Console.WriteLine(y.Id + "|" + y.DateCheckIn + "|" + y.DateCheckOut + "|" + y.IdTable + "|" + y.Status));

            List<BillInfo> arrr = context.BillInfos.ToList();
            arrr.ForEach(y => Console.WriteLine(y.Id + "|" + y.IdFood + "|" + y.IdBill + "|" + y.Count));

            List<FoodCategory> arrrr = context.FoodCategories.ToList();
            arrrr.ForEach(y => Console.WriteLine(y.Id + "|" + y.Name));

            List<Food> arrrrr = context.Foods.ToList();
            arrrrr.ForEach(y => Console.WriteLine(y.Id + "|" + y.Name + "|" + y.IdCategory + "|" + y.Price));
        }
    }
}
