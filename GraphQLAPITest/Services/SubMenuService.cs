using GraphQLAPITest.Data;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Models;

namespace GraphQLAPITest.Services
{
    public class SubMenuService : ISubMenu
    {
        private GraphQLDbContext _dbContext;

        public SubMenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _dbContext.SubMenus.Add(subMenu);
            _dbContext.SaveChanges();
            return subMenu;
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return _dbContext.SubMenus.Where(m => m.MenuId == menuId).ToList();
        }

        public List<SubMenu> GetSubMenus()
        {
            return _dbContext.SubMenus.ToList();
        }
    }
}
