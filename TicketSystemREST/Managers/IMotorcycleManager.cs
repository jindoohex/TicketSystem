using TicketLibrary.model;

namespace TicketSystemREST.Managers
{
    public interface IMotorcycleManager
    {
        Car CreateMotorcycleTicket(Car newCarTicket);

        List<Motorcycle> GetMotorcycleTickets();

        Car GetMotorcycleByLicensePlate(string licensePlate);

        Car UpdateTicket(string licensePlate, Motorcycle mc);

        Car DeleteTicket(string licensePlate);
    }
}
