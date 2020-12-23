using Microsoft.Extensions.Options;
using Monbsoft.Services.Product.Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monbsoft.Services.Product.Api.Data
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
