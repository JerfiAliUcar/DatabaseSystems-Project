using App.Business.Services;
using App.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult List()
        {
            var users = _userService.GetAllUsers();

            return View(users);
        }
    }
}
