using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TutorialsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
         {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TutorialsController> _logger;

        // The Web API will only accept tokens 1) for users, and 2) having the "access_as_user" scope for this API
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        public TutorialsController(ILogger<TutorialsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TutorialModel> Get()
        {
            return new List<TutorialModel>()
            {
                new TutorialModel(){ Title = "test",Description = "description"}
            };
        }
        [HttpPost]
        public IEnumerable<TutorialModel> Add([FromBody] TutorialModel model)
        {
            var rng = new Random();
            return null;
        }
    }
}
