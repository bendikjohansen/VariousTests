using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrimitiveDefaultTypeController : ControllerBase
    {
        [HttpPost("insecure")]
        public ActionResult<ExampleRequest> Insecure([FromBody] ExampleRequest request)
            => Ok(request);

        [HttpPost("secure")]
        public ActionResult<SafeExampleRequest> Secure([FromBody] SafeExampleRequest request)
            => Ok(request);
    }
}
