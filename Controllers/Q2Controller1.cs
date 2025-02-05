using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q2")]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting message with the provided name.
        /// </summary>
        /// <param name="name">User's name</param>
        /// <returns>Greeting string</returns>
        /// <example>GET /api/q2/greeting?name=Gary → "Hi Gary!"</example>
        [HttpGet("greeting")]
        public IActionResult GetGreeting([FromQuery] string name)
        {
            return Ok($"Hi {name}!");
        }
    }
}
