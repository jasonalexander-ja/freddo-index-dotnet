using Microsoft.AspNetCore.Mvc;

namespace freddo_index_dotnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CurrencyValues : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string output = System.IO.File.ReadAllText(@".\data\currency-values.json");
            return output;
        }
    }
}
