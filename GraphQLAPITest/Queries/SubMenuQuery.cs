using GraphQL;
using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Types;

namespace GraphQLAPITest.Queries
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context =>
            {
                return subMenuService.GetSubMenus();
            });

            Field<ListGraphType<SubMenuType>>("submenuById", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }), resolve: context =>
            {
                return subMenuService.GetSubMenus(context.GetArgument<int>("id"));
            });
        }
    }
}
