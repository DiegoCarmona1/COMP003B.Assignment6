using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment6.Services;

namespace COMP003B.Assignment6.Controllers
{
    public class LifetimeDemoController : Controller
    {

        private readonly MyTransientService _transientService1;
        private readonly MyTransientService _transientService2;
        private readonly MyScopedService _scopedService1;
        private readonly MyScopedService _scopedService2;
        private readonly MySingletonService _singletonService1;
        private readonly MySingletonService _singletonService2;

        public LifetimeDemoController (MyTransientService transientService1, MyTransientService transientService2, MyScopedService scopedService1, MyScopedService scopedService2, MySingletonService singletonService1, MySingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
