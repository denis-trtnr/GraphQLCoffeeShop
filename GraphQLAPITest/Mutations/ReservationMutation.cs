using GraphQL;
using GraphQL.Language.AST;
using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;
using GraphQLAPITest.Types;

namespace GraphQLAPITest.Mutations
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {
            Field<ReservationType>("createReservation", arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
                resolve: context =>
                {
                    return reservationService.AddReservation(context.GetArgument<Reservation>("reservation"));
                });    
        }
    }
}
