using DemoUIOmega.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUI.Controllers
{
    public class ClientsController : Controller
    {

        public ClientsController()
        {

        }

        public IActionResult Index()
        {
             // retrieve all the client
             // 1- create a context 
             // 2- intialize the context in services
             // 3- create a client contract --> to do DI
             // 4 - impport the context here and do the search
             // ---- UI challenge display the data into the datatables

            return View();
        }

        public IActionResult Add()
        {

            var genders =  System.Enum.GetNames(typeof(GenderType));
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
