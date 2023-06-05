using GraphQL;
using GraphQL.Language.AST;
using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;
using GraphQLAPITest.Types;

namespace GraphQLAPITest.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                resolve: context =>
                {
                    return menuService.AddMenu(context.GetArgument<Menu>("menu"));
                });    
        }
    }
}
