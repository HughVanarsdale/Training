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
            // works: StreamReader sr = new StreamReader($@"C:\Users\hp\source\repos\Training\Training\Server\Data\{filename}");
            
            // works: StreamReader sr = new StreamReader($@"C:/Users/hp/source/repos/Training/Training/Server/Data/{filename}");

            //C:\Users\hp\source\repos\Training\Training\Server\Data

            dir = dir.Replace("\\", "/");
            dir = dir.Substring(0, dir.IndexOf("bin"));
            dir = dir + "/data/" + filename;

            StreamReader sr = new StreamReader(dir);


            //"C:\\Users\\hp\\source\\repos\\Training\\Training\\Server\\bin\\Debug\\net6.0\\"	

            do
            {
                aLine = sr.ReadLine();
                
                if (aLine != null)
                {
                    lines.Add(aLine);
                }

            } while (aLine != null);

            sr.Close(); 

//            string[] ret = new string[3];
//            ret[0] = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
//            ret[1] = "bbbbbbbbbbbbbbbbbbbbb";
//            ret[2] = "ccccccccccccccccccccccccccccccccccccc";
            return lines.ToArray();
        }

    }
}
