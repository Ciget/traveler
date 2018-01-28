using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Traveler.Interfaces;
using Traveler.Services;

namespace Traveler.Controllers
{
    [Route("api/cities/{city}/[controller]")]
    public class PlacesController : Controller
    {
        private IPlaceService _placeService;

        public PlacesController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        [HttpGet]
        public IActionResult Get(Guid city)
        {
            var cities = _placeService.Get();
            return new ObjectResult(cities);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid city, Guid id)
        {
            var place = _placeService.GetById(id);
            return new ObjectResult(place);
        }
    }
}
