using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q7")]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Adjusts the current date by a given number of days.
        /// </summary>
        /// <param name="days">Number of days to adjust</param>
        /// <returns>Adjusted date as string (yyyy-MM-dd)</returns>
        /// <example>GET /api/q7/timemachine?days=5 → "2025-02-10"</example>
        [HttpGet("timemachine")]
        public IActionResult GetTimeMachine([FromQuery] int days)
        {
            return Ok(DateTime.Today.AddDays(days).ToString("yyyy-MM-dd"));
        }
    }
}

