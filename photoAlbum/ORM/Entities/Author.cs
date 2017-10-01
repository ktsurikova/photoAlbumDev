using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ORM.Entities
{
    public class Author
    {
        [BsonId]
        [BsonElement(elementName: "_id")]
        public int Id { get; set; }

        [BsonElement(elementName: "name")]
        public string Name { get; set; }
    }
}
