using GraphQLAPITest.Models;

namespace GraphQLAPITest.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
