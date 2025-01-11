using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using PharmacyManagementSystem.DTO.Product;
using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Services;
using PharmacyManagementSystem.View.Partners;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class Product : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private List<ProductDto> _originalData; // Dữ liệu gốc
        private int _pageSize = 10;                    // Số hàng trên mỗi trang
        private int _currentPage = 1;                 // Trang hiện tại
        private int _totalPages;                      // Tổng số trang
        private bool _isAscending = true;
        private string _sortedColumn = "";        // Cột hiện đang sắp xếp
        private string _imageBasePath; // Đường dẫn gốc chứa ảnh
        //public static bool _isDelete = false; 
        public Product()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            _productService = new ProductService();
            _originalData = new List<ProductDto>();

            _imageBasePath = "C:\\Users\\VivoBook\\Tài liệu\\Pharmacy\\PharmacyManagementSystem\\PharmacyManagementSystem\\Resoures\\DataBase\\Product";

            LoadCategory();

            gridView.AutoGenerateColumns = false;
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

        private async void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = gridView.Rows[e.RowIndex];
            var productID = (Guid)selectedRow.Cells["ID"].Value;
            var response = await _productService.GetProductByIdAsync(productID);

            if (response != null)
            {
                OpenChildForm(new ProductDetail(response));
                await LoadProduct(); // Cập nhật lại dữ liệu trong DataGridView
               
            }
            else
            {
                MessageBox.Show("Failed to retrieve category details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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
            var cate = await _categoryService.GetAllCategoriesNameAsync();
            listViewCategory.Items.Clear();
            listViewCategory.Items.Add("Tất cả");
            foreach (var c in cate)
            {
                //ListViewItem item = new ListViewItem(c); 
                //item.ImageIndex = imageList.Images.IndexOfKey("edit"); // Gắn icon cây bút (nếu có)
                listViewCategory.Items.Add(c);
            }
        }

        private async void Product_Load(object sender, EventArgs e)
        {
            await LoadProduct();
        }
        private async Task LoadProduct()
        {
            try
            {
                var response = await _productService.GetAllProductsAsync();
                var responeCate = await _categoryService.GetAllCategoriesNameAsync();

                if (response != null)
                {
                    foreach (var product in response)
                    {
                        var category = await _categoryService.GetCategoryByIdAsync(product.CategoryID);
                        var categoryName = category.Name;

                        _originalData.Add(new ProductDto
                        {
                            ID = product.ProductID,
                            ImageName = product.Image,
                            Name = product.Name,
                            Category = categoryName,
                            SellingPrice = (decimal)product.SellingPrice,
                            OriginalPrice = (decimal)product.OriginalPrice,
                            StockQuantity = product.StockQuantity,
                        });
                    }
                    _totalPages = (int)Math.Ceiling((double)_originalData.Count / _pageSize);
                    DisplayPage(_currentPage);
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DisplayImage(List<ProductDto> pagedData)
        {
            foreach (var item in pagedData)
            {
                var row = gridView.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["ID"].Value.ToString() == item.ID.ToString());

                if (row != null)
                {

                    if (item.ImageName != null)
                    {
                        string imagePath = Path.Combine(_imageBasePath, item.ImageName) + ".jpg";
                        if (File.Exists(imagePath))
                            row.Cells["Image"].Value = System.Drawing.Image.FromFile(imagePath);
                    }
                    else
                    {
                        row.Cells["Image"].Value = Properties.Resources.default_featured_image_png;
                    }
                }
            }
        }
        private void DisplayPage(int pageNumber)
        {
            if (_originalData == null || !_originalData.Any()) return;

            var pagedData = _originalData.Skip((pageNumber - 1) * _pageSize).Take(_pageSize).ToList();

            gridView.DataSource = pagedData;

            DisplayImage(pagedData);



            lblPage.Text = $"{_currentPage}/{_pageSize}";
            labelPageInfo.Text = $"Hiển thị {_currentPage * (_pageSize - 1) + 1} - {_currentPage * _pageSize} / Tổng số 32 hàng hóa";
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                DisplayPage(_currentPage);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                DisplayPage(_currentPage);
            }
        }
        private void SortData(string columnName, bool ascending)
        {
            if (_originalData == null || !_originalData.Any()) return;

            _originalData = ascending
                ? _originalData.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList()
                : _originalData.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();

            _currentPage = 1;
            DisplayPage(_currentPage);
        }
        private void UpdateColumnHeaders()
        {
            foreach (DataGridViewColumn column in gridView.Columns)
            {
                if (column.DataPropertyName == _sortedColumn)
                {
                    column.HeaderText = _isAscending
                        ? $"{column.HeaderText.TrimEnd('↑', '↓')} ↑"
                        : $"{column.HeaderText.TrimEnd('↑', '↓')} ↓";
                }
                else
                {
                    column.HeaderText = column.HeaderText.TrimEnd('↑', '↓');
                }
            }
        }
        private void gridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridView.Columns[e.ColumnIndex].Name == "Image" || (gridView.Columns[e.ColumnIndex].Name == "Remove"))
            {
                return;
            }
            string columnName = gridView.Columns[e.ColumnIndex].DataPropertyName;

            if (_sortedColumn == columnName)
            {
                _isAscending = !_isAscending;
            }
            else
            {
                _sortedColumn = columnName;
                _isAscending = true;
            }

            SortData(columnName, _isAscending);

            UpdateColumnHeaders();
        }

        private void tbxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, dấu chấm, hoặc dấu âm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true; // Loại bỏ ký tự
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu âm ở đầu
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void tbxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, dấu chấm, hoặc dấu âm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true; // Loại bỏ ký tự
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu âm ở đầu
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }

        }
        private async void ApplyFilters(String selectedCategory)
        {
            // Danh sách sản phẩm gốc
            var filteredData = _originalData;

            // Nếu đã chọn danh mục, lọc theo danh mục
            if (selectedCategory != null)
            {
                if (!selectedCategory.Equals("Tất cả"))
                {
                    filteredData = filteredData
                    .Where(product => product.Category.Equals(selectedCategory))
                    .ToList();
                }
            }

            // Lọc các điều kiện khác như giá, size, v.v.
            decimal minPrice = 0; // Hoặc giá trị nhỏ nhất có thể
            decimal maxPrice = decimal.MaxValue; // Hoặc giá trị lớn nhất có thể

            if (tbxMin.Text != "") minPrice = decimal.Parse(tbxMin.Text);
            if (tbxMax.Text != "") maxPrice = decimal.Parse(tbxMax.Text);

            // Lọc theo khoảng giá (min, max)
            filteredData = filteredData
            .Where(product => product.SellingPrice >= minPrice && product.SellingPrice <= maxPrice)
            .ToList();

            if (!rbtnCaHai.Checked)
            {
                if (rbtnConHang.Checked) // "Hàng còn" - Tồn kho > 0
                {
                    filteredData = filteredData
                        .Where(product => product.StockQuantity > 0)
                        .ToList();
                }
                else if (rbtnHetHang.Checked) // "Hết hàng" - Tồn kho = 0
                {
                    filteredData = filteredData
                        .Where(product => product.StockQuantity == 0)
                        .ToList();
                }
            }

            // Cập nhật giao diện (ví dụ: DataGridView)
            gridView.DataSource = filteredData;
            DisplayImage(filteredData);

        }
        private void ApplyFilters()
        {
            String selectedCategory = listViewCategory.SelectedItems[0].Text;
            // Danh sách sản phẩm gốc

            var filteredData = _originalData;

            // Nếu đã chọn danh mục, lọc theo danh mục
            if (selectedCategory != null)
            {
                if (!selectedCategory.Equals("Tất cả"))
                {
                    filteredData = filteredData
                    .Where(product => product.Category.Equals(selectedCategory))
                    .ToList();
                }
            }

            // Lọc các điều kiện khác như giá, size, v.v.
            decimal minPrice = 0; // Hoặc giá trị nhỏ nhất có thể
            decimal maxPrice = decimal.MaxValue; // Hoặc giá trị lớn nhất có thể

            if (tbxMin.Text != "") minPrice = decimal.Parse(tbxMin.Text);
            if (tbxMax.Text != "") maxPrice = decimal.Parse(tbxMax.Text);
            // Lọc theo khoảng giá (min, max)
            filteredData = filteredData
            .Where(product => product.SellingPrice >= minPrice && product.SellingPrice <= maxPrice)
            .ToList();

            // Lọc theo tình trạng tồn kho
            if (!rbtnCaHai.Checked)
            {
                if (rbtnConHang.Checked) // "Hàng còn" - Tồn kho > 0
                {
                    filteredData = filteredData
                        .Where(product => product.StockQuantity > 0)
                        .ToList();
                }
                else if (rbtnHetHang.Checked) // "Hết hàng" - Tồn kho = 0
                {
                    filteredData = filteredData
                        .Where(product => product.StockQuantity == 0)
                        .ToList();
                }
            }


            // Cập nhật giao diện (ví dụ: DataGridView)
            gridView.DataSource = filteredData;
            DisplayImage(filteredData);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void listViewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedCategory = listViewCategory.SelectedItems.Count > 0 ? listViewCategory.SelectedItems[0].Text : "Tất cả";
            ApplyFilters(selectedCategory);
        }

        private void rbtnConHang_CheckedChanged(object sender, EventArgs e)
        {
            String selectedCategory = listViewCategory.SelectedItems.Count > 0 ? listViewCategory.SelectedItems[0].Text : "Tất cả";
            ApplyFilters(selectedCategory);
        }

        private void rbtnHetHang_CheckedChanged(object sender, EventArgs e)
        {
            String selectedCategory = listViewCategory.SelectedItems.Count > 0 ? listViewCategory.SelectedItems[0].Text : "Tất cả";
            ApplyFilters(selectedCategory);
        }
    }
}
