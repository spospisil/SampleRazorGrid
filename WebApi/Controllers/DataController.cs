using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSampleData")]
        public string GetSampleJsonData()
        {

            var fullPath = Path.Combine("", "Data/SampleData.json"); 

            var jsonData = System.IO.File.ReadAllText(fullPath); 
            return jsonData;

        }
    }
}