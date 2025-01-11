using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PharmacyManagementSystem.DTO.Product;
using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Services;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class ProductDetail : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly SupplierService _supplierService;
        private PharmacyManagementSystem.Models.Product _product;
        private string _imageBasePath = "C:\\Users\\VivoBook\\Tài liệu\\Pharmacy\\PharmacyManagementSystem\\PharmacyManagementSystem\\Resoures\\DataBase\\Product";
        public ProductDetail()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _supplierService = new SupplierService();
        }
        public ProductDetail(PharmacyManagementSystem.Models.Product product)
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _supplierService = new SupplierService();
            _product = product;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ProductDetail_Load(object sender, EventArgs e)
        {
            //Header
            lblHeader.Text = _product.Name;
            lblMaHangV.Text = _product.ProductID.ToString();

            var cate = await _categoryService.GetCategoryByIdAsync(_product.CategoryID);
            lblNhomHangV.Text = cate.Name;
            lblGiaBanV.Text = _product.SellingPrice.ToString();
            lblGiaVonV.Text = _product.OriginalPrice.ToString();
            lblTonKhoV.Text = _product.StockQuantity.ToString();
            lblDonViTinhV.Text = _product.Unit;

            var sup = await _supplierService.GetSupplierByIdAsync(_product.SupplierID);
            if (sup != null)
            {
                lblNhaCCV.Text = sup.Name;
            }
            lblNgayHetHanV.Text = _product.ExpiryDate.ToString();
            lblMaThuocV.Text = _product.MedicineID;
            lblSoDKV.Text = _product.RegistrationNumber;
            lblHoatChatV.Text = _product.ActiveIngredient;
            lblHamLuongV.Text = _product.Dosage;
            lblHangSanXuatV.Text = _product.Manufacturer;
            lblNuocSanXuatV.Text = _product.CountryOfOrigin;
            lblDongGoiV.Text = _product.Packaging;
            if (_product.IsDiscontinued)
            {
                lblHienTrangV.Text = "Còn bán";
            }
            else
            {
                lblHienTrangV.Text = "Ngừng kinh doanh";
            }
            lblMoTaV.Text = _product.Description;

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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Gọi dịch vụ để lấy thông tin chi tiết
            var response = await _productService.GetProductByIdAsync(_product.ProductID);

            if (response != null)
            {
                // Mở form Edit với dữ liệu lấy từ dịch vụ
                using (var editForm = new ProductEdit(response))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve category details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận xóa
            var confirmResult = MessageBox.Show("Ban có chắc chắn muốn xóa sản phẩm này?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {

                // Gọi hàm xóa từ service
                var isDeleted = await _productService.DeleteProductAsync(_product.ProductID);

                if (isDeleted)
                {
                    this.Close();
                    MessageBox.Show("Item removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to remove the item. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
