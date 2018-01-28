using MongoDB.Bson;

namespace Traveler.Models
{
    public class Place
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public PlaceType Type { get; set; }
        public Location GeoLocation { get; set; }
        public int TimeToVisit { get; set; }
        public PlaceSchedule Schedule { get; set; }
        public ObjectId FileId { get; set; }

        public Place()
        {
            Schedule = null;
        }
    }
}
