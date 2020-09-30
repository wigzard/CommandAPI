using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetTest() => new string[] { "this", "is", "hard", "coded" };

        [HttpGet("test")]
        public ActionResult<IEnumerable<string>> GetSTest() => new string[] {"this", "test", "string"};
    }
}