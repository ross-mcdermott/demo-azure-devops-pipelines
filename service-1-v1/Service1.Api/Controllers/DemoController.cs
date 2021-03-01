using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Service1.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {
        }

        [HttpGet]
        public Demo Get()
        {
            var demo = new Demo();
            demo.Foo = "Bar5";

            return demo;
        }
    }
}
