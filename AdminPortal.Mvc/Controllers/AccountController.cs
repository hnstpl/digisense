using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.ViewModel;
using AdminPortal.Mvc.Services;
using System.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using AdminPortal.Mvc.Extensions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminPortal.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        private IMenuViewService _menuViewService;

        //dev_generalcustomerappContext _context = new dev_generalcustomerappContext();

        public AccountController(IUserService UserService, IMenuViewService MenuViewService)
        {
            _userService = UserService;
            _menuViewService = MenuViewService;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        //GET : Login
        public IActionResult Login()
        {
            ViewBag.mg = "''";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel input)
        {
            try
            {
                //Get the user
                var User = _userService.GetUserByCred(input.Username, input.Password);

                //Throw exception if user is null
                if (User == null) throw new NullReferenceException("Incorrect username or password");

                //Get User Role
                var Role = _userService.GetRoleByRoleID(User.RoleId.Value);

                //Get Menuview Data
                var _menu = _menuViewService.GetAll();

                if (_menu == null) throw new NullReferenceException("Unable to load Menu");

                //Set sessions
                HttpContext.Session.SetString("User", User.FirstName);
                HttpContext.Session.SetString("Role", Role.RoleName);
                HttpContext.Session.SetObject("MenuMaster", _menu);

                return RedirectToAction("Index", "Home");

            }
            catch (Exception e)
            {
                ViewBag.mg = "'" + e.Message + "'";
                return View();
            }
        }

    }
}
