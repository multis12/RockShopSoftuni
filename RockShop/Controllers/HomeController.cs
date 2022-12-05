﻿using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Models;
using System.Diagnostics;

namespace RockShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        private readonly IStaffService staffService;

        public HomeController(IProductService _productService
                            , IStaffService _staffService)
        {
            productService = _productService;
            staffService = _staffService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await productService.LastSevenProducts();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}