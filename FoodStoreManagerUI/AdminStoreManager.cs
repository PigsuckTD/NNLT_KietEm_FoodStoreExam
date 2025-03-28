using Services;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManager_TuanKiet
{
    public partial class AdminStoreManager : Form
    {
        private FoodServices _service = new FoodServices(); // Khởi tạo _service ở đây

        // ...

        public AdminStoreManager()
        {
            InitializeComponent();
        }

        private void AccountTK_Load(object sender, EventArgs e)
        {
            dgvTK.DataSource = null;
            dgvTK.DataSource = _service.GetAllUserAccount(); // Sử dụng _service đã khởi tạo
        }
    }
}
