using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/q8")]
    public class Q8Controller : ControllerBase
    {
        private const double SmallPrice = 25.50;
        private const double LargePrice = 40.50;
        private const double TaxRate = 0.13;

        /// <summary>
        /// Calculates the total price for SquashFellows plushies.
        /// </summary>
        /// <param name="small">Number of small plushies</param>
        /// <param name="large">Number of large plushies</param>
        /// <returns>Checkout summary</returns>
        /// <example>POST /api/q8/squashfellows → "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"</example>
        [HttpPost("squashfellows")]
        public IActionResult PostSquashFellows([FromForm] int small, [FromForm] int large)
        {
            double subtotal = (small * SmallPrice) + (large * LargePrice);
            double tax = Math.Round(subtotal * TaxRate, 2);
            double total = subtotal + tax;

            return Ok($"{small} Small @ ${SmallPrice} = ${small * SmallPrice:F2}; " +
                      $"{large} Large @ ${LargePrice} = ${large * LargePrice:F2}; " +
                      $"Subtotal = ${subtotal:F2}; Tax = ${tax:F2} HST; " +
                      $"Total = ${total:F2}");
        }
    }
}

