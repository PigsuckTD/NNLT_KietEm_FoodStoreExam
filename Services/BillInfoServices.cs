using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BillInfoServices
    {
        private BillInfoRepository _repo = new BillInfoRepository();
        public List<BillInfo> GetAllBillInfo()
        {
           return _repo.GetBillInfo();

        }
        private readonly BillRepository _billRepository;
        private readonly BillInfoRepository _billInfoRepository;
        private readonly FoodRepository _foodRepository;

        public BillInfoServices()
        {
            _billRepository = new BillRepository();
            _billInfoRepository = new BillInfoRepository();
            _foodRepository = new FoodRepository();
        }

        public DataTable GetBillInfo(int idTable)
        {
            string query = "SELECT f.name AS TenMon, bi.count AS SoLuong, f.price AS DonGia, (bi.count * f.price) AS ThanhTien " +
                           "FROM BillInfo bi " +
                           "JOIN Bill b ON bi.idBill = b.id " +
                           "JOIN Food f ON bi.idFood = f.id " +
                           "WHERE b.idTable = @idTable AND b.status = 1";

            // Lấy chuỗi kết nối từ appsettings.json
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnectionStringDB");

            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idTable", idTable);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }

            return data;
        }

    }
}
