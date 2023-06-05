using GraphQL;
using GraphQL.Language.AST;
using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;
using GraphQLAPITest.Types;

namespace GraphQLAPITest.Mutations
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
                resolve: context =>
                {
                    return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
                });    
        }
    }
}
