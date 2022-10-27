using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary.model
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Property for setting the date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Property for setting lisence plate of the vehicle
        /// </summary>
        public string LisencePlate { get; set; }


        /// <summary>
        /// Default constructor for the base class vehicle
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Constructor of the vehicle class that requires a liscence plate, which must be 7 characters
        /// </summary>
        /// <param name="lisencePlate">The lisencing plate of the vehicle, and must be 7 characters</param>
        /// <exception cref="ArgumentNullException">Vehicle lisence plate needs a value</exception>
        /// <exception cref="ArgumentOutOfRangeException">Vehicle lisence plate must be 7 characters</exception>
        public Vehicle(string lisencePlate)
        {
            if (string.IsNullOrEmpty(lisencePlate))
            {
                throw new ArgumentNullException();
            }

            if (lisencePlate.Length > 7) {
                throw new ArgumentException("Licenseplate must contain 7 characters at most.");
            }

            if (lisencePlate.Length < 7) {
                throw new ArgumentException("Licenseplate must contain 7 characters at least.");
            }
            this.LisencePlate = lisencePlate;
        }


        /// <summary>
        /// This method will set what kind of vehicle it is
        /// </summary>
        /// <returns>Returns vehicle type in a string format</returns>
        public abstract string VehicleType();


        /// <summary>
        /// This method will set the ticket price for the vehicle
        /// </summary>
        /// <returns>Returns the ticket price for the vehicle in double format</returns>
        public virtual double VehicleTicketPrice()
        {
            return 0;
        }


        /// <summary>
        /// This method adds 5% discount to the vehicle ticket from Brobizz
        /// </summary>
        /// <returns>Returns a new double with the discounted price</returns>
        public virtual double Brobizz()
        {
            var addedBrobizz = VehicleTicketPrice() * 0.95;
            return addedBrobizz;
        }


        /// <summary>
        /// Parsing methods into a string format readable for the user
        /// </summary>
        /// <returns>Returns a string of vehicle type and the price of that vehicle</returns>
        public override string ToString()
        {
            return $"Vehicle: {VehicleType()}\tTicket Price: {VehicleTicketPrice()}";
        }
    }
}
