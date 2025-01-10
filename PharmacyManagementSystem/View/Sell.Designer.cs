namespace PharmacyManagementSystem.View
{
    partial class Sell
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnProduct = new Panel();
            lblIndex = new Label();
            lblName = new Label();
            numeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            lblGia = new Label();
            lblTongGia = new Label();
            pnLeft = new FlowLayoutPanel();
            pnRight = new FlowLayoutPanel();
            pnTotalAmount = new Panel();
            lblTongTienHang = new Label();
            lblSoLuong = new Label();
            lblTongTienV = new Label();
            btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            lblKhachHang = new Label();
            cbxKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            cbxNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            lblNhanVien = new Label();
            pnSearch = new FlowLayoutPanel();
            pnHeader.SuspendLayout();
            pnProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric).BeginInit();
            pnLeft.SuspendLayout();
            pnTotalAmount.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.FromArgb(63, 142, 212);
            pnHeader.Controls.Add(pnSearch);
            pnHeader.Controls.Add(cbxNhanVien);
            pnHeader.Controls.Add(lblNhanVien);
            pnHeader.Controls.Add(cbxKhachHang);
            pnHeader.Controls.Add(lblKhachHang);
            pnHeader.Controls.Add(tbxSearch);
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1363, 67);
            pnHeader.TabIndex = 0;
            // 
            // tbxSearch
            // 
            tbxSearch.BorderRadius = 10;
            tbxSearch.CustomizableEdges = customizableEdges5;
            tbxSearch.DefaultText = "";
            tbxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxSearch.Location = new Point(13, 4);
            tbxSearch.Margin = new Padding(4);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PasswordChar = '\0';
            tbxSearch.PlaceholderText = "Tìm sản phẩm";
            tbxSearch.SelectedText = "";
            tbxSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbxSearch.Size = new Size(441, 59);
            tbxSearch.TabIndex = 2;
            // 
            // pnProduct
            // 
            pnProduct.BackColor = Color.White;
            pnProduct.Controls.Add(lblTongGia);
            pnProduct.Controls.Add(lblGia);
            pnProduct.Controls.Add(numeric);
            pnProduct.Controls.Add(lblName);
            pnProduct.Controls.Add(lblIndex);
            pnProduct.Location = new Point(3, 3);
            pnProduct.Name = "pnProduct";
            pnProduct.Size = new Size(708, 90);
            pnProduct.TabIndex = 0;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(5, 26);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(20, 22);
            lblIndex.TabIndex = 0;
            lblIndex.Text = "1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 22);
            lblName.TabIndex = 1;
            lblName.Text = "Dầu gấc lên men";
            // 
            // numeric
            // 
            numeric.BackColor = Color.Transparent;
            numeric.CustomizableEdges = customizableEdges7;
            numeric.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeric.Location = new Point(215, 10);
            numeric.Margin = new Padding(3, 4, 3, 4);
            numeric.Name = "numeric";
            numeric.ShadowDecoration.CustomizableEdges = customizableEdges8;
            numeric.Size = new Size(125, 38);
            numeric.TabIndex = 2;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(402, 26);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(75, 22);
            lblGia.TabIndex = 3;
            lblGia.Text = "800,000";
            // 
            // lblTongGia
            // 
            lblTongGia.AutoSize = true;
            lblTongGia.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongGia.Location = new Point(516, 24);
            lblTongGia.Name = "lblTongGia";
            lblTongGia.Size = new Size(75, 23);
            lblTongGia.TabIndex = 4;
            lblTongGia.Text = "800,000";
            // 
            // pnLeft
            // 
            pnLeft.AutoScroll = true;
            pnLeft.BackColor = SystemColors.Control;
            pnLeft.Controls.Add(pnProduct);
            pnLeft.Location = new Point(3, 70);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(723, 594);
            pnLeft.TabIndex = 3;
            // 
            // pnRight
            // 
            pnRight.Location = new Point(731, 69);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(632, 595);
            pnRight.TabIndex = 4;
            // 
            // pnTotalAmount
            // 
            pnTotalAmount.Controls.Add(lblTongTienV);
            pnTotalAmount.Controls.Add(lblSoLuong);
            pnTotalAmount.Controls.Add(lblTongTienHang);
            pnTotalAmount.Location = new Point(3, 671);
            pnTotalAmount.Name = "pnTotalAmount";
            pnTotalAmount.Size = new Size(723, 63);
            pnTotalAmount.TabIndex = 1;
            // 
            // lblTongTienHang
            // 
            lblTongTienHang.AutoSize = true;
            lblTongTienHang.Location = new Point(416, 23);
            lblTongTienHang.Name = "lblTongTienHang";
            lblTongTienHang.Size = new Size(125, 22);
            lblTongTienHang.TabIndex = 0;
            lblTongTienHang.Text = "Tổng tiền hàng";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(551, 23);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(20, 22);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "1";
            // 
            // lblTongTienV
            // 
            lblTongTienV.AutoSize = true;
            lblTongTienV.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienV.Location = new Point(591, 23);
            lblTongTienV.Name = "lblTongTienV";
            lblTongTienV.Size = new Size(75, 23);
            lblTongTienV.TabIndex = 2;
            lblTongTienV.Text = "800,000";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BorderRadius = 10;
            btnThanhToan.CustomizableEdges = customizableEdges9;
            btnThanhToan.DisabledState.BorderColor = Color.DarkGray;
            btnThanhToan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThanhToan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThanhToan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1125, 671);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnThanhToan.Size = new Size(225, 56);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.ForeColor = Color.White;
            lblKhachHang.Location = new Point(492, 22);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(101, 22);
            lblKhachHang.TabIndex = 3;
            lblKhachHang.Text = "Khách hàng";
            // 
            // cbxKhachHang
            // 
            cbxKhachHang.BackColor = Color.Transparent;
            cbxKhachHang.CustomizableEdges = customizableEdges3;
            cbxKhachHang.DrawMode = DrawMode.OwnerDrawFixed;
            cbxKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKhachHang.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxKhachHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxKhachHang.ForeColor = Color.FromArgb(68, 88, 112);
            cbxKhachHang.ItemHeight = 30;
            cbxKhachHang.Location = new Point(609, 12);
            cbxKhachHang.Name = "cbxKhachHang";
            cbxKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbxKhachHang.Size = new Size(175, 36);
            cbxKhachHang.TabIndex = 4;
            // 
            // cbxNhanVien
            // 
            cbxNhanVien.BackColor = Color.Transparent;
            cbxNhanVien.CustomizableEdges = customizableEdges1;
            cbxNhanVien.DrawMode = DrawMode.OwnerDrawFixed;
            cbxNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNhanVien.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxNhanVien.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNhanVien.ForeColor = Color.FromArgb(68, 88, 112);
            cbxNhanVien.ItemHeight = 30;
            cbxNhanVien.Location = new Point(932, 12);
            cbxNhanVien.Name = "cbxNhanVien";
            cbxNhanVien.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbxNhanVien.Size = new Size(175, 36);
            cbxNhanVien.TabIndex = 6;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.ForeColor = Color.White;
            lblNhanVien.Location = new Point(815, 22);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(90, 22);
            lblNhanVien.TabIndex = 5;
            lblNhanVien.Text = "Nhân viên";
            // 
            // pnSearch
            // 
            pnSearch.Location = new Point(18, 49);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(579, 442);
            pnSearch.TabIndex = 7;
            // 
            // Sell
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 733);
            Controls.Add(btnThanhToan);
            Controls.Add(pnRight);
            Controls.Add(pnTotalAmount);
            Controls.Add(pnLeft);
            Controls.Add(pnHeader);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sell";
            Text = "Sell";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnProduct.ResumeLayout(false);
            pnProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric).EndInit();
            pnLeft.ResumeLayout(false);
            pnTotalAmount.ResumeLayout(false);
            pnTotalAmount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Panel pnListProduct;
        private Panel pnProduct;
        private Label lblTongGia;
        private Label lblGia;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric;
        private Label lblName;
        private Label lblIndex;
        private FlowLayoutPanel pnLeft;
        private FlowLayoutPanel pnRight;
        private Panel pnTotalAmount;
        private Label lblTongTienHang;
        private Label lblTongTienV;
        private Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbxNhanVien;
        private Label lblNhanVien;
        private Guna.UI2.WinForms.Guna2ComboBox cbxKhachHang;
        private Label lblKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private FlowLayoutPanel pnSearch;
        private Panel pnHintProduct;
    }
}