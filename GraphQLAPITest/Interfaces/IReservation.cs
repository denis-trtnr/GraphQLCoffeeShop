using GraphQLAPITest.Models;

namespace GraphQLAPITest.Interfaces
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
