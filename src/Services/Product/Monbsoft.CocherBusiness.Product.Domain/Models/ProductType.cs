using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Monbsoft.CocherBusiness.Product.Domain
{
    public class ProductType
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Type { get; set; }
    }
}
