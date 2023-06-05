using GraphQL.Types;
using GraphQLAPITest.Queries;

namespace GraphQLAPITest.Mutations
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation", resolve: context => new { });
            Field<SubMenuMutation>("submenuMutation", resolve: context => new { });
            Field<ReservationMutation>("reservationMutation", resolve: context => new { });
        }
    }
}
