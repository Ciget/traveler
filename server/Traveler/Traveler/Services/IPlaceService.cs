
using System;
using System.Collections.Generic;
using Traveler.Models;

namespace Traveler.Services
{
    public interface IPlaceService
    {
        List<Place> Get();
        Place GetById(Guid id);
    }
}
