using TicketLibrary.model;

namespace TicketSystemREST.Managers
{
    public interface IMotorcycleManager
    {
        Motorcycle CreateMotorcycleTicket(Motorcycle newMotorcycleTicket);

        List<Motorcycle> GetMotorcycleTickets();

        Motorcycle GetMotorcycleByLicensePlate(string licensePlate);

        Motorcycle UpdateTicket(string licensePlate, Motorcycle mc);

        Motorcycle DeleteTicket(string licensePlate);
    }
}
