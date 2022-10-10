using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary.model;

namespace StorebæltLibrary.model
{
    public class WeekendDiscount
    {
        /// <summary>
        /// Initializing objects from the external DLLs
        /// </summary>
        private Car car = new();
        private Motorcycle mc = new();


        /// <summary>
        /// 
        /// </summary>
        public double Discount { get; set; }
        public DateTime date { get; set; }


        /// <summary>
        /// Default constructor for the weekend discount
        /// </summary>
        public WeekendDiscount()
        {

        }


        /// <summary>
        /// Parameterized constructor for the weekend discount
        /// </summary>
        /// <param name="discount"></param>
        public WeekendDiscount(double discount)
        {
            Discount = discount;
        }

        /// <summary>
        /// This method calculates the wekeend discount based on weekend days
        /// </summary>
        /// <param name="discount">Discount of type: double</param>
        /// <returns>Returns the discounted price if day of the week is on a weekend day</returns>
        public double CarStorebæltWeekendDiscount()
        {
            //DayOfWeek dw = DateTime.Today.DayOfWeek;
            double discountedPrice = car.VehicleTicketPrice();

            bool saturday = true;
            bool sunday = true;

            if (saturday == true)
            {
                return car.VehicleTicketPrice() * 0.80;
            }

            if (sunday == true)
            {
                return car.VehicleTicketPrice() * 0.80;
            }

            //if (dw == DayOfWeek.Saturday || dw == DayOfWeek.Sunday)
            //{
            //    car.VehicleTicketPrice() * 0.80;
            //}
            
            //if (dw == DayOfWeek.Saturday || dw == DayOfWeek.Sunday)
            //{
            //    car.VehicleTicketPrice() * 0.80;
            //}
            return discountedPrice;
        }
    }
}
