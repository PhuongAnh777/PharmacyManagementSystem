using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms.Suite;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementSystem.DTO.Product;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem.Services
{
    public class ProductService
    {
        private readonly PharmacyContext _context;
        public ProductService()
        {
            _context = new PharmacyContext();
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<IEnumerable<string>> GetAllProductNamesAsync()
        {
            return await _context.Products
                .Select(p => p.Name)
                .ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid productId)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.ProductID == productId);
        }

        public async Task<Product> CreateProductAsync(ProductCreateDto productDto)
        {
            var product = new Product
            {
                ProductID = Guid.NewGuid(),
                MedicineID = productDto.MedicineID,
                RegistrationNumber = productDto.RegistrationNumber,
                CountryOfOrigin = productDto.CountryOfOrigin,
                Name = productDto.Name,
                ActiveIngredient = productDto.ActiveIngredient,
                Dosage = productDto.Dosage,
                Packaging = productDto.Packaging,
                Unit = productDto.Unit,
                OriginalPrice = productDto.OriginalPrice,
                SellingPrice = productDto.SellingPrice,
                Description = productDto.Description,
                Manufacturer = productDto.Manufacturer,
                StockQuantity = productDto.StockQuantity,
                ExpiryDate = productDto.ExpiryDate,
                CategoryID = productDto.CategoryID,
                SupplierID = productDto.SupplierID,
                Image = productDto.Image,
            };
            await _context.Products.AddAsync(product);

            
            await _context.SaveChangesAsync();
            //try
            //{
            //    // Thực hiện các thao tác lưu dữ liệu
            //}
            //catch (Exception ex)
            //{
            //    // Xử lý ngoại lệ
            //    Console.WriteLine("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
            //    Console.WriteLine("Inner exception: " + ex.InnerException?.Message);
            //    throw;
            //}
            return product;
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task<Models.Product> UpdateProductAsync(Guid ProducId, ProductUpdateDto productDto)
        {
            if (productDto == null)
                throw new ArgumentNullException(nameof(productDto), "Product data is required.");

            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == ProducId);

            if (product == null)
                throw new KeyNotFoundException($"Product with ID {ProducId} not found.");

            // Update product properties

            product.MedicineID = productDto.MedicineID;
            product.RegistrationNumber = productDto.RegistrationNumber;
            product.CountryOfOrigin = productDto.CountryOfOrigin;
            product.Name = productDto.Name;
            product.ActiveIngredient = productDto.ActiveIngredient;
            product.Dosage = productDto.Dosage;
            product.Packaging = productDto.Packaging;
            product.Unit = productDto.Unit;
            product.OriginalPrice = productDto.OriginalPrice;
            product.SellingPrice = productDto.SellingPrice;
            product.Description = productDto.Description;
            product.Manufacturer = productDto.Manufacturer;
            product.StockQuantity = productDto.StockQuantity;
            product.ExpiryDate = productDto.ExpiryDate;
            product.CategoryID = productDto.CategoryID;
            product.SupplierID = productDto.SupplierID;
            product.Image = productDto.Image;
            product.IsDiscontinued = productDto.IsDiscontinued;
            // Save changes to the database, this will automatically check the RowVersion
            await _context.SaveChangesAsync();

            return product;

        }

        public async Task<bool> DeleteProductAsync(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<IEnumerable<ProductCardDto>> GetAllProductCardAsync()
        {
            var products = await _context.Products
                .Select(p => new
                {
                    p.ProductID,
                    p.Name,
                    p.Image,
                    p.SellingPrice,
                    p.StockQuantity
                })
                .ToListAsync();

            return products.Select(p => new ProductCardDto
            {
                ProductID = p.ProductID,
                Name = p.Name,
                Image = p.Image,
                SellingPrice = p.SellingPrice,
                StockQuantity = p.StockQuantity

            }).ToList();
        }
        public async Task<IEnumerable<string>> GetAllProductsNameAsync()
        {
            return await _context.Products.Select(c => c.Name).ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetAllProductsSearchAsync(string normalizedKeyword)
        {
            var allProducts = await GetAllProductsAsync();
            return allProducts
                    .Where(p => p.Name != null &&
                                RemoveDiacritics(p.Name.ToLower()).Contains(normalizedKeyword))
                    .ToList();
        }
        public string RemoveDiacritics(string text)
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
    }
}
