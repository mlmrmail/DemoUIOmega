using DemoUIOmega.Entities.Models;
using DemoUIOmega.Entities.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoUI.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ILogger<ClientsController> _logger;
        private HttpClient _client = null;

        public ClientsController(IConfiguration config,  ILogger<ClientsController> logger)
        {
            _config = config;
            
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            try
            {
                _logger.LogDebug("Retrieveing data from database");

                _client = new HttpClient();
                var response = await _client.GetAsync($"{_config["BackendAPI"]}api/clients/");
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<List<Client>>(responseString);
                _logger.LogDebug($"List of client retrieved : {JsonConvert.SerializeObject(output)}");
                _logger.LogInformation($"Total Count of client retrieved from the DB = {output.Count}");
                return View(output);

            }
            catch (Exception ex)
            {

                throw ex;
            }





                


        }

        public IActionResult Add()
        {

            var genders =  Enum.GetNames(typeof(GenderType));
            ViewBag.Genders = genders;
            return View();
        }

        [HttpPost]
        public IActionResult AddClient([FromForm]Client clientData)
        {
            return Ok();
        }

    }
}
