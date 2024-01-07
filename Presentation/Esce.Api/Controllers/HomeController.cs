using Microsoft.AspNetCore.Mvc;

namespace Esce.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
