using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Monbsoft.CocherBusiness.Product.Domain
{
    public class ProductItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageUri { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string TypeId { get; set; }
        public string Type { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string BrandId { get; set; }
        public string Brand { get; set; }

    }
}
