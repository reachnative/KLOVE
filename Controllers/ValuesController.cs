using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DailyVerses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var url = "https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1";
            HttpClient http = new HttpClient();
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Ocp-Apim-Subscription-Key", "d10161af8cf44f0c8267d571c682fda4");
            var data = http.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            return data;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
