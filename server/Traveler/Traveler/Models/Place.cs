using System;

namespace Traveler.Models
{
    public class Place
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PlaceType Type { get; set; }
        public Location GeoLocation { get; set; }
        public int TimeToVisit { get; set; }
        public PlaceSchedule Schedule { get; set; }
        //price models

        public Place()
        {
            Schedule = null;
        }
    }
}
