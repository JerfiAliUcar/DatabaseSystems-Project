using App.Business.Services;
using App.Business.Services.Abstracts;
using App.Data.Entity;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class IphoneController : Controller
    {
        private readonly IiphoneService _iphoneService;
        private readonly IUserService _userService;

        public IphoneController(IiphoneService iphoneService, IUserService userService)
        {
            _iphoneService = iphoneService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            var iphoneList = _iphoneService.GetAllIPhonesWithPriceAndDealers();
            return View(iphoneList);
        }

        public IActionResult Detail(int id)
        {

            var iphone = _iphoneService.GetIPhoneWithPriceAndDealers(id);

            if (iphone == null)
            {
                return NotFound();
            }

            var comments = _iphoneService.GetCommentsByIphoneID(id) ?? new List<Comment>();
            var viewModel = new IphoneDetailViewModel
            {
                Iphone = iphone,
                Comments = comments,
                DealerIphones = iphone.DealerIphones?.ToList() ?? new List<DealerIphone>()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Comment(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Name=model.Name,
                    Surname=model.Surname,
                    Email=model.Email,
                    Phone=model.Phone,
                };

                var comment = new Comment 
                { 
                    CommentText=model.CommentText,
                    
                };

                _userService.InsertUser(user);
                _iphoneService.AddComment(comment);

                return RedirectToAction("Detail", new { id = model.IphoneID });
            }

            return View("Detail",model);
        }

    }

}

