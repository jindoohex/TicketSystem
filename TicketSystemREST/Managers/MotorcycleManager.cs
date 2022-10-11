using TicketLibrary.model;

namespace TicketSystemREST.Managers
{
    public class MotorcycleManager : IMotorcycleManager
    {
        private static List<Motorcycle> _mcTickets = new List<Motorcycle>()
        {
            new Motorcycle(){LisencePlate="P1X-A22" },
            new Motorcycle(){LisencePlate="X1-HHG2"},
            new Motorcycle(){LisencePlate="VZ-KF1X"},
            new Motorcycle(){LisencePlate="SG3P-2H"}
        };

        public MotorcycleManager()
        {

        }


        public Motorcycle CreateMotorcycleTicket(Motorcycle newMotorcycleTicket)
        {
            if (_mcTickets.Exists(ct => ct.LisencePlate == newMotorcycleTicket.LisencePlate))
                throw new ArgumentException("There is already a ticket with this license number.");

            _mcTickets.Add(newMotorcycleTicket);
            return newMotorcycleTicket;
        }

        public Motorcycle GetMotorcycleByLicensePlate(string licensePlate)
        {
            return _mcTickets.Find(mct => mct.LisencePlate == licensePlate);
        }

        public List<Motorcycle> GetMotorcycleTickets()
        {
            return new List<Motorcycle>(_mcTickets);
        }

        public Motorcycle UpdateTicket(string licensePlate, Motorcycle mc)
        {
            Motorcycle updatedMotorcycleTicket = GetMotorcycleByLicensePlate(licensePlate);
            if(updatedMotorcycleTicket != null)
            {
                updatedMotorcycleTicket.LisencePlate = mc.LisencePlate;
                updatedMotorcycleTicket.Date = DateTime.Now;
            }

            return updatedMotorcycleTicket;
        }

        public Motorcycle DeleteTicket(string licensePlate)
        {
            Motorcycle deletedMotorcycleTicket = GetMotorcycleByLicensePlate(licensePlate);
            _mcTickets.Remove(deletedMotorcycleTicket);
            return deletedMotorcycleTicket;
        }
    }
}
