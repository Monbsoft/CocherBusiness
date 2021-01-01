using Microsoft.Extensions.Options;
using Monbsoft.CocherBusiness.Product.Domain;
using Monbsoft.CocherBusiness.Product.Infrastructure.Configuration;
using MongoDB.Driver;

namespace Monbsoft.CocherBusiness.Product.Infrastructure.Data
{
    public class ProductDataContext
    {
        private readonly IMongoDatabase _database = null;

        public ProductDataContext(IOptions<ProductSettings> settings)
        {
            var client = new MongoClient(settings.Value.MongoConnectionString);

            if (client != null)
                _database = client.GetDatabase(settings.Value.MongoDatabase);
        }

        public IMongoCollection<ProductItem> Products
        {
            get => _database.GetCollection<ProductItem>("PR_Product");
        }
    }
}
