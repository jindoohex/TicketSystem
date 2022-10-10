using Microsoft.AspNetCore.Mvc;
using TicketSystemREST.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketSystemREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleTicketsController : ControllerBase
    {
        private static IMotorcycleManager mcmgr = new MotorcycleManager();

        // GET: api/<MotorcycleTicketsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MotorcycleTicketsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MotorcycleTicketsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MotorcycleTicketsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MotorcycleTicketsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
