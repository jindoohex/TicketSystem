using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary.model;

namespace ØresundLibrary.model
{
    public class ØresundMotorcycle : Vehicle
    {
        public override string VehicleType()
        {
            return "Øresund Motorcycle";
        }

        public override double VehicleTicketPrice()
        {
            return 210;
        }

        public override double Brobizz()
        {
            return 73;
        }
    }
}
