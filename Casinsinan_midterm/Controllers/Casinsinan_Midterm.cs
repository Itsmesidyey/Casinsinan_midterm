/* Casinsinan, Cj C.
 * BSCS 3-1N
 * 
 * Midterm Examination
 */

using System;
using Microsoft.AspNetCore.Mvc;

namespace Casinsinan_midterm.Controllers
{
    [ApiController]
    [Route("Casinsinan_midterm")]

    public class TrigController : ControllerBase
    {
        [HttpPost]
        public ActionResult<TrigResult> Post([FromBody] TrigInput input)
        {
            var sin = Math.Sin(input.Angle); //Sine
            var cos = Math.Cos(input.Angle); //Cosine
            var tan = Math.Tan(input.Angle); //Tangent
            var result = new TrigResult { Sin = sin, Cos = cos, Tan = tan };
            return result;
        }
    }
}
