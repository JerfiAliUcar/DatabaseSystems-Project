using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class DealerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
