namespace PharmacyManagementSystem.View.Staffs
{
    partial class Employee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            pnHeader = new Panel();
            btnXuatFile = new Guna.UI2.WinForms.Guna2Button();
            btnImport = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            lblHeader = new Label();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            pnHeader.SuspendLayout();
            SuspendLayout();
            // 
            // gridView
            // 
            gridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridView.ColumnHeadersHeight = 24;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridView.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, PhoneNumber, Email, Address, Position, Account });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridView.DefaultCellStyle = dataGridViewCellStyle3;
            gridView.GridColor = Color.FromArgb(231, 229, 255);
            gridView.Location = new Point(12, 66);
            gridView.Name = "gridView";
            gridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridView.RowHeadersVisible = false;
            gridView.RowHeadersWidth = 51;
            gridView.Size = new Size(1338, 606);
            gridView.TabIndex = 6;
            gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridView.ThemeStyle.BackColor = Color.White;
            gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridView.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridView.ThemeStyle.HeaderStyle.Height = 24;
            gridView.ThemeStyle.ReadOnly = false;
            gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridView.ThemeStyle.RowsStyle.Height = 29;
            gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnXuatFile);
            pnHeader.Controls.Add(btnImport);
            pnHeader.Controls.Add(btnAdd);
            pnHeader.Controls.Add(tbxSearch);
            pnHeader.Controls.Add(lblHeader);
            pnHeader.Location = new Point(13, 7);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1337, 50);
            pnHeader.TabIndex = 5;
            // 
            // btnXuatFile
            // 
            btnXuatFile.CustomizableEdges = customizableEdges1;
            btnXuatFile.DisabledState.BorderColor = Color.DarkGray;
            btnXuatFile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXuatFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXuatFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXuatFile.FillColor = Color.FromArgb(78, 169, 90);
            btnXuatFile.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(1112, 3);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXuatFile.Size = new Size(177, 42);
            btnXuatFile.TabIndex = 4;
            btnXuatFile.Text = "Xuất file";
            // 
            // btnImport
            // 
            btnImport.CustomizableEdges = customizableEdges3;
            btnImport.DisabledState.BorderColor = Color.DarkGray;
            btnImport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnImport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnImport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnImport.FillColor = Color.FromArgb(78, 169, 90);
            btnImport.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(929, 3);
            btnImport.Name = "btnImport";
            btnImport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnImport.Size = new Size(177, 42);
            btnImport.TabIndex = 3;
            btnImport.Text = "Import";
            // 
            // btnAdd
            // 
            btnAdd.CustomizableEdges = customizableEdges5;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(78, 169, 90);
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(746, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdd.Size = new Size(177, 42);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm mới";
            // 
            // tbxSearch
            // 
            tbxSearch.CustomizableEdges = customizableEdges7;
            tbxSearch.DefaultText = "";
            tbxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxSearch.Location = new Point(321, 4);
            tbxSearch.Margin = new Padding(4);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PasswordChar = '\0';
            tbxSearch.PlaceholderText = "Theo mã, tên, số điện thoại";
            tbxSearch.SelectedText = "";
            tbxSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            tbxSearch.Size = new Size(343, 42);
            tbxSearch.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(4, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(137, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Nhân viên";
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "Mã nhân viên";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // EmployeeName
            // 
            EmployeeName.DataPropertyName = "EmployeeName";
            EmployeeName.HeaderText = "Tên nhân viên";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Điện thoại";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Chức danh";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Account
            // 
            Account.DataPropertyName = "Account";
            Account.HeaderText = "Tài khoản";
            Account.MinimumWidth = 6;
            Account.Name = "Account";
            Account.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 678);
            Controls.Add(gridView);
            Controls.Add(pnHeader);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Employee";
            Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridView;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Account;
        private Panel pnHeader;
        private Guna.UI2.WinForms.Guna2Button btnXuatFile;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Label lblHeader;
    }
}