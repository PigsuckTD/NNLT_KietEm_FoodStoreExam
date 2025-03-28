using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace Services
{
    public class BillServices
    {
        private BillRepository _repo = new BillRepository();
        public List<Bill> GetAllBill()
        {
            return _repo.GetBill();
        }
        public int GetUncheckBillIDByTableID(int tableId)
        {
            using (var context = new FoodManagerDbContext())
            {
                var bill = context.Bills
                                  .Where(b => b.IdTable == tableId && b.Status == 0)
                                  .FirstOrDefault();

                if (bill != null)
                    return bill.Id;

                return -1; // Không có bill nào chưa thanh toán
            }
        }


        public bool Checkout(int idBill)
        {
            try
            {
                using (var context = new FoodManagerDbContext())
                {
                    var bill = context.Bills.FirstOrDefault(b => b.Id == idBill);

                    if (bill != null)
                    {
                        bill.Status = 1; // Đánh dấu hóa đơn đã thanh toán
                        bill.DateCheckOut = DateOnly.FromDateTime(DateTime.Now); // Cập nhật ngày thanh toán (bỏ qua giờ)
                        context.SaveChanges();
                        return true; // Thành công
                    }
                }
            }
            catch (Exception)
            {
                return false; // Gặp lỗi
            }

            return false; // Không tìm thấy hóa đơn
        }


    }
}
