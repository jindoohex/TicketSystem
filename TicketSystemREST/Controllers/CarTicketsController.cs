using Microsoft.AspNetCore.Mvc;
using TicketLibrary.model;
using TicketSystemREST.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketSystemREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTicketsController : ControllerBase
    {
        /// <summary>
        /// Using the CarManager
        /// </summary>
        private static ICarManager cmgr = new CarManager();


        // GET: api/<CarTicketsController>
        [HttpGet]                           // Method
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            List<Car> carList = cmgr.GetCarTickets();
            return (carList.Count == 0) ? NoContent() : Ok(carList);
        }

        // GET api/<CarTicketsController>/5 // Method
        [HttpGet("{licensePlate}")]         // URI
        public IActionResult GetCarByLicensePlate(string licensePlate)
        {
            try
            {
                Car car = cmgr.GetCarByLicensePlate(licensePlate);
                return Ok(car);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // POST api/<CarTicketsController>
        [HttpPost]                          // Method
        public IActionResult Post([FromBody] Car car)
        {
            try
            {
                Car newCarTicket = cmgr.CreateCarTicket(car);
                string uri = "api/CarTickets/" + car.LisencePlate;
                return Created(uri, newCarTicket);
            }
            catch (ArgumentException ae)
            {
                return Conflict(ae.Message);
            }

        }

        // PUT api/<CarTicketsController>/5
        [HttpPut]                           // Method
        [Route("{licensePlate}")]           // URI
        public IActionResult Put(string licencePlate, [FromBody] Car car)
        {
            try
            {
                return Ok(cmgr.UpdateTicket(licencePlate, car));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // DELETE api/<CarTicketsController>/5
        [HttpDelete]                        // Method
        [Route("{licensePlate}")]           // URI
        [ProducesResponseType(StatusCodes.Status200OK)]
        // [EnableCors("OnlyGetDelete")]
        public IActionResult Delete(string licensePlate)
        {
            try
            {
                return Ok(cmgr.DeleteTicket(licensePlate));
            }
            catch (KeyNotFoundException knfe)
            {

                return NotFound(knfe.Message);
            }

        }
    }
}
