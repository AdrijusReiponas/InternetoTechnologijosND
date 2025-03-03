using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace InternetoTechnologijosND.Objects
{
    public class Todo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string? Name { get; set; }

        [BsonElement("IsComplete")]
        public bool IsComplete { get; set; }

        [BsonElement("UserId")]
        public int UserId { get; set; }
    }
}