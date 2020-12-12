using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.ViewModel;

namespace AdminPortal.Mvc.Services
{
    public class MenuViewService : IMenuViewService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public MenuViewService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }


        public IEnumerable<MenuViewModel> GetAll()
        {
            var _menu = (from p in _context.MstMenu
                         where p.Active == 1
                         orderby p.OrderNumber
                         select new MenuViewModel
                         {
                             ID = p.Id,
                             Name = p.Name,
                             DisplayName = p.DisplayName,
                             ControllerName = p.ControllerName,
                             ActionName = p.ActionName,
                             TargetLink = p.TargetLink,
                             SubMenu = (from o in _context.MstSubmenu
                                        where o.ParenMenutId == p.Id
                                        && o.Active == 1
                                        orderby o.Id ascending
                                        select new SubMenu
                                        {
                                            ID = o.OrderNumber,
                                            Name = o.Name,
                                            DisplayName = o.DisplayName,
                                            ControllerName = o.ControllerName,
                                            ActionName = o.ActionName,
                                            TargetLink = o.TargetLink,
                                            ChildMenu = (from i in _context.MstChildmenu
                                                         where i.Active == 1
                                                         && i.ParentMenuId == o.Id
                                                         orderby i.OrderNumber
                                                         select new ChildMenu
                                                         {
                                                             ID = i.Id,
                                                             Name = i.Name,
                                                             DisplayName = i.DisplayName,
                                                             ControllerName = i.ControllerName,
                                                             ActionName = i.ActionName,
                                                             TargetLink = i.TargetLink
                                                         }).ToList()
                                        }).ToList(),
                             icon = p.Icon
                         }).ToList();

            _menu.ForEach(x => { x.SubMenu = x.SubMenu.OrderBy(y => y.ID).ToList(); });

            return _menu;
        }
    }
}
