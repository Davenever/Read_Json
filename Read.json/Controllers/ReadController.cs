using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Read.json.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReadController : Controller
    {
        private IConfiguration _configuration;

        readonly Information _Information;

        readonly IOptions<Information> _options;

        readonly Json_File _json_File;
        public ReadController(IConfiguration configuration,
                              Information Information,
                              IOptions<Information> options,
                              Json_File json_File)
        {
            _configuration = configuration;
            _Information = Information;
            _options = options;
            _json_File = json_File;
        }

        [HttpGet]
        public async Task<IActionResult> ReadSystemVersion()
        {
            var configuration = _json_File.Read_Json_File();
            string system = "使用的是" + configuration["system_version:Edition"] + "的版本" + "," +
                            "项目名称是" + configuration["system_version:Project_Name"];
            return Json(new
            {
                data = system
            });
        }

        [HttpGet]
        public async Task<IActionResult> ReadInformation()
        {
            string Address = _options.Value.school.Region.Province + "-" +
                             _options.Value.school.Region.City + "-" +
                             _options.Value.school.Region.Area + "-" +
                             _options.Value.school.Detailed_address[0].Address + "-" +
                             _options.Value.school.Introduce.Name + "-" +
                             _options.Value.school.Introduce.Class + "-" +
                             _options.Value.school.Introduce.Number;
            return Json(new
            {
                data = Address
            });
        }

        [HttpPost]
        public async Task<string> ReadJson()
        {
            string conn = _configuration["Connection:dbContent"];
            string commodity = _configuration["Content:0:Trade_name:test1"];
            return "";
        }

    }
}