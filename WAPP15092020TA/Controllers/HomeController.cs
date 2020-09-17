using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WAPP15092020TA.Common;
using WAPP15092020TA.Models;

namespace WAPP15092020TA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IDataProtectionProvider dataProtectionProvider = DataProtectionProvider.Create("WAPP15092020TA");
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EncryptData(string encData) 
        {            
            ViewBag.encString = new CipherService(dataProtectionProvider).Encrypt(encData);
            return View("Index");
        }

        public IActionResult DecryptData(string decData)
        {
            ViewBag.decString = new CipherService(dataProtectionProvider).Decrypt(decData);
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
