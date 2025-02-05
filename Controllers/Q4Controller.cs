using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q4")]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns the start of a knock-knock joke.
        /// </summary>
        /// <returns>"Who’s there?"</returns>
        /// <example>POST /api/q4/knockknock → "Who’s there?"</example>
        [HttpPost("knockknock")]
        public IActionResult PostKnockKnock()
        {
            return Ok("Who’s there?");
        }
    }
}
