using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAssignment.Models
{
    public class Municipality
    {
	    [BsonId]
	    public int Id { get; set; }
     
	    [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Locations")]
        public List<Location> Locations { get; set; }

        [BsonElement("Societ")]
        public List<Society> Societies { get; set; }
    }
}
