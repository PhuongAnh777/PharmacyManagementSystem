using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using PharmacyManagementSystem.Services;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class Product : Form
    {

        private readonly CategoryService _categoryService;
        public Product()
        {
            InitializeComponent();
            _categoryService = new CategoryService();

            LoadCategory();
        }
        // Open form child
        public void OpenChildForm(Form childForm)
        {
            // Đặt vị trí xuất hiện của form con là chính giữa form chính
            childForm.StartPosition = FormStartPosition.Manual; // Đặt chế độ thủ công
            childForm.Location = new Point(
                this.Location.X + (this.Width - childForm.Width) / 2,
                this.Location.Y + (this.Height - childForm.Height) / 2
            );

            // Làm mờ form chính
            this.Opacity = 0.1;

            // Hiển thị form con dưới dạng modal
            childForm.ShowDialog();

            // Khôi phục độ trong suốt của form chính
            this.Opacity = 1.0;

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenChildForm(new ProductDetail());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductAdd());
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryAdd());
        }
        public async void LoadCategory()
        {
            // Lấy danh sách danh mục từ dịch vụ
            var cate = await _categoryService.GetAllCategoriesNameAsync();

            // Thêm từng danh mục vào ListView
            foreach (var c in cate)
            {
                ListViewItem item = new ListViewItem(c); // Nội dung dòng là tên danh mục
                item.SubItems.Add("");                   // Thêm sub-item trống cho cột icon
                item.ImageIndex = imageList.Images.IndexOfKey("edit"); // Gắn icon cây bút
                listViewCategory.Items.Add(item);        // Thêm dòng vào ListView
            }
        }
    }
}
