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
using PharmacyManagementSystem.Services;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class ProductDetail : Form
    {
        private readonly ProductService _productService;
        private PharmacyManagementSystem.Models.Product _product;
        public ProductDetail()
        {
            InitializeComponent();
            _productService = new ProductService();
        }
        public ProductDetail(PharmacyManagementSystem.Models.Product product)
        {
            InitializeComponent();
            _productService = new ProductService();
            _product = product;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ProductDetail_Load(object sender, EventArgs e)
        {
            //Header
            var response = await _productService.GetProductByIdAsync(_product.ProductID);


            lblHeader.Text = response.Name.ToString();
        }
    }
}
