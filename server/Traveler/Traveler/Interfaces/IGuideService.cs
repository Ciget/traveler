using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Traveler.Models;

namespace Traveler.Interfaces
{
    public interface IGuideService
    {
        Task<City> GetById(ObjectId id);
        Task<List<City>> Get(string query = "");
    }
}
