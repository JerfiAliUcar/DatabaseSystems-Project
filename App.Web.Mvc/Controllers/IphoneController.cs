﻿using App.Business.Services;
using App.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class IphoneController : Controller
    {
        private readonly IiphoneService _iphoneService;

        public IphoneController(IiphoneService iphoneService)
        {
            _iphoneService = iphoneService;
        }
        public IActionResult Index()
        {
            var iphoneList = _iphoneService.GetAllPhones();

            return View(iphoneList);
        }

        public IActionResult Detail(int id)
        {
            var iphone= _iphoneService.GetIPhoneWithPriceAndDealers(id);
            return View(iphone);
        }
       
    }
}