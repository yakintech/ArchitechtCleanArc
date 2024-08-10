using DependencyInjectionSingletonScopedTransient.Models;
using DependencyInjectionSingletonScopedTransient.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionSingletonScopedTransient.Controllers
{
    public class HomeController : Controller
    {
        ITransientService _transientService;
        IScopedService _scopedService;
        ISingletonService _singletonService;

        public HomeController(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
        }

        public IActionResult Index()
        {
            //Her istekte yeni bir instance uretilir.
            ViewBag.Transient = _transientService.GetOperationId();

            //Ayni HTTP istegi icinde ayni instance kullanilir.
            ViewBag.Scoped = _scopedService.GetOperationId();

            //Uygulama basladiginda bir kere uretilir ve uygulama kapanana kadar ayni instance kullanilir.
            ViewBag.Singleton = _singletonService.GetOperationId();

            return View();
        }

    }
}
