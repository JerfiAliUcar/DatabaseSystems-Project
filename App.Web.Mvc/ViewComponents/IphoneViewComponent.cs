using App.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
    public class IphoneViewComponent : ViewComponent
    {
        private readonly IiphoneService _iphoneService;

        public IphoneViewComponent(IiphoneService iphoneService)
        {
            _iphoneService = iphoneService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var iphone = _iphoneService.GetIphoneByID(id);

            return View(iphone);
        }
    }
}
