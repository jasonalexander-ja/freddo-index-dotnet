using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace freddo_index_dotnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChangePoints : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string output = System.IO.File.ReadAllText(@".\data\change-points.json");
            return output;
        }
    }
}
