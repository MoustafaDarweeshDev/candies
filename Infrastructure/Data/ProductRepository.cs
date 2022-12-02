using core.Entites;
using core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _contex;

        public ProductRepository(StoreContext contex)
        {
            _contex = contex;
        }
        public async Task<Product> GetProductAsync(int id)
        {
            return await _contex.Products.Include(e=>e.ProductType).FirstOrDefaultAsync(e=>e.Id == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            var products = await _contex.Products.Include(e => e.ProductType).ToListAsync();
            return products;
        }
    }
}
