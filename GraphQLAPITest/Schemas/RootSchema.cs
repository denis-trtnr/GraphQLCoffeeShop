using GraphQL.Types;
using GraphQLAPITest.Mutations;
using GraphQLAPITest.Queries;

namespace GraphQLAPITest.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
