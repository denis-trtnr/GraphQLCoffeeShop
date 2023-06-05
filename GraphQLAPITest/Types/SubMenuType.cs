using GraphQL.Types;
using GraphQLAPITest.Models;

namespace GraphQLAPITest.Types
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.ImageUrl);
            Field(m => m.Price);
            Field(m => m.MenuId);
        }
    }
}
