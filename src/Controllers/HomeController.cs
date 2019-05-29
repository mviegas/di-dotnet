using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

namespace src.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly SomeOtherService _baseService;

        public HomeController(
            SomeOtherService baseService,
            ISingletonService singletonService,
            ITransientService transientService,
            IScopedService scopedService)
        {
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
            _baseService = baseService;
        }

        public IActionResult Index()
        {
            ViewBag.Scoped = _scopedService.Id;
            ViewBag.Transient = _transientService.Id;
            ViewBag.Singleton = _singletonService.Id;

            ViewBag.ServiceScoped = _baseService.ScopedService.Id;
            ViewBag.ServiceTransient = _baseService.TransientService.Id;
            ViewBag.ServiceSingleton = _baseService.SingletonService.Id;

            return View();
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
