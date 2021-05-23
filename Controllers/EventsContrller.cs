using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace O365_API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventsController : ControllerBase
    {

        private readonly ILogger<EventController> _logger;

        public EventsController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        /**
         *
         *
         **/

        [HttpGet("{account}")]
        public IEnumerable<GraphEvent> GetEventsByAccount(String account)
        {

            return Enumerable.Range(1, 10).Select(index => new GraphEvent
            {
                Account = account,
                Calendar = "default",
                Date = DateTime.Now.AddDays(index),
                Body = "Body",
                Subject = "Subject",
                Invitees = new string[] { "foo", "bar" }
            })
            .ToArray();
        }




        [HttpGet("{account}/{calendar}")]
        public IEnumerable<GraphEvent> GetEventsByAccountAndCalendar(String account, String calendar)
        {

            return Enumerable.Range(1, 10).Select(index => new GraphEvent
            {
                Account = account,
                Calendar = calendar,
                Date = DateTime.Now.AddDays(index),
                Body = "Body",
                Subject = "Subject",
                Invitees = new string[] { "foo", "bar" }
            })
            .ToArray();
        }
    }
}
