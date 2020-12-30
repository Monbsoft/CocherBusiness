using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Monbsoft.CocherBusiness.Product.Domain
{
    public class ProductBrand
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Brand { get; set; }

    }
}
