using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment6.Services
{
    public class MySingletonService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
