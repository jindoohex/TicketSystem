using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary.model
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Default constructor inheriting from the base class "vehicle"
        /// </summary>
        public Car()
            :base()
        {

        }

        /// <summary>
        /// Constructor that inherits from the base class "vehicle" to which will require a string
        /// </summary>
        /// <param name="liscencePlate">A string with the lisence plate of the vehicle</param>
        public Car(string liscencePlate)
            : base(liscencePlate)
        {

        }

        /// <summary>
        /// Overrides base type from vehicle to car
        /// </summary>
        /// <returns>Returns a string with "car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// Overrides the base price of the vehicle
        /// </summary>
        /// <returns>Returns a double with 240</returns>
        public override double VehicleTicketPrice()
        {
            return 240;
        }

    }
}
