
using System;
using System.Collections.Generic;
using Traveler.Models;

namespace Traveler.Services
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetById(Guid id);
        List<City> Get(string query);
    }
}
