using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;
using GraphQLAPITest.Types;

namespace GraphQLAPITest.Queries
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context =>
            {
                return menuService.GetMenus();
            });
        }
    }
}
