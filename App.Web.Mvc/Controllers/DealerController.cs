using App.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class DealerController : Controller
    {
        private readonly IDealerService _dealerService;

        public DealerController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }
        public IActionResult Index()
        {
            var dealers = _dealerService.GetAllDealers().ToList();
            return View(dealers);
        }
    }
}
