using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;
using GraphQLAPITest.Types;

namespace GraphQLAPITest.Queries
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context =>
            {
                return reservationService.GetReservations();
            });
        }
    }
}
