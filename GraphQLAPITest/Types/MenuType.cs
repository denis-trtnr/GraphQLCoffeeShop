using GraphQL.Types;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;
using GraphQLAPITest.Services;

namespace GraphQLAPITest.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context =>
            {
                return subMenuService.GetSubMenus(context.Source.Id);
            });
        }
    }
}
