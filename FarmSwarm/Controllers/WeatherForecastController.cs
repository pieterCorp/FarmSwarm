using FarmSwarm.Business.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace FarmSwarm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public string Get()
        {           
            return "move";
        }

        //[HttpPost]
        //public ActionResult PostSomtin(TestDto test)
        //{
        //    var iets = test;
        //    Console.WriteLine(iets.Id.ToString());
        //    Console.WriteLine(iets.Humidity.ToString());
        //    Console.WriteLine(iets.Temperature.ToString());
        //    Console.WriteLine(iets.LightIntensity.ToString());
        //    return Ok("success baby yeah!");
        //}
    }
}
