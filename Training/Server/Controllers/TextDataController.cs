using Microsoft.AspNetCore.Mvc;
using Training.Shared;
using System;
using System.IO;

namespace Training.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TextDataController : ControllerBase
    {
        private readonly ILogger<TextDataController> _logger;

        public TextDataController(ILogger<TextDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<String> GetText(string fileName)
        {
            //string[] lines = File.ReadAllLines($"Data/{fileName});

            string[] ret = new string[3];
            ret[0] = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ret[1] = "bbbbbbbbbbbbbbbbbbbbb";
            ret[2] = "ccccccccccccccccccccccccccccccccccccc";
            return ret;
        }
    }
}
