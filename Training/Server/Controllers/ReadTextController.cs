using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

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
            List<string>? lines = new List<string>();
            string? aLine="";

            var dir = AppDomain.CurrentDomain.BaseDirectory;

            dir = dir.Replace("\\", "/");
            dir = dir.Substring(0, dir.IndexOf("bin"));
            dir = dir + "/data/" + filename;

            StreamReader sr = new StreamReader(dir);

            do
            {
                aLine = sr.ReadLine();
                
                if (aLine != null)
                {
                    lines.Add(aLine);
                }

            } while (aLine != null);

            sr.Close(); 

            return lines.ToArray();
        }

    }
}
