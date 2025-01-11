using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.DTO.Product;
using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Services;
using PharmacyManagementSystem.View.Goods;

namespace PharmacyManagementSystem.View
{
    public partial class Sell : Form
    {
        private readonly ProductService _productService;

        private string _imageBasePath = "C:\\Users\\VivoBook\\Tài liệu\\Pharmacy\\PharmacyManagementSystem\\PharmacyManagementSystem\\Resoures\\DataBase\\Product";
        private decimal _amount = 0;
        private int _count = 0;
        public Sell()
        {
            InitializeComponent();
            _productService = new ProductService();

            LoadProduct();
            LoadCustomer();
            LoadEmployee();


            lblTong.Text = "0  0";
        }
        public async void LoadCustomer()
        {

        }
        public async void LoadEmployee()
        {

        }
        public async void LoadProduct()
        {
            var products = await _productService.GetAllProductsAsync();

            if (products != null)
            {
                foreach (var product in products)
                {
                    Panel productPanel = new Panel
                    {
                        Width = 180,
                        Height = 180, 
                        Margin = new Padding(10), 
                        BorderStyle = BorderStyle.None 
                    };

                    Image image = Properties.Resources.default_featured_image_png;
                    if (product.Image != null)
                    {
                        string imagePath = Path.Combine(_imageBasePath, product.Image) + ".jpg";

                        if (File.Exists(imagePath))
                            image = System.Drawing.Image.FromFile(imagePath);
                    }

                    PictureBox pictureBox = new PictureBox
                    {

                        Image = image,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Top,
                        Height = 100 
                    };


                    Label lblName = new Label
                    {
                        Text = product.Name,
                        Dock = DockStyle.Top,
                        Font = new Font("TimeNewRoman", 12),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Height = 40, 
                        AutoEllipsis = true // Hiển thị "..." nếu tên quá dài
                    };

                    Label lblPrice = new Label
                    {
                        Text = $"{product.SellingPrice:N0} đ",
                        Dock = DockStyle.Top,
                        Font = new Font("TimeNewRoman", 12),
                        ForeColor = Color.Blue,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    // Thêm các thành phần vào Panel sản phẩm
                    productPanel.Controls.Add(lblPrice);
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(pictureBox);

                    // Thêm sự kiện chuột cho border
                    productPanel.MouseEnter += (s, e) =>
                    {
                        productPanel.BorderStyle = BorderStyle.FixedSingle;
                    };
                    productPanel.MouseLeave += (s, e) =>
                    {
                        productPanel.BorderStyle = BorderStyle.None; 
                    };

                    // Thêm Panel sản phẩm vào FlowLayoutPanel
                    if (productPanel.Controls.Count > 0)
                        pnRight.Controls.Add(productPanel);

                    // Thêm sự kiện click vào Panel
                    productPanel.Click += (s, e) =>
                    {
                        Product_Click(product); 
                    };
                }
            }

        }
        // bỏ dấu
        private string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Chuẩn hóa ký tự thành dạng Unicode tổ hợp
            var normalizedString = text.Normalize(NormalizationForm.FormD);

            // Lọc ra các ký tự không phải tổ hợp (loại bỏ dấu)
            var stringBuilder = new StringBuilder();
            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            // Trả về chuỗi không dấu, chuẩn hóa lại về Form C
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        private async void SearchProducts(string keyword)
        {
            var allProducts = await _productService.GetAllProductCardAsync();

            if (allProducts != null)
            {
                // Loại bỏ dấu trong từ khóa tìm kiếm
                string normalizedKeyword = RemoveDiacritics(keyword.ToLower());

                var filteredProducts = await _productService.GetAllProductsSearchAsync(normalizedKeyword);
                if (filteredProducts != null)
                {
                    DisplayProductsSearch(filteredProducts);
                }
            }
        }
        private void DisplayProductsSearch(IEnumerable<Models.Product> products)
        {
            if (products != null)
            {
                pnSearch.Controls.Clear();

                foreach (var product in products)
                {

                    Panel productPanel = new Panel
                    {
                        Width = 450,
                        Height = 120, 
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.None 
                    };

                    Image image = Properties.Resources.default_featured_image_png;
                    if (product.Image != null)
                    {
                        string imagePath = Path.Combine(_imageBasePath, product.Image) + ".jpg";

                        if (File.Exists(imagePath))
                            image = System.Drawing.Image.FromFile(imagePath);
                    }
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = image, 
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 80,
                        Height = 80,
                        Dock = DockStyle.Left,
                        Margin = new Padding(5)
                    };

                    Label lblName = new Label
                    {
                        Text = product.Name,
                        Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        AutoEllipsis = true, // Nếu quá dài, hiển thị "..."
                        Dock = DockStyle.Top,
                        Height = 30,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label lblPrice = new Label
                    {
                        Text = $"{product.SellingPrice:N0} đ",
                        Font = new Font("Times New Roman", 12),
                        ForeColor = Color.Blue,
                        Dock = DockStyle.Top,
                        Height = 25,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label lblCode = new Label
                    {
                        Text = $"Mã: {product.MedicineID}",
                        Font = new Font("Times New Roman", 10),
                        Dock = DockStyle.Top,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label lblStock = new Label
                    {
                        Text = $"Tồn: {product.StockQuantity}",
                        Font = new Font("Times New Roman", 10),
                        Dock = DockStyle.Top,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Panel infoPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Padding = new Padding(5)
                    };
                    infoPanel.Controls.Add(lblStock);
                    infoPanel.Controls.Add(lblCode);
                    infoPanel.Controls.Add(lblPrice);
                    infoPanel.Controls.Add(lblName);

                    // Thêm các thành phần vào Panel chính
                    productPanel.Controls.Add(infoPanel);
                    productPanel.Controls.Add(pictureBox);

                    // Thêm sự kiện chuột cho border
                    productPanel.MouseEnter += (s, e) =>
                    {
                        productPanel.BorderStyle = BorderStyle.FixedSingle; 
                    };
                    productPanel.MouseLeave += (s, e) =>
                    {
                        productPanel.BorderStyle = BorderStyle.None; 
                    };

                    // Thêm Panel vào FlowLayoutPanel
                    if (productPanel.Controls.Count > 0)
                    {
                        pnSearch.Visible = true;
                        pnSearch.Controls.Add(productPanel);
                    }

                    // Thêm sự kiện click vào Panel
                    productPanel.Click += (s, e) =>
                    {
                        Product_Click(product); 
                    };
                }
            }
            else
            {
                Label lblPrice = new Label
                {
                    Text = "Không tìm thấy kết quả phù hợp",
                    Dock = DockStyle.Fill,
                    Font = new Font("Times New Roman", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter
                };
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = tbxSearch.Text.Trim(); // Lấy từ khóa tìm kiếm
            if (string.IsNullOrEmpty(keyword))
            {
                pnSearch.Controls.Clear();
                pnSearch.Visible = false;
            }
            else
            {
                pnSearch.Visible = true;
                SearchProducts(keyword); // Gọi hàm tìm kiếm
            }
        }
        // Add
        private void Product_Click(Models.Product product)
        {
            // Kiểm tra xem sản phẩm đã có trong giỏ chưa
            var existingPanel = pnLeft.Controls
                .Cast<Panel>()
                .FirstOrDefault(p => p.Tag != null && p.Tag.ToString() == product.ProductID.ToString());

            if (existingPanel != null)
            {
                // Nếu đã tồn tại, tăng số lượng
                _count++;
                _amount += product.SellingPrice * 1;
                var lblQuantity = existingPanel.Controls.Find("lblQuantity", true).FirstOrDefault() as Label;
                if (lblQuantity != null)
                {
                    int currentQuantity = int.Parse(lblQuantity.Text);
                    lblQuantity.Text = (currentQuantity + 1).ToString();
                }
            }
            else
            {
                // Nếu chưa tồn tại, thêm Panel mới
                AddProductToCart(product, 1); // Số lượng mặc định là 1
            }

            lblTong.Text = $"{_count}  {_amount}";
            
        }
        private void AddProductToCart(Models.Product product, int quantity)
        {
            Panel cartPanel = new Panel
            {
                Width = pnLeft.Width - 20,
                Height = 80,
                Margin = new Padding(5),
                BorderStyle = BorderStyle.None,
                BackColor = Color.White, 
                Tag = product.ProductID // Gắn mã sản phẩm để kiểm tra tồn tại
            };

            Label lblName = new Label
            {
                Text = product.Name,
                AutoSize = false,
                Width = 200,
                Height = 20,
                Location = new Point(10, 30),
                Font = new Font("Times New Roman", 12),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblPrice = new Label
            {
                Text = $"{product.SellingPrice:N0} đ",
                AutoSize = false,
                Width = 80,
                Height = 20,
                Location = new Point(400, 30),
                Font = new Font("Times New Roman", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleRight
            };

            Label lblQuantity = new Label
            {
                Name = "lblQuantity",
                Text = quantity.ToString(),
                AutoSize = false,
                Width = 30,
                Height = 25,
                Location = new Point(310, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle 
            };

            Button btnDecrease = new Button
            {
                Text = "-",
                Width = 25,
                Height = 25,
                Location = new Point(280, 30)
            };

            Button btnIncrease = new Button
            {
                Text = "+",
                Width = 25,
                Height = 25,
                Location = new Point(350, 30)
            };

            Button btnDelete = new Button
            {
                Text = "🗑️",
                Width = 25,
                Height = 25,
                Location = new Point(cartPanel.Width - 35, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.Red
            };

            btnDecrease.Click += (s, e) =>
            {
                
                int currentQuantity = int.Parse(lblQuantity.Text);
                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    lblQuantity.Text = currentQuantity.ToString();
                    _count--;
                    _amount -= product.SellingPrice * 1;
                    lblTong.Text = $"{_count}  {_amount}";
                }
                else
                {
                    MessageBox.Show("Số lượng không thể nhỏ hơn 1.");
                }
            };

            btnIncrease.Click += (s, e) =>
            {
                _count++;
                _amount += product.SellingPrice * 1;
                lblTong.Text = $"{_count}  {_amount}";
                int currentQuantity = int.Parse(lblQuantity.Text);
                currentQuantity++;
                lblQuantity.Text = currentQuantity.ToString();
            };

            btnDelete.Click += (s, e) =>
            {
                pnLeft.Controls.Remove(cartPanel);
                _count -= int.Parse(lblQuantity.Text);
                _amount -= product.SellingPrice * int.Parse(lblQuantity.Text);
                lblTong.Text = $"{_count}  {_amount}";
                MessageBox.Show($"Đã xóa sản phẩm: {product.Name}");
            };

            // Thêm các thành phần vào Panel
            cartPanel.Controls.Add(lblName);
            cartPanel.Controls.Add(lblPrice);
            cartPanel.Controls.Add(lblQuantity);
            cartPanel.Controls.Add(btnDecrease);
            cartPanel.Controls.Add(btnIncrease);
            cartPanel.Controls.Add(btnDelete);

            // Thêm Panel vào FlowLayoutPanel
            pnLeft.Controls.Add(cartPanel);

            _count++;
            _amount += product.SellingPrice * int.Parse(lblQuantity.Text);
        }
    }
}
