using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.DTO.Product;
using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class ProductEdit : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly SupplierService _supplierService;
        private PharmacyManagementSystem.Models.Product _product;
        private ProductUpdateDto _productDto;
        private string _sourceFilePath = "";
        private string _destinationFilePath = "";
        private string _imageBasePath = "C:\\Users\\VivoBook\\Tài liệu\\Pharmacy\\PharmacyManagementSystem\\PharmacyManagementSystem\\Resoures\\DataBase\\Product";
        private bool _isImage = false;
        public ProductEdit()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _supplierService = new SupplierService();
        }
        public ProductEdit(PharmacyManagementSystem.Models.Product product)
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _supplierService = new SupplierService();
            _productDto = new ProductUpdateDto();
            _product = product;

            LoadCategory();
            LoadSupplier();
            LoadProductData();

        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {

        }
        public async void LoadCategory()
        {
            var cate = await _categoryService.GetAllCategoriesNameAsync();
            cbxNhomHang.Items.Clear();

            foreach (var c in cate)
            {
                cbxNhomHang.Items.Add(c);
            }
            
        }
        public async void LoadSupplier()
        {
            var cate = await _supplierService.GetAllSuppliersNameAsync();
            cbxNhaCungCap.Items.Clear();

            foreach (var c in cate)
            {
                cbxNhaCungCap.Items.Add(c);
            }
            cbxNhaCungCap.DataSource = cate;
        }
        public async void LoadProductData()
        {
            tbxTenThuoc.Text = _product.Name;
            var cate = await _categoryService.GetCategoryByIdAsync(_product.CategoryID);

            foreach (var item in cbxNhomHang.Items)
            {
                if (item.ToString() == cate.Name)
                {
                    cbxNhomHang.SelectedItem = item; // Chọn mục trong ComboBox
                    break;
                }
            }

            tbxGiaBan.Text = _product.SellingPrice.ToString();
            tbxGiaVon.Text = _product.OriginalPrice.ToString();
            numericTonKho.Value = (decimal)_product.StockQuantity;
            tbxDonViCoBan.Text = _product.Unit;

            var sup = await _supplierService.GetSupplierByIdAsync(_product.SupplierID);
            if (sup != null)
            {
                foreach (var item in cbxNhaCungCap.Items)
                {
                    if (item.ToString() == cate.Name)
                    {
                        cbxNhaCungCap.SelectedItem = item; // Chọn mục trong ComboBox
                        break;
                    }
                }
            }
            dateTime.Text = _product.ExpiryDate.ToString();
            tbxMaThuoc.Text = _product.MedicineID;
            tbxSoDangKy.Text = _product.RegistrationNumber;
            tbxHoatChat.Text = _product.ActiveIngredient;
            tbxHamLuong.Text = _product.Dosage;
            tbxHangSanXuat.Text = _product.Manufacturer;
            tbxNuocSanXuat.Text = _product.CountryOfOrigin;
            tbxDongGoi.Text = _product.Packaging;
            if (!_product.IsDiscontinued)
            {
                rbtnCon.Checked = true;
            }
            else
            {
                rbtnNgung.Checked = true;
            }
            tbxMoTa.Text = _product.Description;

            if (_product.Image != null)
            {
                string imagePath = Path.Combine(_imageBasePath, _product.Image) + ".jpg";
                if (File.Exists(imagePath))
                    picBox.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                picBox.Image = Properties.Resources.default_featured_image_png;
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTenThuoc.Text))
            {
                MessageBox.Show("Tên thuốc không được trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(tbxGiaBan.Text, out _))
            {
                MessageBox.Show("Giá bán không được để trống", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _productDto.SellingPrice = decimal.Parse(tbxGiaBan.Text);
            // Xử lý giá vốn
            if (!(string.IsNullOrEmpty(tbxGiaVon.Text)))
            {
                if (!decimal.TryParse(tbxGiaVon.Text, out var originalPrice))
                {
                    MessageBox.Show("Giá vốn không hợp lệ!");
                    return;
                }
                _productDto.OriginalPrice = decimal.Parse(tbxGiaVon.Text);
            }
            else
            {
                _productDto.OriginalPrice = 0;
            }

            if (string.IsNullOrEmpty(cbxNhomHang.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbxNhaCungCap.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTime.Value < DateTime.Now)
            {
                MessageBox.Show("Sản phẩm đã hết hạn", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fileName = "";
                if (picBox.ImageLocation != null)
                {
                    fileName = System.IO.Path.GetFileNameWithoutExtension(picBox.ImageLocation);
                    if (_isImage == true)
                    {
                        try
                        {
                            File.Copy(_sourceFilePath, _destinationFilePath, true);
                            MessageBox.Show("Ảnh đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                Guid cateID = Guid.Empty;
                var cateid = await _categoryService.GetAllCategoriesAsync();
                cateID = cateid
                        .Where(s => s.Name.Equals(cbxNhomHang.SelectedItem.ToString()))
                        .Select(s => s.CategoryID)  // Giả sử bạn muốn lấy CategoryID
                        .FirstOrDefault();


                Guid supId = Guid.Empty;
                var supall = await _supplierService.GetAllSuppliersAsync();
                supId = supall
                        .Where(s => s.Name.Equals(cbxNhaCungCap.SelectedItem.ToString()))
                        .Select(s => s.SupplierID)
                .FirstOrDefault();

                _productDto.MedicineID = string.IsNullOrEmpty(tbxMaThuoc.Text) ? null : tbxMaThuoc.Text;
                _productDto.RegistrationNumber = string.IsNullOrEmpty(tbxSoDangKy.Text) ? null : tbxSoDangKy.Text;
                _productDto.CountryOfOrigin = string.IsNullOrEmpty(tbxNuocSanXuat.Text) ? null : tbxNuocSanXuat.Text;
                _productDto.Name = tbxTenThuoc.Text;
                _productDto.ActiveIngredient = string.IsNullOrEmpty(tbxHoatChat.Text) ? null : tbxHoatChat.Text;
                _productDto.Dosage = string.IsNullOrEmpty(tbxHamLuong.Text) ? null : tbxHamLuong.Text;
                _productDto.Packaging = string.IsNullOrEmpty(tbxDongGoi.Text) ? null : tbxDongGoi.Text;
                _productDto.Unit = string.IsNullOrEmpty(tbxDonViCoBan.Text) ? null : tbxDonViCoBan.Text;
                _productDto.Description = string.IsNullOrEmpty(tbxMoTa.Text) ? null : tbxMoTa.Text;
                _productDto.Manufacturer = string.IsNullOrEmpty(tbxHangSanXuat.Text) ? null : tbxHangSanXuat.Text;


                _productDto.StockQuantity = (int)numericTonKho.Value;

                // Xử lý ngày hết hạn
                _productDto.ExpiryDate = dateTime.Value;

                // Gán các ID (phải chắc chắn các ID đã được xử lý từ trước)
                _productDto.CategoryID = cateID;
                _productDto.SupplierID = supId;

                _productDto.Image = string.IsNullOrEmpty(fileName) ? null : fileName;


                var respone = await _productService.UpdateProductAsync(_product.ProductID, _productDto);

                if (respone != null)
                {
                    MessageBox.Show($"Sửa thành công! {respone.Name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reset form sau khi thêm xong
                //ResetForm();
                // Thông báo thành công và đóng form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            _isImage = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Chọn Ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _sourceFilePath = openFileDialog.FileName;

                    string fileName = Path.GetFileName(_sourceFilePath);
                    _destinationFilePath = Path.Combine(_imageBasePath, fileName);
                    picBox.ImageLocation = _destinationFilePath;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
