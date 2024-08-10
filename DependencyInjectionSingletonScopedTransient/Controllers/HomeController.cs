using DependencyInjectionSingletonScopedTransient.Models;
using DependencyInjectionSingletonScopedTransient.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionSingletonScopedTransient.Controllers
{
    public class HomeController : Controller
    {
        ITransientService _transientService;
        ITransientService _transientService2;

        IScopedService _scopedService;
        IScopedService _scopedService2;

        ISingletonService _singletonService;
        ISingletonService _singletonService2;

        public HomeController(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService, ITransientService transientService2, IScopedService scopedService2, ISingletonService singletonService2)
        {
            _transientService = transientService;
            _transientService2 = transientService2;

            _scopedService = scopedService;
            _scopedService2 = scopedService2;

            _singletonService = singletonService;
            _singletonService2 = singletonService2;
          
        }


        public IActionResult Index()
        {
            ViewBag.Transient1 = _transientService.GetOperationId();
            ViewBag.Transient2 = _transientService2.GetOperationId();

            ViewBag.Scoped1 = _scopedService.GetOperationId();
            ViewBag.Scoped2 = _scopedService2.GetOperationId();

            ViewBag.Singleton1 = _singletonService.GetOperationId();
            ViewBag.Singleton2 = _singletonService2.GetOperationId();

            return View();
        }

    }
}
