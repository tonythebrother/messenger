using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CsMessenger.Data;
using CsMessenger.Data.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CsMessenger.Models;
using Microsoft.AspNetCore.Identity;
    

namespace CsMessenger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetUsers()
        {
            return Json(_userManager.Users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}