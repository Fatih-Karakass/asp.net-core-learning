using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
