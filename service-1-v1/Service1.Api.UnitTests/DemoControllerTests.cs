using System;
using Microsoft.Extensions.Logging.Abstractions;
using Service1.Api.Controllers;
using Xunit;

namespace Service1.Api.UnitTests
{
    [Trait("TestCategory","UnitTest")]
    public class DemoControllerTests
    {
        [Fact]
        public void CreateControllerInstance()
        {
            // placeholder to demonstrate a test running.
            var x = new DemoController();
            
            Assert.NotNull(x);
        }
    }
}