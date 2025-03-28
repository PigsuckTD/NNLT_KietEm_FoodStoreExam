using FoodStoreManagerUI;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManager_TuanKiet
{
    public partial class InterFaceUI : Form
    {
        private TableFoodServices _services = new TableFoodServices();
        private FoodMonServices _monServices = new FoodMonServices();
        private BillInfoServices _billInfoSevires = new BillInfoServices();
        private BillServices _billServices = new BillServices();

        public InterFaceUI()
        {
            InitializeComponent();
        }

        #region Method

        void LoadTable()
        {
            var tables = _services.LoadTableFood(0, "", "");

            if (tables != null && tables.Count > 0)
            {
                flpTable.Controls.Clear();

                foreach (var table in tables)
                {
                    Button btn = new Button
                    {
                        Text = $"{table.Name}\n{table.Status}",
                        Width = 200,
                        Height = 150,
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        Tag = table.Id
                    };

                    switch (table.Status)
                    {
                        case "Trống":
                            btn.BackColor = Color.LightCyan;
                            break;
                        case "Có người":
                            btn.BackColor = Color.Cyan;
                            break;
                        case "Đang dọn":
                            btn.BackColor = Color.Khaki;
                            break;
                        default:
                            btn.BackColor = Color.DeepPink;
                            break;
                    }

                    btn.Click += btn_Click;
                    flpTable.Controls.Add(btn);
                }

                flpTable.Refresh();
            }
            else
            {
                MessageBox.Show("Không có bàn nào để hiển thị!", "Thông báo");
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int tableId = (int)clickedButton.Tag;

            TableFood table = _services.GetTableById(tableId);

            if (table == null)
            {
                MessageBox.Show("Lỗi: Không tìm thấy bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvUI.Tag = table;
            LoadBillInfo(tableId); // Tải thông tin hóa đơn khi chọn bàn
        }

        private void LoadBillInfo(int tableId)
        {
            DataTable billInfoTable = _billInfoSevires.GetBillInfo(tableId);
            lvUI.Items.Clear();
            decimal totalPrice = 0;

            foreach (DataRow row in billInfoTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["TenMon"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(Convert.ToDecimal(row["DonGia"]).ToString("N0"));
                item.SubItems.Add(Convert.ToDecimal(row["ThanhTien"]).ToString("N0"));

                totalPrice += Convert.ToDecimal(row["ThanhTien"]);
                lvUI.Items.Add(item);
            }

            txtTotalPrice.Text = totalPrice.ToString("N0");

            if (lvUI.Items.Count > 0)
                lvUI.Items[0].Selected = true;
            else
                txtTotalPrice.Text = "0";

            lvUI.Refresh();
        }


        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach (ListViewItem item in lvUI.Items)
            {
                total += double.Parse(item.SubItems[3].Text);
            }
            txtTotalPrice.Text = total.ToString("N0");
        }

        void LoadCategory()
        {
            FoodCategoryServices foodCtgry = new FoodCategoryServices();
            cbCategory.DataSource = foodCtgry.GetAllCatrgory();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        void LoadFoodListByCategoryID(int id)
        {
            int categoryId = (int)cbCategory.SelectedValue;
            FoodMonServices foodMon = new FoodMonServices();
            List<Food> filteredFood = foodMon.GetAllFood()
                                            .Where(food => food.IdCategory == categoryId)
                                            .ToList();

            cbFoodMon.DataSource = filteredFood;
            cbFoodMon.DisplayMember = "Name";
        }

        private void InterFaceUI_LoadUI(object sender, EventArgs e)
        {
            LoadTable();
            LoadCategory();
        }

        #endregion

        #region Event

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            InterfaceLogin f = new();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminStoreManager f = new();
            f.ShowDialog();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue is int categoryId)
            {
                LoadFoodListByCategoryID(categoryId);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (lvUI.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TableFood table = lvUI.Tag as TableFood;
            if (table.Status == "Đang dọn")
            {
                MessageBox.Show("Bàn đang dọn, không thể thêm món!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbFoodMon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn.");
                return;
            }

            Food selectedFood = cbFoodMon.SelectedItem as Food;
            if (selectedFood == null) return;

            int quantity = (int)nmAddFood.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            bool itemExists = false;
            foreach (ListViewItem item in lvUI.Items)
            {
                if (item.SubItems[0].Text == selectedFood.Name)
                {
                    int oldQuantity = int.Parse(item.SubItems[1].Text);
                    int newQuantity = oldQuantity + quantity;
                    item.SubItems[1].Text = newQuantity.ToString();
                    item.SubItems[3].Text = (newQuantity * selectedFood.Price).ToString();
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                ListViewItem newItem = new ListViewItem(selectedFood.Name);
                newItem.SubItems.Add(quantity.ToString());
                newItem.SubItems.Add(selectedFood.Price.ToString("N0"));
                newItem.SubItems.Add((selectedFood.Price * quantity).ToString("N0"));
                lvUI.Items.Add(newItem);
            }

            UpdateTotalPrice();

            // Cập nhật trạng thái bàn thành "Có người"
            _services.UpdateTableStatus(table.Id, "Có người");
            LoadTable();
            LoadBillInfo(table.Id);
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lvUI.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TableFood table = lvUI.Tag as TableFood;
            if (table == null)
            {
                MessageBox.Show("Lỗi: Không lấy được thông tin bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lvUI.Items.Count == 0)
            {
                MessageBox.Show("Không có món nào trong hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBill = _billServices.GetUncheckBillIDByTableID(table.Id);

            if (idBill == -1)
            {
                MessageBox.Show("Không có hóa đơn nào chưa thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Xác nhận thanh toán cho bàn {table.Name}?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool success = _billServices.Checkout(idBill);
                if (success)
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset ListView và trạng thái bàn
                    lvUI.Items.Clear();
                    txtTotalPrice.Text = "0";
                    _services.UpdateTableStatus(table.Id, "Trống");

                    LoadTable();
                    lvUI.Tag = null; // Xóa tag của ListView để tránh lỗi
                }
                else
                {
                    MessageBox.Show("Lỗi khi thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
#endregion