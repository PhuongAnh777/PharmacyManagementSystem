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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            cbxNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            lblNhanVien = new Label();
            cbxKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            lblKhachHang = new Label();
            tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnSearch = new FlowLayoutPanel();
            pnLeft = new FlowLayoutPanel();
            pnRight = new FlowLayoutPanel();
            pnTotalAmount = new Panel();
            lblTong = new Label();
            lblTongTienHang = new Label();
            btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            pnHeader.SuspendLayout();
            pnTotalAmount.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.FromArgb(63, 142, 212);
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
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // pnSearch
            // 
            pnSearch.FlowDirection = FlowDirection.TopDown;
            pnSearch.Location = new Point(14, 69);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(457, 442);
            pnSearch.TabIndex = 7;
            pnSearch.Visible = false;
            // 
            // pnLeft
            // 
            pnLeft.AutoScroll = true;
            pnLeft.BackColor = SystemColors.Control;
            pnLeft.Location = new Point(3, 70);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(723, 594);
            pnLeft.TabIndex = 3;
            // 
            // pnRight
            // 
            pnRight.AutoScroll = true;
            pnRight.Location = new Point(731, 69);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(632, 595);
            pnRight.TabIndex = 4;
            // 
            // pnTotalAmount
            // 
            pnTotalAmount.Controls.Add(lblTong);
            pnTotalAmount.Controls.Add(lblTongTienHang);
            pnTotalAmount.Location = new Point(3, 671);
            pnTotalAmount.Name = "pnTotalAmount";
            pnTotalAmount.Size = new Size(723, 63);
            pnTotalAmount.TabIndex = 1;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(551, 23);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(20, 22);
            lblTong.TabIndex = 1;
            lblTong.Text = "1";
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
            // btnThanhToan
            // 
            btnThanhToan.BorderRadius = 10;
            btnThanhToan.CustomizableEdges = customizableEdges7;
            btnThanhToan.DisabledState.BorderColor = Color.DarkGray;
            btnThanhToan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThanhToan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThanhToan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1125, 671);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThanhToan.Size = new Size(225, 56);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            // 
            // Sell
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 733);
            Controls.Add(pnSearch);
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
            pnTotalAmount.ResumeLayout(false);
            pnTotalAmount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Panel pnListProduct;
        private FlowLayoutPanel pnLeft;
        private FlowLayoutPanel pnRight;
        private Panel pnTotalAmount;
        private Label lblTongTienHang;
        private Label lblTong;
        private Guna.UI2.WinForms.Guna2ComboBox cbxNhanVien;
        private Label lblNhanVien;
        private Guna.UI2.WinForms.Guna2ComboBox cbxKhachHang;
        private Label lblKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private FlowLayoutPanel pnSearch;
        private Panel pnHintProduct;
    }
}