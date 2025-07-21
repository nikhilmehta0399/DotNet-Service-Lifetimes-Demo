
using Microsoft.AspNetCore.Mvc;
using DotNet_Service_Lifetimes_Demo.Services;

namespace DotNet_Service_Lifetimes_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuidDemoController : ControllerBase
    {
        private readonly IGuidService _service1;
        private readonly IGuidService _service2;

        public GuidDemoController(IGuidService service1, IGuidService service2)
        {
            _service1 = service1;
            _service2 = service2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {
                First = _service1.Id,
                Second = _service2.Id
            });
        }
    }
}
