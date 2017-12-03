
namespace Traveler.Models
{
    public class Location
    {
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        public Location(decimal longitude, decimal latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
