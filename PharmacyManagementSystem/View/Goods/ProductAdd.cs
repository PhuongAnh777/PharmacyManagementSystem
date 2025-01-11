using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PharmacyManagementSystem.DTO.Product;
using PharmacyManagementSystem.Services;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class ProductAdd : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly SupplierService _supplierService;
        private string _imageBasePath = "C:\\Users\\VivoBook\\Tài liệu\\Pharmacy\\PharmacyManagementSystem\\PharmacyManagementSystem\\Resoures\\DataBase\\Product";
        private ProductCreateDto _productDto;
        private string _sourceFilePath = "";
        private string _destinationFilePath = "";
        public ProductAdd()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _supplierService = new SupplierService();

            _productDto = new ProductCreateDto();

            LoadCategory();
            LoadSupplier();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void LoadCategory()
        {
            var cate = await _categoryService.GetAllCategoriesNameAsync();
            cbxNhomHang.Items.Clear();

            foreach (var c in cate)
            {
                cbxNhomHang.Items.Add(c);
            }
            cbxNhomHang.DataSource = cate;
            cbxNhomHang.SelectedIndex = 0;
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
            cbxNhaCungCap.SelectedIndex = 0;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
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

            if (string.IsNullOrEmpty(cbxNhomHang.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbxNhaCungCap.SelectedValue.ToString()))
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

                Guid cateID = Guid.Empty;
                var cateid = await _categoryService.GetAllCategoriesAsync();
                cateID = cateid
                        .Where(s => s.Name.Equals(cbxNhomHang.SelectedValue.ToString()))
                        .Select(s => s.CategoryID)  // Giả sử bạn muốn lấy CategoryID
                        .FirstOrDefault();


                Guid supId = Guid.Empty;
                var supall = await _supplierService.GetAllSuppliersAsync();
                    supId = supall
                            .Where(s => s.Name.Equals(cbxNhaCungCap.SelectedValue.ToString()))
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


                var respone = await _productService.CreateProductAsync(_productDto);

                if (respone != null)
                {
                    MessageBox.Show($"Thêm thành công! {respone.Name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
