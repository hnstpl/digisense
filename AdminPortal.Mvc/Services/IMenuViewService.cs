using AdminPortal.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface IMenuViewService
    {
        IEnumerable<MenuViewModel> GetAll();
    }
}
