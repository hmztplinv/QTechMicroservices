using MongoDB.Bson.Serialization.Attributes;

namespace QtechCourse.Services.Catalog.Models;

public class Category
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
}