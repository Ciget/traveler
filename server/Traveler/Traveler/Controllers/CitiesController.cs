﻿using System;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Traveler.Interfaces;

namespace Traveler.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        private readonly IGuideService _guideService;

        public CitiesController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cities = _guideService.Get();
            return new ObjectResult(cities);
        }

        // GET api/values
        [HttpGet("{query}")]
        public IActionResult Get(string query)
        {
            var cities = _guideService.Get(query);
            return new ObjectResult(cities);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(ObjectId id)
        {
            var city = _guideService.GetById(id);
            return new ObjectResult(city);
        }
    }
}
