using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q5")]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Returns a secret message.
        /// </summary>
        /// <param name="secret">A secret integer</param>
        /// <returns>Acknowledgement of the secret</returns>
        /// <example>POST /api/q5/secret → "Shh.. the secret is 5"</example>
        [HttpPost("secret")]
        public IActionResult PostSecret([FromBody] int secret)
        {
            return Ok($"Shh.. the secret is {secret}");
        }
    }
}
