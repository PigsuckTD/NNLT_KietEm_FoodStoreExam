namespace FoodStoreManager_TuanKiet
{
    partial class InterFaceUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            txtTotalPrice = new TextBox();
            btnTotalPrice = new Button();
            cmbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel2 = new Panel();
            nmAddFood = new NumericUpDown();
            btnAddFood = new Button();
            cbFoodMon = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            panel1 = new Panel();
            lvUI = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAddFood).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1521, 38);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(92, 34);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(212, 34);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(300, 40);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(300, 40);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất ";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(btnTotalPrice);
            panel3.Controls.Add(cmbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(957, 664);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 105);
            panel3.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(283, 65);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(131, 35);
            txtTotalPrice.TabIndex = 9;
            // 
            // btnTotalPrice
            // 
            btnTotalPrice.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotalPrice.Location = new Point(283, 5);
            btnTotalPrice.Name = "btnTotalPrice";
            btnTotalPrice.Size = new Size(131, 40);
            btnTotalPrice.TabIndex = 8;
            btnTotalPrice.Text = "Tổng tiền ";
            btnTotalPrice.UseVisualStyleBackColor = true;
            // 
            // cmbSwitchTable
            // 
            cmbSwitchTable.FormattingEnabled = true;
            cmbSwitchTable.Location = new Point(6, 65);
            cmbSwitchTable.Name = "cmbSwitchTable";
            cmbSwitchTable.Size = new Size(129, 38);
            cmbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitchTable.Location = new Point(6, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(129, 46);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn ";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(141, 66);
            nmDiscount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(129, 35);
            nmDiscount.TabIndex = 5;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiscount.Location = new Point(141, 0);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(129, 49);
            btnDiscount.TabIndex = 4;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(420, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(129, 98);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Thanh toán ";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmAddFood);
            panel2.Controls.Add(btnAddFood);
            panel2.Controls.Add(cbFoodMon);
            panel2.Controls.Add(cbCategory);
            panel2.Location = new Point(960, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 101);
            panel2.TabIndex = 3;
            // 
            // nmAddFood
            // 
            nmAddFood.Location = new Point(457, 38);
            nmAddFood.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmAddFood.Name = "nmAddFood";
            nmAddFood.Size = new Size(89, 35);
            nmAddFood.TabIndex = 3;
            nmAddFood.TextAlign = HorizontalAlignment.Center;
            nmAddFood.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(325, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(126, 98);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFoodMon
            // 
            cbFoodMon.FormattingEnabled = true;
            cbFoodMon.Location = new Point(3, 60);
            cbFoodMon.Name = "cbFoodMon";
            cbFoodMon.Size = new Size(316, 38);
            cbFoodMon.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(316, 38);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 63);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(942, 706);
            flpTable.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(lvUI);
            panel1.Location = new Point(963, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 488);
            panel1.TabIndex = 5;
            // 
            // lvUI
            // 
            lvUI.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvUI.Location = new Point(3, 3);
            lvUI.Name = "lvUI";
            lvUI.Size = new Size(543, 488);
            lvUI.TabIndex = 0;
            lvUI.UseCompatibleStateImageBehavior = false;
            lvUI.View = View.Details;
          
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành Tiền";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // InterFaceUI
            // 
            AcceptButton = btnDiscount;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 781);
            Controls.Add(panel1);
            Controls.Add(flpTable);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "InterFaceUI";
            Text = "FoodStoreManager";
            Load += InterFaceUI_LoadUI;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmAddFood).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void InterFaceUI_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private Panel panel3;
        private Panel panel2;
        private NumericUpDown nmAddFood;
        private Button btnAddFood;
        private ComboBox cbFoodMon;
        private ComboBox cbCategory;
        private FlowLayoutPanel flpTable;
        private Button btnDiscount;
        private Button btnCheckOut;
        private ComboBox cmbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDiscount;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel1;
        private ListView lvUI;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtTotalPrice;
        private Button btnTotalPrice;
    }
}