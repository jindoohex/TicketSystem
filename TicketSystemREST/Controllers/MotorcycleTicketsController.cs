using Microsoft.AspNetCore.Mvc;
using TicketLibrary.model;
using TicketSystemREST.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketSystemREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleTicketsController : ControllerBase
    {
        /// <summary>
        /// Using MotorycleManager
        /// </summary>
        private static IMotorcycleManager mcmgr = new MotorcycleManager();

        // GET: api/<MotorcycleTicketsController>
        [HttpGet]                           // Method
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            List<Motorcycle> motorcycleList = mcmgr.GetMotorcycleTickets();
            return (motorcycleList.Count == 0) ? NoContent() : Ok(motorcycleList);
        }

        // GET api/<MotorcycleTicketsController>/5
        [HttpGet("{licensePlate}")]         // URI
        public IActionResult GetMotorcycleByLicensePlate(string licensePlate)
        {
            try
            {
                Motorcycle motorcycle = mcmgr.GetMotorcycleByLicensePlate(licensePlate);
                return Ok(motorcycle);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // POST api/<MotorcycleTicketsController>
        [HttpPost]                          // Method
        public IActionResult Post([FromBody] Motorcycle motorcycle)
        {
            try
            {
                Motorcycle newMotorcycleTicket = mcmgr.CreateMotorcycleTicket(motorcycle);
                string uri = "api/MotorcycleTickets/" + motorcycle.LisencePlate;
                return Created(uri, newMotorcycleTicket);
            }
            catch (ArgumentException ae)
            {
                return Conflict(ae.Message);
            }

        }

        // PUT api/<MotorcycleTicketsController>/5
        [HttpPut]                           // Method
        [Route("{licensePlate}")]           // URI
        public IActionResult Put(string licencePlate, [FromBody] Motorcycle motorcycle)
        {
            try
            {
                return Ok(mcmgr.UpdateTicket(licencePlate, motorcycle));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // DELETE api/<MotorcycleTicketsController>/5
        [HttpDelete]                        // Method
        [Route("{licensePlate}")]           // URI
        [ProducesResponseType(StatusCodes.Status200OK)]
        // [EnableCors("OnlyGetDelete")]
        public IActionResult Delete(string licensePlate)
        {
            try
            {
                return Ok(mcmgr.DeleteTicket(licensePlate));
            }
            catch (KeyNotFoundException knfe)
            {

                return NotFound(knfe.Message);
            }

        }
    }
}
