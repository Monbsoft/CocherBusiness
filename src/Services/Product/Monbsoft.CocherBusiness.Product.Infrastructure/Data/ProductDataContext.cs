using Microsoft.Extensions.Options;
using Monbsoft.CocherBusiness.Product.Domain;
using MongoDB.Driver;

namespace Monbsoft.CocherBusiness.Product.Infrastructure.Data
{
    public class ProductDataContext
    {
        private readonly IMongoDatabase _database = null;

        public ProductDataContext()
        {
            var client = new MongoClient();

            if (client != null)
                _database = client.GetDatabase("");
        }

        public IMongoCollection<ProductItem> Products
        {
            get => _database.GetCollection<ProductItem>("PR_Product");
        }
    }
}
