using System;
using System.Collections.Generic;
using Traveler.Models;

namespace Traveler.Services
{
    public class CityService:ICityService
    {
        public List<City> Get(string query)
        {
            return new List<City>()
            {
                new City()
                {
                    Description = "test description",
                    Name = "kyiv",
                    Id = Guid.NewGuid(),
                    Thumbnail = "123434.png",
                    Places = new List<Place>()
                    {
                        new Place()
                        {
                            Name = "asasddvf d ",
                            Description = "asdawef dfsdfg sdfg sdfg",
                            Id = Guid.NewGuid()
                        }
                    }
                }
            };
        }

        public City GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
