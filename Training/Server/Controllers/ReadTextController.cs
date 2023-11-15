using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Training.Server.Controllers
{
    [Route("api/[controller]")]
    //[Route("controller")]
    [ApiController]
    public class ReadTextController : Controller
    {

        [HttpGet("{filename}")]
        public string[] Getfile(string filename)
        {

            string[] ret = new string[3];
            ret[0] = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ret[1] = "bbbbbbbbbbbbbbbbbbbbb";
            ret[2] = "ccccccccccccccccccccccccccccccccccccc";
            return ret;
        }

    }
}
