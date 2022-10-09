using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary.model
{
    public class Motorcycle : Vehicle
    {
        /// <summary>
        /// Default constructor inheriting from the base class "vehicle"
        /// </summary>
        public Motorcycle()
            : base()
        {

        }

        /// <summary>
        /// Constructor that inherits from the base class "vehicle" to which will require a string
        /// </summary>
        /// <param name="liscencePlate">A string with the lisence plate of the vehicle</param>
        public Motorcycle(string liscencePlate)
            : base(liscencePlate)
        {

        }

        /// <summary>
        /// Overrides base type of vehicle to motorcycle
        /// </summary>
        /// <returns>Returns a string with "motorcycle"</returns>
        public override string VehicleType()
        {
            return "Motorcycle";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double VehicleTicketPrice()
        {
            return 125;
        }
    }
}
