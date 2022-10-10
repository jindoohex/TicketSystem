using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØresundLibrary.Service
{
    public interface IØresundService
    {
        public string ØresundVehicleCarRename();
        public string ØresundVehicleMotorcycleRename();
        public double ØresundVehicleNewPricing();
    }
}
