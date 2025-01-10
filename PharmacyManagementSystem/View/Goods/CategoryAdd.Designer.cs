namespace PharmacyManagementSystem.View.Goods
{
    partial class CategoryAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            pnContainer = new Panel();
            pnFooter = new Panel();
            lblHeader = new Label();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            lblTenNhom = new Label();
            lblNhomCha = new Label();
            tbxTenNhom = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnBoQua = new Guna.UI2.WinForms.Guna2Button();
            pnHeader.SuspendLayout();
            pnContainer.SuspendLayout();
            pnFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnExit);
            pnHeader.Controls.Add(lblHeader);
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(817, 78);
            pnHeader.TabIndex = 0;
            // 
            // pnContainer
            // 
            pnContainer.Controls.Add(guna2ComboBox1);
            pnContainer.Controls.Add(tbxTenNhom);
            pnContainer.Controls.Add(lblNhomCha);
            pnContainer.Controls.Add(lblTenNhom);
            pnContainer.Location = new Point(1, 78);
            pnContainer.Name = "pnContainer";
            pnContainer.Size = new Size(816, 152);
            pnContainer.TabIndex = 1;
            // 
            // pnFooter
            // 
            pnFooter.Controls.Add(btnBoQua);
            pnFooter.Controls.Add(btnLuu);
            pnFooter.Location = new Point(2, 233);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(815, 114);
            pnFooter.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(21, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(237, 35);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Thêm nhóm hàng";
            // 
            // btnExit
            // 
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.White;
            btnExit.FocusedColor = SystemColors.ControlDark;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Silver;
            btnExit.Location = new Point(768, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(46, 56);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            // 
            // lblTenNhom
            // 
            lblTenNhom.AutoSize = true;
            lblTenNhom.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenNhom.Location = new Point(20, 28);
            lblTenNhom.Name = "lblTenNhom";
            lblTenNhom.Size = new Size(113, 25);
            lblTenNhom.TabIndex = 0;
            lblTenNhom.Text = "Tên nhóm";
            // 
            // lblNhomCha
            // 
            lblNhomCha.AutoSize = true;
            lblNhomCha.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhomCha.Location = new Point(20, 98);
            lblNhomCha.Name = "lblNhomCha";
            lblNhomCha.Size = new Size(115, 25);
            lblNhomCha.TabIndex = 1;
            lblNhomCha.Text = "Nhóm cha";
            // 
            // tbxTenNhom
            // 
            tbxTenNhom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            tbxTenNhom.CustomizableEdges = customizableEdges5;
            tbxTenNhom.DefaultText = "";
            tbxTenNhom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxTenNhom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxTenNhom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxTenNhom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxTenNhom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxTenNhom.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTenNhom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxTenNhom.Location = new Point(170, 18);
            tbxTenNhom.Margin = new Padding(4, 4, 4, 4);
            tbxTenNhom.Name = "tbxTenNhom";
            tbxTenNhom.PasswordChar = '\0';
            tbxTenNhom.PlaceholderText = "";
            tbxTenNhom.SelectedText = "";
            tbxTenNhom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbxTenNhom.Size = new Size(617, 40);
            tbxTenNhom.TabIndex = 2;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges3;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(170, 92);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.Size = new Size(617, 36);
            guna2ComboBox1.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.CustomizableEdges = customizableEdges9;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.FromArgb(78, 169, 90);
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(424, 44);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnLuu.Size = new Size(177, 42);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            // 
            // btnBoQua
            // 
            btnBoQua.CustomizableEdges = customizableEdges7;
            btnBoQua.DisabledState.BorderColor = Color.DarkGray;
            btnBoQua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBoQua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBoQua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBoQua.FillColor = Color.DarkGray;
            btnBoQua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBoQua.ForeColor = Color.White;
            btnBoQua.Location = new Point(628, 44);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBoQua.Size = new Size(177, 42);
            btnBoQua.TabIndex = 6;
            btnBoQua.Text = "Bỏ qua";
            // 
            // CategoryAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(819, 348);
            Controls.Add(pnFooter);
            Controls.Add(pnContainer);
            Controls.Add(pnHeader);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CategoryAdd";
            Text = "MedicineCategory";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnContainer.ResumeLayout(false);
            pnContainer.PerformLayout();
            pnFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lblHeader;
        private Panel pnContainer;
        private Panel pnFooter;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox tbxTenNhom;
        private Label lblNhomCha;
        private Label lblTenNhom;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnBoQua;
    }
}