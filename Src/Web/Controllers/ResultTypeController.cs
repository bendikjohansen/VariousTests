using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultTypeController : ControllerBase
    {
        [HttpGet("actionobjectresult")]
        public ActionResult<string> ActionResultTest(ReturnType type)
            => type switch
            {
                ReturnType.Forbidden => Forbid(),
                ReturnType.Ok => Ok("Test"),
                _ => BadRequest()
            };

        [HttpGet("actionresult")]
        public ActionResult ActionResult2Test(ReturnType type)
            => type switch
            {
                ReturnType.Forbidden => Forbid(),
                ReturnType.Ok => Ok("Test"),
                _ => BadRequest()
            };

        [HttpGet("iactionresult")]
        public IActionResult ActionResult3Test(ReturnType type)
            => type switch
            {
                ReturnType.Forbidden => Forbid(),
                ReturnType.Ok => Ok("Test"),
                _ => BadRequest()
            };
    }
}
