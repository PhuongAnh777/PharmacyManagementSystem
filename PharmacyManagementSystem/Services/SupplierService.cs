using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem.Services
{
    public class SupplierService
    {
        private readonly PharmacyContext _context;

        // Constructor injection
        public SupplierService()
        {
            _context = new PharmacyContext();
        }
        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }
        public async Task<IEnumerable<string>> GetAllSuppliersNameAsync()
        {
            return await _context.Suppliers.Select(c => c.Name).ToListAsync();
        }
        public async Task<Supplier> GetSupplierByIdAsync(Guid? supplierId)
        {
            return await _context.Suppliers
                .FirstOrDefaultAsync(c => c.SupplierID == supplierId);
        }

        public async Task CreateSupplierAsync(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSupplierAsync(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSupplierAsync(string supplierId)
        {
            var supplier = await _context.Suppliers.FindAsync(supplierId);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
        }
    }
}
