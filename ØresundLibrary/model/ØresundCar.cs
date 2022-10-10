using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary.model;

namespace ØresundLibrary.model
{
    public class ØresundCar : Vehicle
    {
        public override string VehicleType()
        {
            return "Øresund Car";
        }

        public override double VehicleTicketPrice()
        {
            return 410;
        }

        public override double Brobizz()
        {
            return 161;
        }
    }
}
