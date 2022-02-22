using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace APIProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public ExampleController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _configuration["data"];
            return Ok(data);
        }

        [HttpPost()]
        public async Task<IActionResult> Post()
        {
            await Task.Delay(int.Parse(_configuration["delay"]));
            var data = _configuration["data"];
            return Ok(data);
        }
    }
}
