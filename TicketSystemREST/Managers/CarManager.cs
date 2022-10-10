using Microsoft.VisualBasic;
using TicketLibrary.model;

namespace TicketSystemREST.Managers
{
    public class CarManager : ICarManager
    {
        private static List<Car> _carTickets = new List<Car>()
        {
            new Car(){LisencePlate="XPX-F11", /*Date=DateAndTime*/},
            new Car(){LisencePlate="SS-22AB" },
            new Car(){LisencePlate="XPX-F11"},
            new Car(){LisencePlate="XPX-F11"}
        };

        public CarManager()
        {

        }

        public Car CreateCarTicket(Car newCarTicket)
        {
            if (_carTickets.Exists(ct => ct.LisencePlate == newCarTicket.LisencePlate))
                throw new ArgumentException("There is already a ticket with this license number.");

            _carTickets.Add(newCarTicket);
            return newCarTicket;
        }

        public Car GetCarByLicensePlate(string licensePlate)
        {
            return _carTickets.Find(ct => ct.LisencePlate == licensePlate);
        }

        public List<Car> GetCarTickets()
        {
            return new List<Car>(_carTickets);
        }

        public Car UpdateTicket(string licensePlate, Car car)
        {
            Car updatedCarTicket = GetCarByLicensePlate(licensePlate);
            if (updatedCarTicket != null)
            {
                updatedCarTicket.LisencePlate = car.LisencePlate;
                updatedCarTicket.Date = DateTime.Now;
            }

            return updatedCarTicket;
        }

        public Car DeleteTicket(string licensePlate)
        {
            Car deletedCarTicket = GetCarByLicensePlate(licensePlate);
            _carTickets.Remove(deletedCarTicket);
            return deletedCarTicket;
        }
    }
}
