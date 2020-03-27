using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Web.Models;
using Xunit;

namespace WebTest.Controllers
{
    public class ResultTypeControllerTest
    {
        private readonly ResultTypeController _controller = new ResultTypeController();

        [Fact]
        public void Test_Action_Result_Returns_Expected()
        {
            var forbidden = _controller.ActionResultTest(ReturnType.Forbidden);
            var ok = _controller.ActionResultTest(ReturnType.Ok);

            Assert.IsType<ForbidResult>(forbidden.Result);
            Assert.IsType<OkObjectResult>(ok.Result);
        }

        [Fact]
        public void Test_Action_Result_2_Returns_Expected()
        {
            var forbidden = _controller.ActionResult2Test(ReturnType.Forbidden);
            var ok = _controller.ActionResult2Test(ReturnType.Ok);

            Assert.IsType<ForbidResult>(forbidden);
            Assert.IsType<OkObjectResult>(ok);
        }

        [Fact]
        public void Test_IAction_Result_Returns_Expected()
        {
            var forbidden = _controller.ActionResult3Test(ReturnType.Forbidden);
            var ok = _controller.ActionResult3Test(ReturnType.Ok);

            Assert.IsType<ForbidResult>(forbidden);
            Assert.IsType<OkObjectResult>(ok);
        }
    }
}
