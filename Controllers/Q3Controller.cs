using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q3")]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the given integer.
        /// </summary>
        /// <param name="baseNumber">Base integer</param>
        /// <returns>Cubed value of the integer</returns>
        /// <example>GET /api/q3/cube/4 → 64</example>
        [HttpGet("cube/{baseNumber}")]
        public IActionResult GetCube(int baseNumber)
        {
            return Ok(Math.Pow(baseNumber, 3));
        }
    }
}
