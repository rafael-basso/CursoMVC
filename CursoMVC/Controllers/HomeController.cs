using CursoMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{       
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Razor()
        {            
            ViewBag.Message = "ViewBag criado dentro da HomeController";
            return View();
        }

        public IActionResult Carousel1()
        {
            return View();
        }

        public IActionResult Modal()
        {
            return View();
        }   
             
        public IActionResult Validation()
        {
            ViewBag.Message = "teste vindo da controller";
            return View();
        }

        public IActionResult TestarAction() {
          return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
