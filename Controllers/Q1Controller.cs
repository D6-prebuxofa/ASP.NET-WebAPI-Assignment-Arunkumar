using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q1")]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A welcome string message</returns>
        [HttpGet("welcome")]
        public IActionResult GetWelcome()
        {
            return Ok("Welcome to 5125!");
        }
    }
}
