using Monbsoft.CocherBusiness.Product.Domain;
using Monbsoft.CocherBusiness.Product.Domain.Interfaces;
using Monbsoft.CocherBusiness.Product.Infrastructure.Data;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Monbsoft.Services.Product.Api.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDataContext _context;

        public ProductRepository(ProductDataContext context)
        {
            _context = context;
        }

        public async Task<ProductItem> GetAsync(string productId)
        {
            var filter = Builders<ProductItem>.Filter.Eq("_id", productId);
            return await _context.Products
                .Find(filter)
                .FirstOrDefaultAsync();

        }
    }
}