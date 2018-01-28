using System.Collections.Generic;
using MongoDB.Bson;

namespace Traveler.Models
{
    public class City
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public List<ObjectId> Thumbnails { get; set; }
        public List<Place> Places { get; set; }
        public decimal Price { get; set; }

        public City()
        {
            Places = new List<Place>();
            Thumbnails = new List<ObjectId>();
        }
    }
}
