
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q6")]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the area of a regular hexagon.
        /// </summary>
        /// <param name="side">Side length</param>
        /// <returns>Hexagon area</returns>
        /// <example>GET /api/q6/hexagon?side=1.5 → 5.845671475544961</example>
        [HttpGet("hexagon")]
        public IActionResult GetHexagonArea([FromQuery] double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return Ok(area);
        }
    }
}

