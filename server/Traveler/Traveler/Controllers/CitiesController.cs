using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Traveler.Services;

namespace Traveler.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        private ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cities = _cityService.Get();
            return new ObjectResult(cities);
        }

        // GET api/values
        [HttpGet("{query}")]
        public IActionResult Get(string query)
        {
            var cities = _cityService.Get(query);
            return new ObjectResult(cities);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var city = _cityService.GetById(id);
            return new ObjectResult(city);
        }
    }
}
