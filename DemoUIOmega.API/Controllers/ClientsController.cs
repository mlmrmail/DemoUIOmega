using DemoUIOmega.Entities.Models;
using DemoUIOmega.Entities.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUIOmega.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private RepositoryContext _context;

        public ClientsController(RepositoryContext context)
        {
            _context = context;
        }

        // GET api/clients/
        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetListOfClientsAsync()
        {

            var clients = await _context.Clients.Where(x => x.Active).ToListAsync();
            return StatusCode(400);
            return StatusCode(200, clients);

        }

        // GET api/clients/1 or api/clients?id=1 
        [HttpGet("{id}")]
        public ActionResult<Client> GetClientById(int id)
        {

            var client = _context.Clients.Where(x => x.Id == id).FirstOrDefaultAsync();

            return StatusCode(200, client);

        }

        // DELETE api/clients/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> DeleteClientById(int id)
        {
            var client = _context.Clients.Where(x => x.Id == id).FirstOrDefault();
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return StatusCode(250, "The client you are trying to delete does not exist !");
            }

        }

        // POST api/clients/
        [HttpPost]
        public async Task<ActionResult<Client>> CreateClient([FromForm]Client client)
        {
            var clientObject = _context.Clients.Where(x => x.Firstname == client.Firstname && x.Lastname == client.Lastname).FirstOrDefault();

            if (client == null)
            {
                _context.Clients.Add(client);
                await _context.SaveChangesAsync();
                var clientCreated = _context.Clients.Where(x => x.Firstname == client.Firstname && x.Lastname == client.Lastname).FirstOrDefault();

                return StatusCode(201, clientCreated);
            }
            else
            {
                return StatusCode(250, "The client you are trying to add alreadey exists !");
            }

        }




    }
}
