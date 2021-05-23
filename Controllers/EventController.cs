using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace O365_API.Controllers
{
    [ApiController]
    [Route("api/event")]
    public class EventController : ControllerBase
    {

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{eventId?}")]
        public GraphEvent Get(String? eventId)
        {

            return new GraphEvent
            {
                Date = DateTime.Now.AddDays(0),
                Body = "Body",
                Subject = "Subject",
                Invitees = new string[] { "foo", "bar" }

            };
        }
    }
}
