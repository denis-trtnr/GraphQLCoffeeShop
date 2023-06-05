using GraphQL.Types;

namespace GraphQLAPITest.Types
{
    public class SubMenuInputType : InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
            Field<IntGraphType>("menuId");
        }
    }
}
