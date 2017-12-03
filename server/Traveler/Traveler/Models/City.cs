using System;
using System.Collections.Generic;

namespace Traveler.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailFull { get; set; }
        public List<Place> Places { get; set; }

        public City()
        {
            Places = new List<Place>();
        }
    }
}
