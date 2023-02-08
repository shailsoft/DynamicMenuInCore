using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DynamicMenuInCore.Models
{
    public class SideMenu : ViewComponent
    {
        private readonly ApplicationDbContext applicationDbContext;

        public SideMenu(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            SideMenuItemDto menuItems = new();
            List<MenuItem> MenuList = await (from objMenuItems in applicationDbContext.MenuItems
                                             select new MenuItem
                                             {
                                                 Name = objMenuItems.Name,
                                                 ActionName = objMenuItems.ActionName,
                                                 ControllerName = objMenuItems.ControllerName,
                                                 Url = objMenuItems.Url,
                                                 Id = objMenuItems.Id,
                                             }).ToListAsync();
            menuItems.MenuItem = MenuList;
            List<SubMenuItem> SubMenuList = new();
            foreach (var item in MenuList)
            {
                SubMenuList = await (from objSubmenu in applicationDbContext.SubMenuItem
                          where objSubmenu.MenuId == item.Id
                          select new SubMenuItem
                          {
                              Id = objSubmenu.Id,
                              SName = objSubmenu.SName,
                              SActionName = objSubmenu.SActionName,
                              SControllerName = objSubmenu.SControllerName,
                          }).ToListAsync();
            }
            menuItems.SubMenuItemList = SubMenuList;
            return View(menuItems);
        }
    }
}
