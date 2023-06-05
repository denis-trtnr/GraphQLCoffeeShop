using GraphQL.Types;
using GraphQLAPITest.Models;

namespace GraphQLAPITest.Types
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.TotalPeople);
            Field(m => m.Date);
            Field(m => m.Time);
            Field(m => m.Email);
            Field(m => m.Phone);
        }
    }
}
