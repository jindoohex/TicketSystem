using TicketLibrary.model;

namespace TicketSystemREST.Managers
{
    public interface ICarManager
    {
        Car CreateCarTicket(Car newCarTicket);

        List<Car> GetCarTickets();

        Car GetCarByLicensePlate(string licensePlate);

        Car UpdateTicket(string licensePlate, Car car);

        Car DeleteTicket(string licensePlate);
    }
}
