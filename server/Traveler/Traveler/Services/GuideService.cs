using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Traveler.DataAccess;
using Traveler.Interfaces;
using Traveler.Models;

namespace Traveler.Services
{
    public class GuideService : IGuideService
    {
        private readonly IGuideRepository _guideRepository;

        public GuideService(IGuideRepository guideRepository)
        {
            _guideRepository = guideRepository;
        }

        public async Task<City> GetById(ObjectId id)
        {
            return await _guideRepository.Get(id);
        }

        public async Task<List<City>> Get(string query = "")
        {
            return await _guideRepository.Get(query);
        }
    }
}
